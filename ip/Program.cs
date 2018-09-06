using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;



namespace ip
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        public void getIP()
        {
            //获取本地机器名
            string myHostName = Dns.GetHostName();
            //获取本地ip
            string myHostIP = Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault<IPAddress>(a => a.AddressFamily.ToString().Equals("InterNetwork")).ToString();
            //截取IP网段
            string ipDuan = myHostIP.Remove(myHostIP.LastIndexOf('.'));
            //枚举网段计算机
            Ping myPing = new Ping();
            string data = "";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            for(int i=1;i<=255;i++)
            {
                string pingIP = ipDuan + "." + i.ToString();
                PingReply pingReply = myPing.Send(pingIP, 120, buffer);
                if ( pingReply.Status == IPStatus.Success )
                {
                    
                }
            }
        }
    }
}
