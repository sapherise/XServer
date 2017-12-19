using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace UdpApplication {
	class Udp {
		public Int32 serverPort;
		static UdpClient client;

		public void Setup() {
			client = new UdpClient(serverPort);
		}
		
		// remoteIP 客户端 IP
		// remotePort 客户端端口
		// content 发送内容 
		public void Send(string remoteIP, Int32 remotePort, string content) {
			var remote = new IPEndPoint(IPAddress.Parse(remoteIP), remotePort);
			var data = Encoding.UTF8.GetBytes(content);
			client.Send(data, data.Length, remote);
			Console.WriteLine("发送完毕");
		}
	}

	class Program {
		static Udp client;
		static void Main(string[] args) {
			client = new Udp();
			client.serverPort = 8001;
			client.Setup();
			client.Send("192.168.0.200", 20001, "234");
		}
	}
}