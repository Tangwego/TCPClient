using System;
using System.Collections.Generic;
using System.Text;

namespace TcpClient.Utils
{
    public class Message
    {
        private String TxnCd;
        private String SendMsg;

        public void setTxnCd(String outTxnCd)
        {
            this.TxnCd = outTxnCd;
        }

        public String getTxnCd() {
            return this.TxnCd;
        }

        public void setSendMsg(String outSendMsg)
        {
            this.SendMsg = outSendMsg;
        }

        public String getSendMsg()
        {
            return this.SendMsg;
        }


    }
}
