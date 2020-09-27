namespace WindowsFormsProcessControl
{
    partial class FormProcessControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.bgWorkerProcessControl = new System.ComponentModel.BackgroundWorker();
            this.CheckList = new System.Windows.Forms.CheckedListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCloseApplication = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(80, 52);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(279, 64);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start process";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // CheckList
            // 
            this.CheckList.FormattingEnabled = true;
            this.CheckList.Location = new System.Drawing.Point(162, 176);
            this.CheckList.Name = "CheckList";
            this.CheckList.Size = new System.Drawing.Size(482, 154);
            this.CheckList.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(445, 52);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(279, 64);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel process";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCloseApplication
            // 
            this.btnCloseApplication.Location = new System.Drawing.Point(608, 374);
            this.btnCloseApplication.Name = "btnCloseApplication";
            this.btnCloseApplication.Size = new System.Drawing.Size(180, 64);
            this.btnCloseApplication.TabIndex = 3;
            this.btnCloseApplication.Text = "Close application";
            this.btnCloseApplication.UseVisualStyleBackColor = true;
            this.btnCloseApplication.Click += new System.EventHandler(this.btnCloseApplication_Click);
            // 
            // FormProcessControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCloseApplication);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.CheckList);
            this.Controls.Add(this.btnStart);
            this.Name = "FormProcessControl";
            this.Text = "Window Form Process Control";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.ComponentModel.BackgroundWorker bgWorkerProcessControl;
        private System.Windows.Forms.CheckedListBox CheckList;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCloseApplication;
    }
}

