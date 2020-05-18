﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace OnlineQuiz
{
    public class Client
    {
        public TcpClient tcpClient;
        public NetworkStream ns;
        public string strSignal;

        public void CloseConnection()
        {
            ns.Close();
            tcpClient.Close();            
        }

        public Client()
        {
            tcpClient = new TcpClient();
            tcpClient.Connect(IPAddress.Parse("127.0.0.1"), 8080);
            ns = tcpClient.GetStream();
            strSignal = "";
        }
    }
}