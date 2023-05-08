﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace IP_test_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = GetInternalIP();
            foreach (var network in NetworkInterface.GetAllNetworkInterfaces())
            {
                label2.Text = label2.Text + network.Name + "\n";
            }
                
        }

        public static string GetInternalIP()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }

            throw new Exception("IPv4 주소를 찾을 수 없습니다.");
        }

        public static string GetIp()
        {
            string IPs = "";

            //모든 네트워크 인터페이스 얻기
            foreach (var network in NetworkInterface.GetAllNetworkInterfaces())
            {
                //IPv4를 지원하는 네트워크 확인
                if (network.Supports(NetworkInterfaceComponent.IPv4) == true)
                {
                    //이더넷 타입 확인
                    if (network.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                    {
                        //IP 속성 얻기
                        IPInterfaceProperties properties = network.GetIPProperties();
                        //Unicast 주소가 할당된 ip 얻기
                        foreach (UnicastIPAddressInformation uniIp in network.GetIPProperties().UnicastAddresses)
                        {
                            if (uniIp.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                            {
                                string ipAddress = uniIp.Address.ToString();
                                string subNetMask = uniIp.IPv4Mask.ToString();
                            }
                        }
                    }
                }
            }

            return IPs;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
