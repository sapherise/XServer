using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace UDP {
    class Program {
        static void Main(string[] args) {
            // int recv;
            // byte[] data = new byte[1024];
            // List<EndPoint> arrRemote = new List<EndPoint>();

            // // 得到本机 IP，设置端口号         
            // IPEndPoint ip = new IPEndPoint(IPAddress.Any, 8001);
            // Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            // newsock.Bind(ip);
            // Console.WriteLine("服务器已开启。");


            // 	IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
            // 	EndPoint Remote = (EndPoint)(sender);
            
            // while (true) {
            // 	IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
            // 	EndPoint Remote = (EndPoint)(sender);
            // 	// 当客户端发送了进入的消息时，把它的 IP 记录进来
            //     recv = newsock.ReceiveFrom(data, ref Remote);
            // 	// if (string.Equals(content, "ENTER")) {
            // 	// 	arrRemote.Add(Remote);
            // 	// 	Console.WriteLine("成功！");
            // 	// }
            // 	var a = Encoding.UTF8.GetString(data);
            // 	Console.WriteLine(a);

            //     data = new byte[1024];
            //     recv = newsock.ReceiveFrom(data, ref Remote);
            //     // 发送接收信息

            // 	var b = Encoding.UTF8.GetString(data);
            // 	Console.WriteLine(b);

            //     newsock.SendTo(data, Remote);

            // 	Console.WriteLine("==");

            //     // foreach (EndPoint s in arrRemote) {
            //     // 	Console.WriteLine(content + s);
            //     // }


            // }

            var remote = new IPEndPoint(IPAddress.Parse("192.168.0.200"), 20001);
            var client = new UdpClient(8001);
            byte[] a = Encoding.UTF8.GetBytes("lol");

            while (true) {
            	Console.WriteLine("==");
            	client.Send(a, a.Length, remote);
            	System.Threading.Thread.Sleep(1000);
            }
        }



    }
}