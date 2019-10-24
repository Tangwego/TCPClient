using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TcpClient.Utils;
using System.Threading;

namespace TcpClient
{
    public partial class Form1 : Form
    {
        delegate void SetTextCallback(String text);
        public Form1()
        {
            InitializeComponent();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            String ip = "127.0.0.1";
            int port = 8080;
            String text = this.sendText.Text.ToString();
            int len = SocketUtil.getEncodingBytes(text,"utf-8").Length;
            int bit;
            try
            {
                ip = this.urlText.Text.ToString().Trim();
                port = Int32.Parse(this.portText.Text.ToString().Trim());
                bit = Int32.Parse(this.lenBit.Text.ToString().Trim());
            }
            catch (Exception ex) {
                MessageBox.Show("IP或端口格式不正确."); 
                return;
            }
            if (text == null || text.Equals("")) {
                MessageBox.Show("请输入发送的报文.");
                return;
            }

            String filLen = SocketUtil.fillString(len, bit, '0', SocketUtil.PADDING.LEFT);
            Object[] objs = new Object[] { ip, port, filLen + text,bit};
            Thread thread = new Thread(this.fillResponse);
            thread.Start(objs);
        }

        private void fillResponse(Object param) {
            Object[] datas = (Object[])param;
            String ip = datas[0].ToString();
            int port = (Int32)datas[1];
            String message = datas[2].ToString();
            int lenBit = (Int32)datas[3];
            String res = null;
            res = SocketUtil.getResponse(ip, port, message,lenBit);
            if (res == null || res.Equals(""))
            {
                MessageBox.Show("接收数据失败!");
                return;
            }
            
            res = res.Substring(lenBit);
            updateResponse(res);
            updateLabel(res.Length + "");
        }

        private void updateResponse(String res)
        {
            if (this.recvText.InvokeRequired)
            {
                SetTextCallback yi = new SetTextCallback(updateResponse);
                this.Invoke(yi, new Object[] { res });
            }
            else
            {
                this.recvText.Text = res;
            }
            
        }

        private void updateLabel(String len)
        {
            if (this.lenText.InvokeRequired)
            {
                SetTextCallback er = new SetTextCallback(updateLabel);
                this.Invoke(er, new Object[] { len });
            }
            else
            {
                this.lenText.Text = "返回长度: " + len;
            }

        }

    }
}
