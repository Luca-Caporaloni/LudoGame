using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Networking
{
    public class SocketClient
    {
        private TcpClient client;
        private NetworkStream stream;
        private string serverIp;
        private int serverPort;

        public event Action<string> OnMessageReceived;

        public SocketClient(string ip, int port)
        {
            serverIp = ip;
            serverPort = port;
        }

        public void Connect()
        {
            client = new TcpClient(serverIp, serverPort);
            stream = client.GetStream();
            Console.WriteLine("Conectado al servidor.");
            Thread receiveThread = new Thread(ReceiveMessages);
            receiveThread.Start();
        }

        private void ReceiveMessages()
        {
            byte[] buffer = new byte[1024];
            int bytesRead;

            while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) != 0)
            {
                string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                OnMessageReceived?.Invoke(message);
            }
        }

        public void SendMessage(string message)
        {
            byte[] data = Encoding.ASCII.GetBytes(message);
            stream.Write(data, 0, data.Length);
        }

        public void Disconnect()
        {
            client.Close();
            Console.WriteLine("Desconectado del servidor.");
        }
    }
}
