using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Xml;
using System.Net;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace AutoUpdate
{
	/// <summary>
	/// Form1 ��ժҪ˵����
	/// </summary>
	public class FrmUpdate : System.Windows.Forms.Form
    {
		private System.Windows.Forms.ColumnHeader chFileName;
		private System.Windows.Forms.ColumnHeader chVersion;
        private System.Windows.Forms.ColumnHeader chProgress;
        //private System.Windows.Forms.ListView lvUpdateList;
        private IContainer components;
        private BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private Button btnCancel;
        private Label lblUpdateTip;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBarX1;
        private Hashtable htUpdateFile;

		public FrmUpdate()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();

			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows ������������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.chFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProgress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblUpdateTip = new System.Windows.Forms.Label();
            this.progressBarX1 = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.SuspendLayout();
            // 
            // chFileName
            // 
            this.chFileName.Text = "�����";
            this.chFileName.Width = 123;
            // 
            // chVersion
            // 
            this.chVersion.Text = "�汾��";
            this.chVersion.Width = 98;
            // 
            // chProgress
            // 
            this.chProgress.Text = "����";
            this.chProgress.Width = 47;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(21, 47);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 24);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "ȡ��(&C)";
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblUpdateTip
            // 
            this.lblUpdateTip.AutoSize = true;
            this.lblUpdateTip.Location = new System.Drawing.Point(154, 47);
            this.lblUpdateTip.Name = "lblUpdateTip";
            this.lblUpdateTip.Size = new System.Drawing.Size(119, 12);
            this.lblUpdateTip.TabIndex = 9;
            this.lblUpdateTip.Text = "���������ļ�.......";
            // 
            // progressBarX1
            // 
            this.progressBarX1.Location = new System.Drawing.Point(12, 12);
            this.progressBarX1.Name = "progressBarX1";
            this.progressBarX1.Size = new System.Drawing.Size(279, 23);
            this.progressBarX1.TabIndex = 10;
            this.progressBarX1.Text = "progressBarX1";
            // 
            // FrmUpdate
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(303, 72);
            this.ControlBox = false;
            this.Controls.Add(this.progressBarX1);
            this.Controls.Add(this.lblUpdateTip);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUpdate";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "�������";
            this.Load += new System.EventHandler(this.FrmUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private string updateUrl = string.Empty;
		private string tempUpdatePath = string.Empty;
		private XmlFiles updaterXmlFiles = null;
		private int availableUpdate = 0;
		bool isRun = false;
		string mainAppExe = "";

		/// <summary>
		/// Ӧ�ó��������ڵ㡣
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new FrmUpdate());
		}

		private void FrmUpdate_Load(object sender, System.EventArgs e)
		{
            this.Hide();
			
            timer1.Enabled = true;
           // btnNext.Enabled = false;
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
			Application.ExitThread();
			Application.Exit();
		}

        //private void btnNext_Click(object sender, System.EventArgs e)
        //{
			
            
        //}

    

        private void  DownUpdateFile(BackgroundWorker worker, DoWorkEventArgs e)
		{
			//this.Cursor = Cursors.WaitCursor;
			mainAppExe = updaterXmlFiles.GetNodeValue("//EntryPoint");
			Process [] allProcess = Process.GetProcesses();
			foreach(Process p in allProcess)
			{
				
				if (p.ProcessName.ToLower() + ".exe" == mainAppExe.ToLower() )
				{
					for(int i=0;i<p.Threads.Count;i++)
						p.Threads[i].Dispose();
					p.Kill();
					isRun = true;
					//break;
				}
			}
		//	WebClient wcClient = new WebClient();
            string[] strlst;
			for(int i = 0;i < this.htUpdateFile.Count;i++)
			{
                strlst = (string [])htUpdateFile[i];
                string UpdateFile = strlst[0].Trim();
                string updateFileUrl = updateUrl + strlst[0].Trim();
				long fileLength = 0;
                
				WebRequest webReq = WebRequest.Create(updateFileUrl);
				WebResponse webRes = webReq.GetResponse();
				fileLength = webRes.ContentLength;

                //lbState.Text = "�������ظ����ļ�,���Ժ�...";
                //pbDownFile.Value = 0;
                //pbDownFile.Maximum = (int)fileLength;
                Thread.Sleep(1000); 
                worker.ReportProgress(0,0);
				try
				{	
					Stream srm = webRes.GetResponseStream();
					StreamReader srmReader = new StreamReader(srm);
					byte[] bufferbyte = new byte[fileLength];
					int allByte = (int)bufferbyte.Length;
					int startByte = 0;
					while(fileLength > 0)
					{
						Application.DoEvents();
						int downByte = srm.Read(bufferbyte,startByte,allByte);
						if (downByte == 0) {break;};
						startByte += downByte;
						allByte -= downByte;
						//pbDownFile.Value += downByte;
                    
						float part = (float)startByte / 1024;
						float total = (float)bufferbyte.Length / 1024;
						int percent =Convert.ToInt32((part/total)*100);
                        
                        worker.ReportProgress(percent,(i+1));
						//this.lvUpdateList.Items[i].SubItems[2].Text = percent.ToString() + "%";
                        
					}
					
					string tempPath = tempUpdatePath + UpdateFile;
					CreateDirtory(tempPath);
					FileStream fs = new FileStream(tempPath,FileMode.OpenOrCreate,FileAccess.Write);
					fs.Write(bufferbyte,0,bufferbyte.Length);
					srm.Close();
					srmReader.Close();
					fs.Close();
	
					
				}
				catch(WebException ex)
				{
					MessageBox.Show("�����ļ�����ʧ�ܣ�"+ex.Message.ToString(),"����",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
			//InvalidateControl();
		//	this.Cursor = Cursors.Default;
		}



        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //if (e.ProgressPercentage == 0)
            //{
            //    lbState.Text = "�������ظ����ļ�,���Ժ�...";
            //    pbDownFile.Value = 0;

            //}
            //else
            //{ 
            if (e.UserState.ToString().Substring(0, 1) != " ")
            {
               // pbDownFile.Value = e.ProgressPercentage;
                progressBarX1.Value = e.ProgressPercentage;
              //  lblUpdateTip.Text = "���ڸ��µ�" + e.UserState.ToString() + "���ļ�";
                lblUpdateTip.Text = string.Format("���ڸ��µ�{0}���ļ�,��{1}��", e.UserState.ToString(), htUpdateFile.Count);
            }
            //else
            //{
            //    if (e.ProgressPercentage == 0)
            //        lblUpdateTip.Text = e.UserState.ToString();
            //    else
            //        label1.Text = e.UserState.ToString();

            //}
                  //this.lvUpdateList.Items[(int)e.UserState].SubItems[2].Text = e.ProgressPercentage.ToString() + "%";
            //}
        }

		//����Ŀ¼
		private void CreateDirtory(string path)
		{
			if(!File.Exists(path))
			{
				string [] dirArray = path.Split('\\'); 
				string temp = string.Empty;
				for(int i = 0;i<dirArray.Length - 1;i++)
				{
					temp += dirArray[i].Trim() + "\\";
					if(!Directory.Exists(temp))
						Directory.CreateDirectory(temp);
				}
			}
		}

		//�����ļ�;		public void CopyFile(string sourcePath,string objPath)		{//			char[] split = @"\".ToCharArray();			if(!Directory.Exists(objPath))			{				Directory.CreateDirectory(objPath);			}			string[] files = Directory.GetFiles(sourcePath);			for(int i=0;i<files.Length;i++)			{				string[] childfile = files[i].Split('\\');				File.Copy(files[i],objPath + @"\" + childfile[childfile.Length-1],true);			}			string[] dirs = Directory.GetDirectories(sourcePath);			for(int i=0;i<dirs.Length;i++)			{				string[] childdir = dirs[i].Split('\\');				CopyFile(dirs[i],objPath + @"\" + childdir[childdir.Length-1]);			}		} 

		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
		
		}
		//�����ɸ��Ƹ����ļ���Ӧ�ó���Ŀ¼
		private void btnFinish_Click(object sender, System.EventArgs e)
		{
			
		}
		
        private void  StartProgram()
        {

            
            this.Dispose();
            try
            {
                CopyFile(tempUpdatePath, Directory.GetCurrentDirectory());
                System.IO.Directory.Delete(tempUpdatePath, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            isRun = true;
            //string str = Directory.GetCurrentDirectory();
            //if (true == this.isRun) Process.Start(mainAppExe, "1");
            mainAppExe = updaterXmlFiles.GetNodeValue("//EntryPoint");
            if (checkMainExe(mainAppExe))
                Process.Start(mainAppExe, "ok");
            this.Close();
            //else
            //    MessageBox.Show("�����򲻴���,����ϵIT��Ա");
          

        }
		//���»��ƴ��岿�ֿؼ�����
		private void InvalidateControl()
		{
            //panel2.Location = panel1.Location;
            //panel2.Size = panel1.Size;
            //panel1.Visible = false;
            //panel2.Visible = true;

         //  btnNext.Visible = false;
            //btnCancel.Visible = false;
           // Location = btnCancel.Location;
            //btnFinish.Visible = true;
		}
		//�ж���Ӧ�ó����Ƿ���������
		private bool IsMainAppRun()
		{
			string mainAppExe = updaterXmlFiles.GetNodeValue("//EntryPoint");
			bool isRun = false;
			Process [] allProcess = Process.GetProcesses();
			foreach(Process p in allProcess)
			{
				
				if (p.ProcessName.ToLower() + ".exe" == mainAppExe.ToLower() )
				{
					isRun = true;
					//break;
				}
			}
			return isRun;
		}

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
           // lbState.Text = "�������ظ����ļ�,���Ժ�...";
            BackgroundWorker worker = sender as BackgroundWorker;
            CheckFiles();
            if (availableUpdate > 0)
            {
                //Thread threadDown=new Thread(new ThreadStart(DownUpdateFile));
                //threadDown.IsBackground = true;
                //threadDown.Start();
                //btnNext.Enabled = false;
                //backgroundWorker1.RunWorkerAsync();

                this.Opacity = 1;
                DownUpdateFile(worker, e);
                
            }
            //else
            //{
            //    //MessageBox.Show("û�п��õĸ���!","�Զ�����",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //    mainAppExe = updaterXmlFiles.GetNodeValue("//EntryPoint");


            //    if (checkMainExe(mainAppExe))
            //        Process.Start(mainAppExe, "ok");
            //    //else
            //    //    MessageBox.Show("�����򲻴���,����ϵIT��Ա");
                
            //}
            
        }

        private bool checkMainExe(string mainE)
        {

            string str = Directory.GetCurrentDirectory() + "\\" + mainE;
            if (File.Exists(str))
                return true;
            else
                return false;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //InvalidateControl();
           // btnNext.Enabled = true;
            StartProgram();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //panel2.Visible = false;
         //   btnFinish.Visible = false;
            backgroundWorker1.RunWorkerAsync();
            timer1.Enabled = false;
        }

        private void CheckFiles()
        {
            string localXmlFile = Application.StartupPath + "\\UpdateList.xml";
            string serverXmlFile = string.Empty;

            backgroundWorker1.ReportProgress(0," ���ڼ������ļ�");
            try
            {
                //�ӱ��ض�ȡ���������ļ���Ϣ
                updaterXmlFiles = new XmlFiles(localXmlFile);
            }
            catch
            {
                MessageBox.Show("�����ļ�����!", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            //��ȡ��������ַ
        
            updateUrl = updaterXmlFiles.GetNodeValue("//Url");

            string ver = updaterXmlFiles.GetNodeValue("//Version");
            backgroundWorker1.ReportProgress(1, " ��ǰ�汾Ϊ" + ver);

            AppUpdater appUpdater = new AppUpdater();
            appUpdater.UpdaterUrl = updateUrl + "/UpdateList.xml";

            //�����������,���ظ��������ļ�
            try
            {
                tempUpdatePath = Environment.GetEnvironmentVariable("Temp") + "\\" + "_" + updaterXmlFiles.FindNode("//Application").Attributes["applicationId"].Value + "_" + "y" + "_" + "x" + "_" + "m" + "_" + "\\";
                appUpdater.DownAutoUpdateFile(tempUpdatePath);
            }
            catch
            {
                MessageBox.Show("�����������ʧ��,������ʱ!", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
                return;

            }

            //��ȡ�����ļ��б�
            htUpdateFile = new Hashtable();

            serverXmlFile = tempUpdatePath + "\\UpdateList.xml";
            if (!File.Exists(serverXmlFile))
            {
                return;
            }

            availableUpdate = appUpdater.CheckForUpdate(serverXmlFile, localXmlFile, out htUpdateFile);
            if (availableUpdate > 0)
            {
                for (int i = 0; i < htUpdateFile.Count; i++)
                {
                    string[] fileArray = (string[])htUpdateFile[i];
                    //lvUpdateList.Items.Add(new ListViewItem(fileArray));
                }
            }
            //			else
            //				btnNext.Enabled = false;
           
            //btnNext.Enabled =true ;
         //   BeginUpdate();



        }
	}

     
}
