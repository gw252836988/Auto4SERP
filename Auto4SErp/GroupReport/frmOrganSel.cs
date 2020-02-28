﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar;
using Model;
using Bll.Personnel;
using Comm;
namespace Auto4SErp.GroupReport
{
    public partial class frmOrganSel : ifrmBase
    {
        private OrganSelXml m_SelXml;
        private IOrgan mIOrgan;
        public frmOrganSel()
        {
            InitializeComponent();
            mIOrgan = Bll.BllFactory.GetOrganBll();
        }

        private void frmOrganSel_Load(object sender, EventArgs e)
        {
            m_SelXml = new OrganSelXml();
            List<string> lst = m_SelXml.ReadToList();


            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(GroupBox))
                {

                    QueryInGB((GroupBox)c, lst);
                }


            }

            rb_yxall.CheckedChanged += new EventHandler(OrgansAllSel);
            rb_gyall.CheckedChanged += new EventHandler(OrgansAllSel);
            rb_hmall.CheckedChanged += new EventHandler(OrgansAllSel);
            rb_rdall.CheckedChanged += new EventHandler(OrgansAllSel);
            rb_elseall.CheckedChanged += new EventHandler(OrgansAllSel);


            rb_yxno.CheckedChanged += new EventHandler(OrgansNoneSel);
            rb_gyno.CheckedChanged += new EventHandler(OrgansNoneSel);
            rb_hmno.CheckedChanged += new EventHandler(OrgansNoneSel);
            rb_rdno.CheckedChanged += new EventHandler(OrgansNoneSel);
            rb_elseno.CheckedChanged += new EventHandler(OrgansNoneSel);
            SetTButtonPng(toolStrip1);




        }

        private void OrgansAllSel(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            GroupBox parent = (GroupBox)rb.Parent;
            BatchChangeCheck(parent, true);

        }

        private void OrgansNoneSel(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            GroupBox parent = (GroupBox)rb.Parent;
            BatchChangeCheck(parent, false);

        }


        private void BatchChangeCheck(GroupBox parent, bool bl)
        {

            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(CheckBoxX))
                {
                    CheckBoxX ch = (CheckBoxX)c;
                    ch.Checked = bl;

                }

            }

        }

        private void QueryInGB(GroupBox gb, List<string> lst)
        {
            foreach (Control c in gb.Controls)
            {
                if (c.GetType() == typeof(CheckBoxX))
                {

                    foreach (string str in lst)
                    {
                        if (c.Name.Contains(str))
                        {
                            CheckBoxX ch = (CheckBoxX)c;
                            ch.Checked = true;
                        }



                    }

                }

            }


        }

        private void tbtAll_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(GroupBox))
                {

                    BatchChangeCheck((GroupBox)c, true);
                }


            }
        }

        private void tbtNo_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(GroupBox))
                {

                    BatchChangeCheck((GroupBox)c, false);
                }


            }
        }

        private void tbtChange_Click(object sender, EventArgs e)
        {
            List<string> lstAdd = new List<string>();
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(GroupBox))
                {
                    AddSelOrganToList((GroupBox)c, lstAdd);

                }


            }

            Comm.MainWindowState.getInstance().SelOrgan = mIOrgan.GetSelOrganByLst(lstAdd);
            // WinStatus.getInstance().SelOrgan = GetSelOrganByLst(lstAdd);
            m_SelXml.WriteByList(lstAdd);

            MessageBoxEx.Show("更改成功", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }



        private void AddSelOrganToList(GroupBox gb, List<string> lst)
        {
            foreach (Control c in gb.Controls)
            {
                if (c.GetType() == typeof(CheckBoxX))
                {
                    CheckBoxX ch = (CheckBoxX)c;
                    if (ch.Checked)
                    {
                        lst.Add(ch.Name.Substring(2));

                    }


                }

            }


        }




        private void cb352_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
