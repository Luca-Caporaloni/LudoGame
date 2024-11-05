using System;
using System.Net.Sockets;
using System.Text;

namespace Networking
{
    public class SocketClient
    {
        private TcpClient client;
        public event Action<string> OnMessageReceived;

        public void ConnectToServer(string serverIp, int port = 8080)
        {
            client = new TcpClient();
            client.Connect(serverIp, port);
            StartReading();
        }

        private async void StartReading()
        {
            byte[] buffer = new byte[1024];
            while (true)
            {
                int byteCount = await client.GetStream().ReadAsync(buffer, 0, buffer.Length);
                if (byteCount > 0)
                {
                    string message = Encoding.UTF8.GetString(buffer, 0, byteCount);
                    OnMessageReceived?.Invoke(message);
                }
            }
        }

        public void SendMessage(string message)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            client.GetStream().Write(buffer, 0, buffer.Length);
        }
    }
}
