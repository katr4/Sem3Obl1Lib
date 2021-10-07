using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Sem3Obl1Lib;

namespace Obl5TCP
{
    class Server
    {
        private static readonly List<FootballPlayer> Objects = new List<FootballPlayer>
        {
            new FootballPlayer(1,"Susie", 60, 6),
            new FootballPlayer(2,"Annalise", 46, 14),
            new FootballPlayer(3,"Anton", 76, 57),
            new FootballPlayer(4,"Marjorie", 300, 76),
            new FootballPlayer(5,"Liam", 100, 8)
        };

        public Server()
        {

        }

        public void Start()
        {
            TcpListener listener = new TcpListener(2121);
            listener.Start();
            {
                while (true)
                {
                    TcpClient socket = listener.AcceptTcpClient();

                    Task.Run(() =>
                    {
                        TcpClient tempSocket = socket;
                        DoClient(tempSocket);
                    });
                }

            }
        }

        public void DoClient(TcpClient socket)
        {
            using (StreamReader sr = new StreamReader(socket.GetStream()))
            using (StreamWriter sw = new StreamWriter(socket.GetStream()))
            {
                string line1 = sr.ReadLine();

                if (line1 == "GetAll")
                {
                    Console.WriteLine("Received string " + line1);
                    foreach (var f in Objects)
                    {
                        sw.WriteLine(JsonSerializer.Serialize(f));
                    }
                }
                else if (line1 == "Get")
                {
                    Console.WriteLine("Received string " + line1);
                    string line2 = sr.ReadLine();
                    if (line2 == "")
                    {
                        sw.WriteLine("Id needed");
                        line2 = sr.ReadLine();
                    }
                    Console.WriteLine("Received string " + line2);
                    int id = Int32.Parse(line2);
                    
                    foreach (var f in Objects)
                    {
                        if (f.Id == id)
                        {
                            sw.WriteLine(JsonSerializer.Serialize(f));
                        }
                    }
                    
                }
                else {
                    sw.WriteLine("Input not accepted. Use 'GetAll' or 'Get'");
                }

                sw.Flush();
            }
        }
    }
}
