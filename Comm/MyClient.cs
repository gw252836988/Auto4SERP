using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using Model;     
namespace Comm
{
    public class MyClient
    {
        const int PORTNO = 8081;
        const string SERVERIP = "172.16.1.6";
        private TcpClient client;

        private byte[] data;
        private string partialStr;

        public Action<string> NotifyAct;
        public Action<Msg> MessageAct;
        public Action<List<string>> UserAct;

        private List<Msg> lstMessage;
        private List<string> lstUsers;
        private static MyClient mInstance=new MyClient();

        public bool IsConnected
        {
            get;
            set;

        }

        public bool IsOpenWindow
        {
            get;
            set;

        }

        public static MyClient  getInstance()
        {
            if (mInstance == null)
                mInstance = new MyClient();
            return mInstance;
        }

        private MyClient()
        {

            client = new TcpClient();

            data = new byte[client.ReceiveBufferSize];  
            lstMessage = new List<Msg>();
            lstUsers = new List<string>();
            
        }

        //~MyClient()
        //{
        //    Close();

        //    mInstance = null;
        //}
        public void Connect()
        {
       
           
            client.BeginConnect(SERVERIP, PORTNO, ConnetCallBack, null);
            //mInstance = null;

        }

        public List<Msg> getMessages()
        {

            return lstMessage;

        }


        public List<string> getUsers()
        {

            return lstUsers;
        }




        
        public void Close()
        {

          

            try
            {
               
                    client.GetStream().Close();
                    client.Close();
                    IsConnected = false;
              
            }
            catch (Exception ex)
            {


                Console.WriteLine(ex.ToString());
            }

        }

        private void OnNotify(string msg)
        {
            if (NotifyAct != null)
            {
                NotifyAct(msg);

            }

        }

        private void OnSendMessage(Msg msg)
        {
            if (MessageAct != null)
                MessageAct(msg);

        }
        private void ConnetCallBack(IAsyncResult ar)
        {
            try
            {
                client.EndConnect(ar);
                if (client.Connected)
                {
                   // IsConnected = true;

                    string nickname= Comm.LoginInfoShare.getInstance().UserName + "(" +Comm.LoginInfoShare.getInstance().UserId + ")";
                    //发送昵称
                    SendMessage("join|" + "{'NickName':'" +nickname + "'}");
                    client.GetStream().BeginRead(data, 0, System.Convert.ToInt32(client.ReceiveBufferSize), ReceiveMessage, null);
                }
              //  OnNotify("connect success");
            }
            catch (SocketException ex)
            {

                IsConnected = false;
                Console.WriteLine(ex.Message);
                OnNotify("connect failed");
            }

        }



        private void ReceiveMessage(IAsyncResult ar)
        {
            try
            {
                int bytesRead;

                if (client.Connected == false)
                    return;

                lock (client.GetStream())
                {
                    bytesRead = client.GetStream().EndRead(ar);

                }
              //  bytesRead = client.GetStream().EndRead(ar);

                if (bytesRead < 1)
                    return;
                else
                {
                    string messageReceived;
                    int i = 0;
                    int start = 0;

                    while (data[i] != 0)
                    {
                        if (i + 1 > bytesRead)
                            break;
                        if (data[i] == 10)
                        {
                            messageReceived = partialStr + Encoding.UTF8.GetString(data, start, i - start);
                            //  showText(messageReceived);
                           doMessage(messageReceived);
                            start = i + 1;
                        }
                        i = i + 1;
                    }

                    if (start != i)
                        partialStr = Encoding.UTF8.GetString(data, start, i - start);

                }
         
                client.GetStream().BeginRead(data, 0, System.Convert.ToInt32(client.ReceiveBufferSize), ReceiveMessage, null);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);


            }


        }



        private void doMessage(string message)
        {
            string[] strLst;
            string data;

            strLst = message.Split('|');
            data = strLst[1];
            //if (message.StartsWith("JoinFailed"))
            //{

            //    Newtonsoft.Json.Linq.JObject jobject = Newtonsoft.Json.Linq.JObject.Parse(data);
            // //   showText(jobject["message"].ToString());
            //   // OnSendMessage(jobject["message"].ToString());
               

            //    Close(); 
            //    OnNotify(jobject["message"].ToString());
            //    return false;

            //}
            if (message.StartsWith("Notify"))
            {
              //  Newtonsoft.Json.Linq.JObject jobject = Newtonsoft.Json.Linq.JObject.Parse(data);
               // showText(jobject["message"].ToString());
              //  OnNotify("有新消息(点我)"); ;
              //  OnSendMessage(jobject["message"].ToString());
                //client.GetStream().BeginRead(data, 0, System.Convert.ToInt32(client.ReceiveBufferSize), ReceiveMessage, null);
                IsConnected = true;
                OnNotify("connect success");
                
            }
            else if (message.StartsWith("RecvMsg"))
            {
                Newtonsoft.Json.Linq.JObject jobject = Newtonsoft.Json.Linq.JObject.Parse(data);

                Msg m = new Msg(jobject["sender"].ToString(), jobject["content"].ToString());
                lstMessage.Add(m);
                if(!IsOpenWindow)
                   OnNotify("有新消息(点我)");
                OnSendMessage(m);
                //OnSendMessage(jobject["message"].ToString());

            }

            else if (message.StartsWith("RecvUsers"))
            {
                 Newtonsoft.Json.Linq.JObject jobject = Newtonsoft.Json.Linq.JObject.Parse(data);

                 string[] users = jobject["users"].ToString().Split(',');
                 lstUsers.Clear();
                 foreach(string str in users)
                 {

                     lstUsers.Add(str);


                 }
                 if (UserAct != null)
                     UserAct(lstUsers);


            }

            

        }
        public  void SendMessage(string message)
        {

            message += "\n";
            try
            {
                System.Net.Sockets.NetworkStream ns;
                lock (client.GetStream())
                {
                    ns = client.GetStream();
                    byte[] bytesToSend = Encoding.UTF8.GetBytes(message);
                    ns.Write(bytesToSend, 0, bytesToSend.Length);
                    ns.Flush();

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

        }

    }
}
