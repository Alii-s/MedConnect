namespace MedConnect.Patient
{
    partial class Bills
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bills));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.closeApplication = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logOut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.diagnosisBills = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.DeliveryBills = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisBills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryBills)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.pictureBox1);
            this.kryptonPanel1.Controls.Add(this.button1);
            this.kryptonPanel1.Controls.Add(this.closeApplication);
            this.kryptonPanel1.Controls.Add(this.label1);
            this.kryptonPanel1.Controls.Add(this.logOut);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1504, 191);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.kryptonPanel1.TabIndex = 39;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.pictureBox1.Image = global::MedConnect.Properties.Resources.bill;
            this.pictureBox1.Location = new System.Drawing.Point(108, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::MedConnect.Properties.Resources._return;
            this.button1.Location = new System.Drawing.Point(16, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 57);
            this.button1.TabIndex = 8;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // closeApplication
            // 
            this.closeApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.closeApplication.FlatAppearance.BorderSize = 0;
            this.closeApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeApplication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.closeApplication.Image = ((System.Drawing.Image)(resources.GetObject("closeApplication.Image")));
            this.closeApplication.Location = new System.Drawing.Point(1420, 17);
            this.closeApplication.Name = "closeApplication";
            this.closeApplication.Size = new System.Drawing.Size(68, 57);
            this.closeApplication.TabIndex = 6;
            this.closeApplication.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.closeApplication.UseVisualStyleBackColor = false;
            this.closeApplication.Click += new System.EventHandler(this.closeApplication_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(73)))));
            this.label1.Location = new System.Drawing.Point(327, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(807, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Bills and payments";
            // 
            // logOut
            // 
            this.logOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.logOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOut.FlatAppearance.BorderSize = 0;
            this.logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut.Image = ((System.Drawing.Image)(resources.GetObject("logOut.Image")));
            this.logOut.Location = new System.Drawing.Point(16, 17);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(68, 57);
            this.logOut.TabIndex = 7;
            this.logOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.logOut.UseVisualStyleBackColor = false;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(73)))));
            this.label2.Location = new System.Drawing.Point(512, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(452, 35);
            this.label2.TabIndex = 49;
            this.label2.Text = "Diagnosis session bills";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(73)))));
            this.label3.Location = new System.Drawing.Point(602, 595);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 35);
            this.label3.TabIndex = 50;
            this.label3.Text = "Delivery bills";
            // 
            // diagnosisBills
            // 
            this.diagnosisBills.AllowUserToAddRows = false;
            this.diagnosisBills.AllowUserToDeleteRows = false;
            this.diagnosisBills.AllowUserToResizeColumns = false;
            this.diagnosisBills.AllowUserToResizeRows = false;
            this.diagnosisBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.diagnosisBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.diagnosisBills.Location = new System.Drawing.Point(108, 278);
            this.diagnosisBills.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.diagnosisBills.Name = "diagnosisBills";
            this.diagnosisBills.ReadOnly = true;
            this.diagnosisBills.RowHeadersWidth = 62;
            this.diagnosisBills.Size = new System.Drawing.Size(1278, 292);
            this.diagnosisBills.TabIndex = 51;
            // 
            // DeliveryBills
            // 
            this.DeliveryBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DeliveryBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeliveryBills.Location = new System.Drawing.Point(108, 662);
            this.DeliveryBills.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeliveryBills.Name = "DeliveryBills";
            this.DeliveryBills.ReadOnly = true;
            this.DeliveryBills.RowHeadersWidth = 62;
            this.DeliveryBills.Size = new System.Drawing.Size(1278, 202);
            this.DeliveryBills.TabIndex = 88;
            // 
            // Bills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1504, 902);
            this.Controls.Add(this.DeliveryBills);
            this.Controls.Add(this.diagnosisBills);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Bills";
            this.Text = "Bills";
            this.Load += new System.EventHandler(this.Bills_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisBills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryBills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button closeApplication;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView diagnosisBills;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView DeliveryBills;
    }
}