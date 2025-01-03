using System.Net.Sockets;
using System.Net;
using Serilog;
using System.Reflection;
using NTR.GameServer.Protocol;

namespace NTR.GameServer
{
    public class GameServer 
    {
        private readonly TcpListener listener;

        private static GameServer _instance;
        public static readonly int GameServerPort = 6969;

        public static GameServer Instance
        {
            get
            {
                return _instance ??= new GameServer();
            }
        }

        public GameServer()
        {
            listener = new(IPAddress.Parse("0.0.0.0"), GameServerPort);
        }

        public void Start()
        {
            while (true)
            {
                try
                {
                    listener.Start();

                    Log.Information($"{nameof(GameServer)} started and listening on port {GameServerPort}");

                    while (true)
                    {
                        TcpClient tcpClient = listener.AcceptTcpClient();
                        string id = tcpClient.Client.RemoteEndPoint!.ToString()!;

                        Log.Information($"{id} connected");

                        Task.Run(() => HandleMessage(tcpClient)); 
                    }
                } catch (Exception ex)
                {
                    Log.Information("TCP listener error: " + ex.Message);
                }
            }
        }
        public void HandleMessage(TcpClient tcpClient)
        {
            Connection connection = Connection.CreateConnection(tcpClient);

            connection.HandleMessage(tcpClient);
        }
    }
}