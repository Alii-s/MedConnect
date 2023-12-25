namespace MedConnect.Secretary
{
    partial class MUbill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MUbill));
            this.return_button = new System.Windows.Forms.Button();
            this.log_Out = new System.Windows.Forms.Button();
            this.closeApplication = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.plabel = new System.Windows.Forms.Label();
            this.Price = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.IsPaid = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MofP = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.Up = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.create_button = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label5 = new System.Windows.Forms.Label();
            this.Daate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.CL = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PN = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DN = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Ubill = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Cbill = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MofP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DN)).BeginInit();
            this.SuspendLayout();
            // 
            // return_button
            // 
            this.return_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.return_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.return_button.FlatAppearance.BorderSize = 0;
            this.return_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_button.Image = global::MedConnect.Properties.Resources._return;
            this.return_button.Location = new System.Drawing.Point(12, 82);
            this.return_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(60, 46);
            this.return_button.TabIndex = 9;
            this.return_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.return_button.UseVisualStyleBackColor = false;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // log_Out
            // 
            this.log_Out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.log_Out.Cursor = System.Windows.Forms.Cursors.Hand;
            this.log_Out.FlatAppearance.BorderSize = 0;
            this.log_Out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_Out.Image = ((System.Drawing.Image)(resources.GetObject("log_Out.Image")));
            this.log_Out.Location = new System.Drawing.Point(12, 11);
            this.log_Out.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.log_Out.Name = "log_Out";
            this.log_Out.Size = new System.Drawing.Size(60, 46);
            this.log_Out.TabIndex = 78;
            this.log_Out.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.log_Out.UseVisualStyleBackColor = false;
            this.log_Out.Click += new System.EventHandler(this.log_Out_Click);
            // 
            // closeApplication
            // 
            this.closeApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.closeApplication.FlatAppearance.BorderSize = 0;
            this.closeApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeApplication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.closeApplication.Image = ((System.Drawing.Image)(resources.GetObject("closeApplication.Image")));
            this.closeApplication.Location = new System.Drawing.Point(1220, 11);
            this.closeApplication.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeApplication.Name = "closeApplication";
            this.closeApplication.Size = new System.Drawing.Size(60, 46);
            this.closeApplication.TabIndex = 79;
            this.closeApplication.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.closeApplication.UseVisualStyleBackColor = false;
            this.closeApplication.Click += new System.EventHandler(this.closeApplication_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.plabel);
            this.panel1.Controls.Add(this.Price);
            this.panel1.Controls.Add(this.IsPaid);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.MofP);
            this.panel1.Controls.Add(this.Up);
            this.panel1.Controls.Add(this.create_button);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Daate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CL);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.PN);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.DN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(364, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 602);
            this.panel1.TabIndex = 83;
            this.panel1.Visible = false;
            // 
            // plabel
            // 
            this.plabel.AutoSize = true;
            this.plabel.Font = new System.Drawing.Font("OCR A Extended", 9.75F);
            this.plabel.ForeColor = System.Drawing.Color.IndianRed;
            this.plabel.Location = new System.Drawing.Point(448, 416);
            this.plabel.Name = "plabel";
            this.plabel.Size = new System.Drawing.Size(128, 18);
            this.plabel.TabIndex = 98;
            this.plabel.Text = "Numbers Only";
            this.plabel.Visible = false;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(451, 373);
            this.Price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(269, 40);
            this.Price.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Price.StateCommon.Border.Rounding = 20;
            this.Price.StateCommon.Content.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.TabIndex = 87;
            this.Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Price_KeyPress);
            // 
            // IsPaid
            // 
            this.IsPaid.AutoSize = true;
            this.IsPaid.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsPaid.Location = new System.Drawing.Point(309, 458);
            this.IsPaid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IsPaid.Name = "IsPaid";
            this.IsPaid.Size = new System.Drawing.Size(116, 27);
            this.IsPaid.TabIndex = 86;
            this.IsPaid.Text = "Is Paid";
            this.IsPaid.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(73)))));
            this.label6.Location = new System.Drawing.Point(67, 314);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 25);
            this.label6.TabIndex = 85;
            this.label6.Text = "Method of Payment";
            // 
            // MofP
            // 
            this.MofP.AutoCompleteCustomSource.AddRange(new string[] {
            "Cash",
            "Credit",
            "Elec. Wallet"});
            this.MofP.DropDownWidth = 185;
            this.MofP.Items.AddRange(new object[] {
            "Cash",
            "Credit",
            "Elec. Wallet"});
            this.MofP.Location = new System.Drawing.Point(473, 297);
            this.MofP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MofP.Name = "MofP";
            this.MofP.Size = new System.Drawing.Size(247, 38);
            this.MofP.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MofP.StateCommon.ComboBox.Border.Rounding = 20;
            this.MofP.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MofP.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MofP.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MofP.TabIndex = 84;
            // 
            // Up
            // 
            this.Up.Location = new System.Drawing.Point(451, 526);
            this.Up.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(197, 71);
            this.Up.StateCommon.Border.ColorAngle = 10F;
            this.Up.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Up.StateCommon.Border.Rounding = 50;
            this.Up.StateCommon.Content.ShortText.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Up.TabIndex = 83;
            this.Up.Values.Text = "Update";
            this.Up.Visible = false;
            this.Up.Click += new System.EventHandler(this.Up_Click);
            // 
            // create_button
            // 
            this.create_button.Location = new System.Drawing.Point(451, 526);
            this.create_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(197, 71);
            this.create_button.StateCommon.Border.ColorAngle = 10F;
            this.create_button.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.create_button.StateCommon.Border.Rounding = 50;
            this.create_button.StateCommon.Content.Image.ImageColorTo = System.Drawing.Color.White;
            this.create_button.StateCommon.Content.ShortText.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_button.TabIndex = 82;
            this.create_button.Values.Image = global::MedConnect.Properties.Resources.add1;
            this.create_button.Values.ImageStates.ImageCheckedNormal = null;
            this.create_button.Values.ImageStates.ImageCheckedPressed = null;
            this.create_button.Values.ImageStates.ImageCheckedTracking = null;
            this.create_button.Values.ImageStates.ImageNormal = global::MedConnect.Properties.Resources.add1;
            this.create_button.Values.Text = "Create ";
            this.create_button.Visible = false;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(73)))));
            this.label5.Location = new System.Drawing.Point(67, 239);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date";
            // 
            // Daate
            // 
            this.Daate.Location = new System.Drawing.Point(347, 222);
            this.Daate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Daate.Name = "Daate";
            this.Daate.Size = new System.Drawing.Size(373, 40);
            this.Daate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Daate.StateCommon.Border.Rounding = 20;
            this.Daate.StateCommon.Content.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Daate.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(73)))));
            this.label4.Location = new System.Drawing.Point(67, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Clinic Location";
            // 
            // CL
            // 
            this.CL.DropDownWidth = 185;
            this.CL.Items.AddRange(new object[] {
            "Follow-Up",
            "Check-Up"});
            this.CL.Location = new System.Drawing.Point(473, 151);
            this.CL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CL.Name = "CL";
            this.CL.Size = new System.Drawing.Size(247, 38);
            this.CL.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.CL.StateCommon.ComboBox.Border.Rounding = 20;
            this.CL.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CL.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CL.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CL.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(73)))));
            this.label3.Location = new System.Drawing.Point(67, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Patient Name";
            // 
            // PN
            // 
            this.PN.DropDownWidth = 185;
            this.PN.Items.AddRange(new object[] {
            "Follow-Up",
            "Check-Up"});
            this.PN.Location = new System.Drawing.Point(473, 89);
            this.PN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PN.Name = "PN";
            this.PN.Size = new System.Drawing.Size(247, 38);
            this.PN.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PN.StateCommon.ComboBox.Border.Rounding = 20;
            this.PN.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PN.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PN.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PN.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(73)))));
            this.label2.Location = new System.Drawing.Point(67, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doctor Name";
            // 
            // DN
            // 
            this.DN.DropDownWidth = 185;
            this.DN.Items.AddRange(new object[] {
            "Follow-Up",
            "Check-Up"});
            this.DN.Location = new System.Drawing.Point(473, 22);
            this.DN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DN.Name = "DN";
            this.DN.Size = new System.Drawing.Size(247, 38);
            this.DN.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DN.StateCommon.ComboBox.Border.Rounding = 20;
            this.DN.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DN.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DN.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DN.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(73)))));
            this.label1.Location = new System.Drawing.Point(137, 373);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Price";
            // 
            // Ubill
            // 
            this.Ubill.Location = new System.Drawing.Point(35, 183);
            this.Ubill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ubill.Name = "Ubill";
            this.Ubill.Size = new System.Drawing.Size(321, 101);
            this.Ubill.StateCommon.Border.ColorAngle = 10F;
            this.Ubill.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Ubill.StateCommon.Border.Rounding = 50;
            this.Ubill.StateCommon.Content.ShortText.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ubill.TabIndex = 82;
            this.Ubill.Values.Text = "Update a bill";
            this.Ubill.Click += new System.EventHandler(this.Ubill_Click);
            // 
            // Cbill
            // 
            this.Cbill.Location = new System.Drawing.Point(35, 302);
            this.Cbill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cbill.Name = "Cbill";
            this.Cbill.Size = new System.Drawing.Size(321, 97);
            this.Cbill.StateCommon.Border.ColorAngle = 10F;
            this.Cbill.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Cbill.StateCommon.Border.Rounding = 50;
            this.Cbill.StateCommon.Content.ShortText.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbill.TabIndex = 81;
            this.Cbill.Values.Text = "Create a new bill";
            this.Cbill.Click += new System.EventHandler(this.Cbill_Click);
            // 
            // MUbill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1319, 626);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Ubill);
            this.Controls.Add(this.Cbill);
            this.Controls.Add(this.closeApplication);
            this.Controls.Add(this.log_Out);
            this.Controls.Add(this.return_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MUbill";
            this.Text = "MUbill";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MofP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.Button log_Out;
        private System.Windows.Forms.Button closeApplication;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Ubill;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Cbill;
        private ComponentFactory.Krypton.Toolkit.KryptonButton create_button;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker Daate;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox CL;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox PN;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox DN;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Up;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox MofP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox IsPaid;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Price;
        private System.Windows.Forms.Label plabel;
    }
}