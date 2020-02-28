using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Comm;
using Model;
namespace Auto4SErp
{
    public partial class frmDlgMessage : ifrmBase
    {

        private MyClient _MyClient;
        private Action<Msg> msgAct;
        private Action<List<string>> userAct;
        public frmDlgMessage()
        {
            InitializeComponent();
        }

        private void frmDlgMessage_Load(object sender, EventArgs e)
        {
            _MyClient = MyClient.getInstance();
            _MyClient.IsOpenWindow = true;
            msgAct = new Action<Msg>((r) => showMessage(r));
            userAct = new Action<List<string>>((r) => showUsers(r));


            _MyClient.MessageAct += msgAct;
            _MyClient.UserAct += userAct;
            loadMsg();
            loadUsers(_MyClient.getUsers());
            txtSend.Focus();

        }


        private void showUsers(List<string> lst)
        {

            this.Invoke(new Action(() =>

                 loadUsers(lst)

             ));
        }

        private void loadUsers(List<string> lst)
        {

            lstUsers.Items.Clear();
            lstUsers.Items.Add("在线用户" + "(" + lst.Count + ")");
            foreach (string str in lst)
            {

                lstUsers.Items.Add(str);

            }

        }

        private void loadMsg()
        {

            foreach (Msg msg in _MyClient.getMessages())
            {
                msg.Content = msg.Content.Replace("#", "\n  ");
                this.txtMsg.AppendText("\n" + msg.Sender + " " + msg.SendTime + "\n" + "  " + msg.Content);

            }

            txtMsg.ScrollToCaret();

        }


        private void showMessage(Msg msg)
        {

            this.Invoke(new Action(() =>


               appendToRich(msg)));

        }


        private void appendToRich(Msg msg)
        {

            msg.Content = msg.Content.Replace("#", "\n  ");
            this.txtMsg.AppendText("\n" + msg.Sender + " " + msg.SendTime + "\n" + "  " + msg.Content);
            txtMsg.ScrollToCaret();
        }



        private void btnSend_Click(object sender, EventArgs e)
        {

            if (txtSend.Text.Length > 0)
            {
                string txt = txtSend.Text;
                txt = txt.Replace('\n', '#');
                txt = txt.Replace("'", " ");
                _MyClient.SendMessage("sendMsg|{'content':'" + txt + "'}");
                txtSend.Clear();
            }
        }

        private void frmDlgMessage_FormClosed(object sender, FormClosedEventArgs e)
        {
            _MyClient.MessageAct -= msgAct;
            _MyClient.UserAct -= userAct;
            _MyClient.IsOpenWindow = false;
        }
    }
}
