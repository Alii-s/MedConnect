namespace MedConnect.Secretary
{
    partial class MUbills
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MUbills));
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.closeApplication = new System.Windows.Forms.Button();
            this.logOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonComboBox1 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(94, 272);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(281, 100);
            this.kryptonButton2.StateCommon.Border.ColorAngle = 10F;
            this.kryptonButton2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StateCommon.Border.Rounding = 50;
            this.kryptonButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton2.TabIndex = 11;
            this.kryptonButton2.Values.Text = "Create a new bill";
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Location = new System.Drawing.Point(94, 138);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.Size = new System.Drawing.Size(281, 95);
            this.kryptonButton3.StateCommon.Border.ColorAngle = 10F;
            this.kryptonButton3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.StateCommon.Border.Rounding = 50;
            this.kryptonButton3.StateCommon.Content.ShortText.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton3.TabIndex = 12;
            this.kryptonButton3.Values.Text = "Update a bill";
            // 
            // closeApplication
            // 
            this.closeApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeApplication.FlatAppearance.BorderSize = 0;
            this.closeApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeApplication.Image = ((System.Drawing.Image)(resources.GetObject("closeApplication.Image")));
            this.closeApplication.Location = new System.Drawing.Point(959, -2);
            this.closeApplication.Margin = new System.Windows.Forms.Padding(2);
            this.closeApplication.Name = "closeApplication";
            this.closeApplication.Size = new System.Drawing.Size(45, 37);
            this.closeApplication.TabIndex = 9;
            this.closeApplication.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.closeApplication.UseVisualStyleBackColor = true;
            // 
            // logOut
            // 
            this.logOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOut.FlatAppearance.BorderSize = 0;
            this.logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut.Image = ((System.Drawing.Image)(resources.GetObject("logOut.Image")));
            this.logOut.Location = new System.Drawing.Point(11, 11);
            this.logOut.Margin = new System.Windows.Forms.Padding(2);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(45, 37);
            this.logOut.TabIndex = 8;
            this.logOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.kryptonComboBox1);
            this.panel1.Controls.Add(this.kryptonButton1);
            this.panel1.Location = new System.Drawing.Point(381, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 518);
            this.panel1.TabIndex = 13;
            this.panel1.Visible = false;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(116, 357);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(90, 25);
            this.kryptonButton1.TabIndex = 0;
            this.kryptonButton1.Values.Text = "kryptonButton1";
            // 
            // kryptonComboBox1
            // 
            this.kryptonComboBox1.DropDownWidth = 185;
            this.kryptonComboBox1.Location = new System.Drawing.Point(226, 52);
            this.kryptonComboBox1.Name = "kryptonComboBox1";
            this.kryptonComboBox1.Size = new System.Drawing.Size(185, 21);
            this.kryptonComboBox1.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonComboBox1.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonComboBox1.TabIndex = 1;
            this.kryptonComboBox1.Text = "kryptonComboBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(73)))));
            this.label1.Location = new System.Drawing.Point(32, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type of session";
            // 
            // MUbills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1003, 586);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonButton3);
            this.Controls.Add(this.kryptonButton2);
            this.Controls.Add(this.closeApplication);
            this.Controls.Add(this.logOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MUbills";
            this.Text = "MUbills";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Button closeApplication;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
    }
}