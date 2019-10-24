using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace TcpClient.Utils
{
    public class SocketUtil
    {
        public enum PADDING{
            LEFT, RIGHT
        };
        public static String getResponse(String ipStr, int port, String message, int lenBit) {
            String result = String.Empty;
            Socket socket = null;
            try
            {
                String encoding = "UTF-8";
                IPAddress ip = IPAddress.Parse(ipStr);
                IPEndPoint endPoint = new IPEndPoint(ip, port);

                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.SendTimeout = 120000;
                socket.ReceiveTimeout = 120000;
                socket.SendBufferSize = 120000;
                socket.ReceiveBufferSize = 120000;
                socket.Connect(endPoint);

                byte[] sendBuf = getEncodingBytes(message, encoding);

                socket.Send(sendBuf);

                byte[] recvBuf = new byte[1024];
                List<byte> data = new List<byte>();
                int length = 0;
                int index = 0;

                int len = 0;

                index = socket.Receive(recvBuf);
                length += index;
                for (int j = 0; j < index; j++)
                {
                    data.Add(recvBuf[j]);
                }

                len = Int32.Parse(getEncodingString(recvBuf, encoding).Substring(0,lenBit));

                while (true) {
                    index = socket.Receive(recvBuf);
                    length += index;
                    for (int j = 0; j < index; j++)
                    {
                        data.Add(recvBuf[j]);
                    }

                    if (length < len)
                    {
                        continue;
                    }
                    else {
                        break;
                    }
                }

                if (data.Count > 0) {
                    result = getEncodingString(data.ToArray(), encoding);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + ":" + e.StackTrace);
                return null;
            }
            finally {
                if (socket.Connected) {
                    socket.Shutdown(SocketShutdown.Both);
                }
                socket.Close();
            }
            return result;
        }

        public static byte[] getEncodingBytes(String text, String encoding) {
            byte[] bytes = null;
            switch (encoding)
            {
                case "UTF8":
                case "UTF-8":
                case "utf8":
                case "utf-8":
                    bytes = Encoding.UTF8.GetBytes(text);
                    break;
                default:
                    bytes = Encoding.ASCII.GetBytes(text);
                    break;
            }
            return bytes;
        }

        public static String getEncodingString(byte[] bytes, String encoding)
        {
            String result = null;
            switch (encoding)
            {
                case "UTF8":
                case "UTF-8":
                case "utf8":
                case "utf-8":
                    result = Encoding.UTF8.GetString(bytes);
                    break;
                default:
                    result = Encoding.ASCII.GetString(bytes);
                    break;
            }
            return result;
        }

        public static int checkChineseNum(String message)
        {
            int num = 0;
            foreach (char t in message){
                if ((int)t > 127) {
                    num++;
                }
            }
            return num;
        }

        public static String fillString(Object o, int bit, char chr, PADDING padding) {
            String result = null;

            switch (padding) { 
                case PADDING.LEFT:
                    result = o.ToString().PadLeft(bit, chr);
                    break;
                case PADDING.RIGHT:
                    result = o.ToString().PadRight(bit, chr);
                    break;
                default: break;
            }

            return result;
        }
    }
}
