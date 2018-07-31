namespace UtilisationPlannerAddIn
{
    partial class FileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbAssignments = new System.Windows.Forms.TextBox();
            this.btnLoadAssignments = new System.Windows.Forms.Button();
            this.btnLoadHolidays = new System.Windows.Forms.Button();
            this.tbHolidays = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ofdAssignments = new System.Windows.Forms.OpenFileDialog();
            this.ofdHolidays = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLoadHolidays);
            this.panel1.Controls.Add(this.tbHolidays);
            this.panel1.Controls.Add(this.btnLoadAssignments);
            this.panel1.Controls.Add(this.tbAssignments);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 173);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 113);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(742, 60);
            this.panel2.TabIndex = 1;
            // 
            // tbAssignments
            // 
            this.tbAssignments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAssignments.Enabled = false;
            this.tbAssignments.Location = new System.Drawing.Point(15, 16);
            this.tbAssignments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAssignments.Name = "tbAssignments";
            this.tbAssignments.Size = new System.Drawing.Size(515, 27);
            this.tbAssignments.TabIndex = 0;
            // 
            // btnLoadAssignments
            // 
            this.btnLoadAssignments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadAssignments.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadAssignments.Image")));
            this.btnLoadAssignments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadAssignments.Location = new System.Drawing.Point(536, 16);
            this.btnLoadAssignments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoadAssignments.Name = "btnLoadAssignments";
            this.btnLoadAssignments.Size = new System.Drawing.Size(197, 29);
            this.btnLoadAssignments.TabIndex = 1;
            this.btnLoadAssignments.Text = "Load Assignments";
            this.btnLoadAssignments.UseVisualStyleBackColor = true;
            this.btnLoadAssignments.Click += new System.EventHandler(this.btnLoadAssignments_Click);
            // 
            // btnLoadHolidays
            // 
            this.btnLoadHolidays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadHolidays.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadHolidays.Image")));
            this.btnLoadHolidays.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadHolidays.Location = new System.Drawing.Point(536, 64);
            this.btnLoadHolidays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoadHolidays.Name = "btnLoadHolidays";
            this.btnLoadHolidays.Size = new System.Drawing.Size(197, 29);
            this.btnLoadHolidays.TabIndex = 3;
            this.btnLoadHolidays.Text = "Load Holidays";
            this.btnLoadHolidays.UseVisualStyleBackColor = true;
            this.btnLoadHolidays.Click += new System.EventHandler(this.btnLoadHolidays_Click);
            // 
            // tbHolidays
            // 
            this.tbHolidays.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHolidays.Enabled = false;
            this.tbHolidays.Location = new System.Drawing.Point(15, 64);
            this.tbHolidays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbHolidays.Name = "tbHolidays";
            this.tbHolidays.Size = new System.Drawing.Size(515, 27);
            this.tbHolidays.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(629, 10);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(99, 38);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(524, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 38);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // ofdAssignments
            // 
            this.ofdAssignments.Filter = "\"CSV Files|*.csv\"";
            // 
            // ofdHolidays
            // 
            this.ofdHolidays.FileName = "openFileDialog2";
            this.ofdHolidays.Filter = "\"CSV Files|*.csv\"";
            // 
            // FileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 173);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FileForm";
            this.Text = "Pick Data Files";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLoadHolidays;
        private System.Windows.Forms.TextBox tbHolidays;
        private System.Windows.Forms.Button btnLoadAssignments;
        private System.Windows.Forms.TextBox tbAssignments;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.OpenFileDialog ofdAssignments;
        private System.Windows.Forms.OpenFileDialog ofdHolidays;
    }
}