﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace Auto4SErp
{
    public partial class frmDlgVipPwd : ifrmBase
    {
        public frmDlgVipPwd()
        {
            InitializeComponent();
        }

        private void frmDlgVipPwd_Load(object sender, EventArgs e)
        {

        }

        private string GetPwd(string password)
        {
            byte[] message;
            message = Encoding.Default.GetBytes(password);
            MD5CryptoServiceProvider md = new MD5CryptoServiceProvider();
            md.ComputeHash(message);
            return (Convert.ToBase64String(md.Hash));


        }

        private void tbnOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassWord.Text))
            {
                if (m_del != null)
                {
                    m_del(GetPwd(txtPassWord.Text));
                    this.Close();
                }
            }
        }
    }
}
