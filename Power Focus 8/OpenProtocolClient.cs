using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Power_Focus_8
{
    public class OpenProtocolClient
    {
        private TcpClient tcpClient;
        private NetworkStream stream;
        private bool isConnected = false;

        public event EventHandler<string> MessageReceived;
        public event EventHandler<bool> ConnectionChanged;

        public bool IsConnected => isConnected;

        public async Task<bool> ConnectAsync(string ipAddress, int port)
        {
            try
            {
                tcpClient = new TcpClient();
                await tcpClient.ConnectAsync(ipAddress, port);
                stream = tcpClient.GetStream();
                isConnected = true;

                ConnectionChanged?.Invoke(this, true);

                _ = Task.Run(ReceiveMessages);

                return true;
            }
            catch (Exception)
            {
                isConnected = false;
                ConnectionChanged?.Invoke(this, false);
                return false;
            }
        }

        public void Disconnect()
        {
            try
            {
                isConnected = false;
                stream?.Close();
                tcpClient?.Close();
                ConnectionChanged?.Invoke(this, false);
            }
            catch (Exception) { }
        }

        public async Task<bool> SendMessageAsync(string message)
        {
            if (!isConnected || stream == null)
                return false;

            try
            {
                byte[] data = Encoding.ASCII.GetBytes(message);
                await stream.WriteAsync(data, 0, data.Length);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private async Task ReceiveMessages()
        {
            byte[] buffer = new byte[1024];

            while (isConnected && tcpClient != null && tcpClient.Connected)
            {
                try
                {
                    int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                    if (bytesRead > 0)
                    {
                        string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                        MessageReceived?.Invoke(this, message);
                    }
                }
                catch (Exception)
                {
                    break;
                }
            }

            isConnected = false;
            ConnectionChanged?.Invoke(this, false);
        }
    }
}
