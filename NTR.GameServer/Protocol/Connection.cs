using Serilog;
using System.IO;
using System.Net.Sockets;
using System.Reflection;

namespace NTR.GameServer.Protocol
{
    public class Connection
    {
        private TcpClient tcpClient;

        private BinaryReader reader;

        private long sendSequence;

        private int messageCount_;
        
        private int sendingMessageCount_;

        public static Connection CreateConnection(TcpClient tcpClient)
        {
            return new Connection(tcpClient);
        }

        public Connection(TcpClient tcpClient) {
            this.tcpClient = tcpClient;
            this.reader = new BinaryReader(new StreamReader(tcpClient.GetStream()).BaseStream);
        }

        public void HandleMessage(TcpClient tcpClient)
        {
            while (tcpClient.Connected)
            {
                if (tcpClient.GetStream().DataAvailable)
                {
                    string message = reader.ReadString();
                    Log.Information($"Received message: {message}");
                }
            }

            tcpClient.Close();
            Log.Information("Client Disconnected!");
        }
    }
}
