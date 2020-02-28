using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Comm;
using Bll.Sale;
using Bll;
using Model;

namespace Auto4SErp
{
    public partial class Form2 : Form
    {
        private ICarDoc mICarDoc;

        public Form2()
        {
            InitializeComponent();
            mICarDoc = BllFactory.GetCarDocBll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FileOperate fo = new FileOperate("");
            //string str = fo.readFromFile();

           // EntityText.test();


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // superGridControl1.PrimaryGrid.GroupByRow.Visible = false;

            //superGridControl1.PrimaryGrid.SetGroup(superGridControl1.PrimaryGrid.Columns["colr"]);
            // superGridControl1.PrimaryGrid.DataSource = mICarDoc.GetCarDetails();

            //superGridControl1.PrimaryGrid.SetGroup(superGridControl1.PrimaryGrid.Columns[0]);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
