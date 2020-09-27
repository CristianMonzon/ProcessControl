using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessProcessControl;

namespace WindowsFormsProcessControl
{
    public partial class FormProcessControl : Form
    {
        #region Constructor

        public FormProcessControl()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                ClearControl();
                InitWorker();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.bgWorkerProcessControl.CancelAsync();
            ResetControl();
            this.CheckList.Items.Clear();
        }

        private void btnCloseApplication_Click(object sender, EventArgs e)
        {            
            if (MessageBox.Show("Are you sure you want to quit?",this.Text,MessageBoxButtons.OKCancel)==DialogResult.OK)
                Application.Exit();
        }

        #endregion

        #region Methods

        private void InitWorker()
        {
            if (bgWorkerProcessControl != null)
            {
                bgWorkerProcessControl.Dispose();
            }

            bgWorkerProcessControl = new BackgroundWorker()
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };

            bgWorkerProcessControl.DoWork += BgWorkerProcessControl_DoWork;
            bgWorkerProcessControl.RunWorkerCompleted += BgWorkerProcessControl_RunWorkerCompleted;
            bgWorkerProcessControl.ProgressChanged += BgWorkerProcessControl_ProgressChanged;
            

            bgWorkerProcessControl.RunWorkerAsync();

        }


        private void Bt_ReportMessage(string message)
        {
            bgWorkerProcessControl.ReportProgress(0, message);
        }

        private void ClearControl()
        {
            this.btnStart.Enabled = false;
            this.btnCancel.Enabled = true;
            this.CheckList.Items.Clear();
        }

        private void ResetControl()
        {
            this.btnStart.Enabled = true;
            this.btnCancel.Enabled = false;
        }


        #endregion

        #region BgWorkerProcessControl

        private void BgWorkerProcessControl_DoWork(object sender, DoWorkEventArgs e)
        {
            BusinessTask bt = new BusinessTask();
            bt.ReportMessage += Bt_ReportMessage;
            bt.Run();

        }

        private void BgWorkerProcessControl_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ResetControl();
        }

        private void BgWorkerProcessControl_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (bgWorkerProcessControl.CancellationPending == false)
                this.CheckList.Items.Add(e.UserState.ToString(), CheckState.Checked);
        }

        #endregion

    }
}
