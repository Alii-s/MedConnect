namespace MedConnect.Admin
{
    partial class AdminMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.logOut = new System.Windows.Forms.Button();
            this.closeApplication = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updatInfo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Statistics = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Switch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.AddCl = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.logOut);
            this.panel1.Controls.Add(this.closeApplication);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 124);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(73)))));
            this.label2.Location = new System.Drawing.Point(245, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Change Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // logOut
            // 
            this.logOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOut.FlatAppearance.BorderSize = 0;
            this.logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut.Image = ((System.Drawing.Image)(resources.GetObject("logOut.Image")));
            this.logOut.Location = new System.Drawing.Point(11, 11);
            this.logOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(45, 37);
            this.logOut.TabIndex = 8;
            this.logOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // closeApplication
            // 
            this.closeApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeApplication.FlatAppearance.BorderSize = 0;
            this.closeApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeApplication.Image = ((System.Drawing.Image)(resources.GetObject("closeApplication.Image")));
            this.closeApplication.Location = new System.Drawing.Point(947, 11);
            this.closeApplication.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeApplication.Name = "closeApplication";
            this.closeApplication.Size = new System.Drawing.Size(45, 37);
            this.closeApplication.TabIndex = 6;
            this.closeApplication.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.closeApplication.UseVisualStyleBackColor = true;
            this.closeApplication.Click += new System.EventHandler(this.closeApplication_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MedConnect.Properties.Resources.setting__1_;
            this.pictureBox1.Location = new System.Drawing.Point(94, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(73)))));
            this.label1.Location = new System.Drawing.Point(240, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello";
            // 
            // updatInfo
            // 
            this.updatInfo.Location = new System.Drawing.Point(32, 150);
            this.updatInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updatInfo.Name = "updatInfo";
            this.updatInfo.Size = new System.Drawing.Size(261, 202);
            this.updatInfo.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.updatInfo.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.updatInfo.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.updatInfo.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.None;
            this.updatInfo.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatInfo.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(73)))));
            this.updatInfo.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(73)))));
            this.updatInfo.StateCommon.Content.ShortText.Font = new System.Drawing.Font("OCR A Extended", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatInfo.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.updatInfo.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.updatInfo.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.updatInfo.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.updatInfo.StateTracking.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.updatInfo.StateTracking.Back.Color2 = System.Drawing.Color.AliceBlue;
            this.updatInfo.TabIndex = 8;
            this.updatInfo.Tag = "";
            this.updatInfo.Values.Image = global::MedConnect.Properties.Resources.add__1_;
            this.updatInfo.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.updatInfo.Values.Text = "Add User";
            this.updatInfo.Click += new System.EventHandler(this.updatInfo_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(669, 150);
            this.kryptonButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(261, 202);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.kryptonButton1.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.None;
            this.kryptonButton1.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(73)))));
            this.kryptonButton1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(73)))));
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("OCR A Extended", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonButton1.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kryptonButton1.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.kryptonButton1.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.kryptonButton1.StateTracking.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.kryptonButton1.StateTracking.Back.Color2 = System.Drawing.Color.AliceBlue;
            this.kryptonButton1.TabIndex = 9;
            this.kryptonButton1.Tag = "";
            this.kryptonButton1.Values.Image = global::MedConnect.Properties.Resources.remove_user;
            this.kryptonButton1.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.kryptonButton1.Values.Text = "Remove User";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // Statistics
            // 
            this.Statistics.Location = new System.Drawing.Point(607, 375);
            this.Statistics.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Statistics.Name = "Statistics";
            this.Statistics.Size = new System.Drawing.Size(261, 202);
            this.Statistics.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.Statistics.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.Statistics.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.Statistics.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.None;
            this.Statistics.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statistics.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(73)))));
            this.Statistics.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(73)))));
            this.Statistics.StateCommon.Content.ShortText.Font = new System.Drawing.Font("OCR A Extended", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statistics.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.Statistics.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.Statistics.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.Statistics.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.Statistics.StateTracking.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.Statistics.StateTracking.Back.Color2 = System.Drawing.Color.AliceBlue;
            this.Statistics.TabIndex = 10;
            this.Statistics.Tag = "";
            this.Statistics.Values.Image = global::MedConnect.Properties.Resources.bar_chart;
            this.Statistics.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.Statistics.Values.Text = "Clinic Statistics";
            this.Statistics.Click += new System.EventHandler(this.Statistics_Click);
            // 
            // Switch
            // 
            this.Switch.Location = new System.Drawing.Point(94, 366);
            this.Switch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Switch.Name = "Switch";
            this.Switch.Size = new System.Drawing.Size(375, 202);
            this.Switch.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.Switch.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.Switch.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.Switch.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.None;
            this.Switch.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Switch.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(73)))));
            this.Switch.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(73)))));
            this.Switch.StateCommon.Content.ShortText.Font = new System.Drawing.Font("OCR A Extended", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Switch.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.Switch.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.Switch.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.Switch.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.Switch.StateTracking.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.Switch.StateTracking.Back.Color2 = System.Drawing.Color.AliceBlue;
            this.Switch.TabIndex = 11;
            this.Switch.Tag = "";
            this.Switch.Values.Image = global::MedConnect.Properties.Resources.change;
            this.Switch.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.Switch.Values.Text = "Switch to Doctor Interface";
            this.Switch.Click += new System.EventHandler(this.Switch_Click);
            // 
            // AddCl
            // 
            this.AddCl.Location = new System.Drawing.Point(352, 150);
            this.AddCl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddCl.Name = "AddCl";
            this.AddCl.Size = new System.Drawing.Size(261, 202);
            this.AddCl.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.AddCl.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.AddCl.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.AddCl.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.None;
            this.AddCl.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCl.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(73)))));
            this.AddCl.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(73)))));
            this.AddCl.StateCommon.Content.ShortText.Font = new System.Drawing.Font("OCR A Extended", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCl.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.AddCl.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.AddCl.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.AddCl.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.AddCl.StateTracking.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.AddCl.StateTracking.Back.Color2 = System.Drawing.Color.AliceBlue;
            this.AddCl.TabIndex = 12;
            this.AddCl.Tag = "";
            this.AddCl.Values.Image = global::MedConnect.Properties.Resources.location1;
            this.AddCl.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.AddCl.Values.Text = "Add Clinic";
            this.AddCl.Click += new System.EventHandler(this.AddCl_Click);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1003, 586);
            this.Controls.Add(this.AddCl);
            this.Controls.Add(this.Switch);
            this.Controls.Add(this.Statistics);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.updatInfo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMainForm";
            this.Load += new System.EventHandler(this.AdminMainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Button closeApplication;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton updatInfo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Statistics;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Switch;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton AddCl;
    }
}