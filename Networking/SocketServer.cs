using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Networking
{
    public class SocketServer
    {
        private TcpListener server;
        public List<TcpClient> connectedClients = new List<TcpClient>();

        public event Action<string> OnMessageReceived;

        public void StartServer(int port = 8080)
        {
            server = new TcpListener(IPAddress.Any, port);
            server.Start();
            AcceptClient();
        }

        private async void AcceptClient()
        {
            while (true)
            {
                TcpClient client = await server.AcceptTcpClientAsync();
                connectedClients.Add(client);
                ReceiveMessage(client);
            }
        }

        private async void ReceiveMessage(TcpClient client)
        {
            byte[] buffer = new byte[1024];
            while (true)
            {
                int byteCount = await client.GetStream().ReadAsync(buffer, 0, buffer.Length);
                if (byteCount > 0)
                {
                    string message = Encoding.UTF8.GetString(buffer, 0, byteCount);
                    OnMessageReceived?.Invoke(message);
                    BroadcastMessage(message); // Broadcast to all clients
                }
            }
        }

        public void BroadcastMessage(string message)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            foreach (var client in connectedClients)
            {
                client.GetStream().Write(buffer, 0, buffer.Length);
            }
        }
    }
}
