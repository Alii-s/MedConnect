namespace MedConnect.Secretary
{
    partial class Reservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.return_button = new System.Windows.Forms.Button();
            this.logOut = new System.Windows.Forms.Button();
            this.closeApplication = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ReservT = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.save = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.PN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Daate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Conf = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservT)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.return_button);
            this.panel1.Controls.Add(this.logOut);
            this.panel1.Controls.Add(this.closeApplication);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 124);
            this.panel1.TabIndex = 9;
            // 
            // return_button
            // 
            this.return_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.return_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.return_button.FlatAppearance.BorderSize = 0;
            this.return_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_button.Image = global::MedConnect.Properties.Resources._return;
            this.return_button.Location = new System.Drawing.Point(11, 72);
            this.return_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(45, 37);
            this.return_button.TabIndex = 10;
            this.return_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.return_button.UseVisualStyleBackColor = false;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
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
            this.closeApplication.Location = new System.Drawing.Point(942, 0);
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
            this.pictureBox1.Image = global::MedConnect.Properties.Resources.booking;
            this.pictureBox1.Location = new System.Drawing.Point(94, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 100);
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
            this.label1.Size = new System.Drawing.Size(370, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservations";
            // 
            // ReservT
            // 
            this.ReservT.AllowUserToAddRows = false;
            this.ReservT.AllowUserToDeleteRows = false;
            this.ReservT.AllowUserToResizeColumns = false;
            this.ReservT.AllowUserToResizeRows = false;
            this.ReservT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReservT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PN,
            this.CL,
            this.Daate,
            this.T,
            this.Type,
            this.Conf,
            this.Id});
            this.ReservT.Location = new System.Drawing.Point(20, 213);
            this.ReservT.Name = "ReservT";
            this.ReservT.RowHeadersWidth = 62;
            this.ReservT.Size = new System.Drawing.Size(955, 261);
            this.ReservT.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.ReservT.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.ReservT.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.ReservT.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ReservT.StateCommon.DataCell.Border.Rounding = 10;
            this.ReservT.StateCommon.DataCell.Content.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservT.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ReservT.StateCommon.HeaderColumn.Border.Rounding = 10;
            this.ReservT.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservT.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.ReservT.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.ReservT.StateCommon.HeaderRow.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.ReservT.StateCommon.HeaderRow.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.ReservT.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ReservT.StateCommon.HeaderRow.Border.Rounding = 20;
            this.ReservT.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.ReservT.StateCommon.HeaderRow.Content.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.ReservT.StateCommon.HeaderRow.Content.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservT.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(460, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "All Reservations ordered by date";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(956, 176);
            this.save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(208, 52);
            this.save.StateCommon.Content.ShortText.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.TabIndex = 12;
            this.save.Values.Text = "Save";
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // PN
            // 
            this.PN.DataPropertyName = "Lname";
            this.PN.HeaderText = "Patient Name";
            this.PN.MinimumWidth = 8;
            this.PN.Name = "PN";
            this.PN.Width = 150;
            // 
            // CL
            // 
            this.CL.DataPropertyName = "City";
            this.CL.HeaderText = "Clinic location";
            this.CL.MinimumWidth = 8;
            this.CL.Name = "CL";
            this.CL.Width = 200;
            // 
            // Daate
            // 
            this.Daate.DataPropertyName = "Date";
            this.Daate.HeaderText = "Date";
            this.Daate.MinimumWidth = 8;
            this.Daate.Name = "Daate";
            this.Daate.Width = 150;
            // 
            // T
            // 
            this.T.DataPropertyName = "Time";
            this.T.HeaderText = "Time";
            this.T.MinimumWidth = 8;
            this.T.Name = "T";
            this.T.Width = 150;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 8;
            this.Type.Name = "Type";
            this.Type.Width = 150;
            // 
            // Conf
            // 
            this.Conf.DataPropertyName = "IsConfirmed";
            this.Conf.FalseValue = " false";
            this.Conf.HeaderText = "Confirmed";
            this.Conf.MinimumWidth = 8;
            this.Conf.Name = "Conf";
            this.Conf.TrueValue = " true";
            this.Conf.Width = 110;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "ReservationID";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "All Reservations ordered by date";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(717, 143);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(156, 42);
            this.save.StateCommon.Content.ShortText.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.TabIndex = 12;
            this.save.Values.Text = "Save";
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(987, 508);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ReservT);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Reservation";
            this.Text = "Reservation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Button closeApplication;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button return_button;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView ReservT;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton save;
        private System.Windows.Forms.DataGridViewTextBoxColumn PN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Daate;
        private System.Windows.Forms.DataGridViewTextBoxColumn T;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Conf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}