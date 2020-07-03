using System.Net;
using System.Net.Sockets;

namespace ClassOnlineQuiz
{
    public class Client
    {
        public TcpClient tcpClient;
        public NetworkStream ns;

        public void CloseConnection()
        {
            ns.Close();
            tcpClient.Close();            
        }

        public Client()
        {
            try
            {
                tcpClient = new TcpClient();
                tcpClient.Connect(IPAddress.Parse("127.0.0.1"), 8080);
                ns = tcpClient.GetStream();
            }

            catch
            {
            }
        }
    }
}
