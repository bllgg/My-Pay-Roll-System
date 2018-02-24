namespace My_Pay_Roll_System
{
    partial class frmuac
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtnewpass = new System.Windows.Forms.TextBox();
            this.txtnewuser = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radnewstand = new System.Windows.Forms.RadioButton();
            this.radnewadmin = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtrempass = new System.Windows.Forms.TextBox();
            this.txtremuser = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txtchannew = new System.Windows.Forms.TextBox();
            this.txtchancurr = new System.Windows.Forms.TextBox();
            this.txtchanuser = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.my_Pay_Roll_SystemDataSet1 = new My_Pay_Roll_System.My_Pay_Roll_SystemDataSet1();
            this.uACTableAdapter = new My_Pay_Roll_System.My_Pay_Roll_SystemDataSet1TableAdapters.UACTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_Pay_Roll_SystemDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(351, 239);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtnewpass);
            this.tabPage1.Controls.Add(this.txtnewuser);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(343, 213);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create Account";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtnewpass
            // 
            this.txtnewpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnewpass.Location = new System.Drawing.Point(113, 54);
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.PasswordChar = '*';
            this.txtnewpass.Size = new System.Drawing.Size(198, 24);
            this.txtnewpass.TabIndex = 7;
            // 
            // txtnewuser
            // 
            this.txtnewuser.Location = new System.Drawing.Point(113, 13);
            this.txtnewuser.Name = "txtnewuser";
            this.txtnewuser.Size = new System.Drawing.Size(198, 20);
            this.txtnewuser.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(236, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(146, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Create";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radnewstand);
            this.groupBox2.Controls.Add(this.radnewadmin);
            this.groupBox2.Location = new System.Drawing.Point(6, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 48);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account Type";
            // 
            // radnewstand
            // 
            this.radnewstand.AutoSize = true;
            this.radnewstand.Location = new System.Drawing.Point(172, 21);
            this.radnewstand.Name = "radnewstand";
            this.radnewstand.Size = new System.Drawing.Size(93, 17);
            this.radnewstand.TabIndex = 3;
            this.radnewstand.TabStop = true;
            this.radnewstand.Text = "Standard User";
            this.radnewstand.UseVisualStyleBackColor = true;
            // 
            // radnewadmin
            // 
            this.radnewadmin.AutoSize = true;
            this.radnewadmin.Location = new System.Drawing.Point(13, 21);
            this.radnewadmin.Name = "radnewadmin";
            this.radnewadmin.Size = new System.Drawing.Size(110, 17);
            this.radnewadmin.TabIndex = 2;
            this.radnewadmin.TabStop = true;
            this.radnewadmin.Text = "Administrator User";
            this.radnewadmin.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "New Username";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.txtrempass);
            this.tabPage2.Controls.Add(this.txtremuser);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(343, 213);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Remove Account";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Location = new System.Drawing.Point(231, 147);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Cancel";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(150, 147);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Remove";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtrempass
            // 
            this.txtrempass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrempass.Location = new System.Drawing.Point(76, 103);
            this.txtrempass.Name = "txtrempass";
            this.txtrempass.PasswordChar = '*';
            this.txtrempass.Size = new System.Drawing.Size(230, 24);
            this.txtrempass.TabIndex = 3;
            // 
            // txtremuser
            // 
            this.txtremuser.Location = new System.Drawing.Point(76, 33);
            this.txtremuser.Name = "txtremuser";
            this.txtremuser.Size = new System.Drawing.Size(230, 20);
            this.txtremuser.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Username";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.txtchannew);
            this.tabPage3.Controls.Add(this.txtchancurr);
            this.tabPage3.Controls.Add(this.txtchanuser);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(343, 213);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Change password";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Location = new System.Drawing.Point(232, 163);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "Cancel";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Location = new System.Drawing.Point(138, 163);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Change";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtchannew
            // 
            this.txtchannew.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchannew.Location = new System.Drawing.Point(117, 121);
            this.txtchannew.Name = "txtchannew";
            this.txtchannew.PasswordChar = '*';
            this.txtchannew.Size = new System.Drawing.Size(190, 24);
            this.txtchannew.TabIndex = 5;
            // 
            // txtchancurr
            // 
            this.txtchancurr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchancurr.Location = new System.Drawing.Point(117, 72);
            this.txtchancurr.Name = "txtchancurr";
            this.txtchancurr.PasswordChar = '*';
            this.txtchancurr.Size = new System.Drawing.Size(190, 24);
            this.txtchancurr.TabIndex = 4;
            // 
            // txtchanuser
            // 
            this.txtchanuser.Location = new System.Drawing.Point(117, 26);
            this.txtchanuser.Name = "txtchanuser";
            this.txtchanuser.Size = new System.Drawing.Size(190, 20);
            this.txtchanuser.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "New  Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Current Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::My_Pay_Roll_System.Properties.Resources.settings;
            this.pictureBox1.Location = new System.Drawing.Point(383, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "UAC";
            this.bindingSource1.DataSource = this.my_Pay_Roll_SystemDataSet1;
            // 
            // my_Pay_Roll_SystemDataSet1
            // 
            this.my_Pay_Roll_SystemDataSet1.DataSetName = "My_Pay_Roll_SystemDataSet1";
            this.my_Pay_Roll_SystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uACTableAdapter
            // 
            this.uACTableAdapter.ClearBeforeFill = true;
            // 
            // frmuac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 259);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmuac";
            this.Text = "User Account Control";
            this.Load += new System.EventHandler(this.frmuac_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_Pay_Roll_SystemDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtnewpass;
        private System.Windows.Forms.TextBox txtnewuser;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radnewstand;
        private System.Windows.Forms.RadioButton radnewadmin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtrempass;
        private System.Windows.Forms.TextBox txtremuser;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtchannew;
        private System.Windows.Forms.TextBox txtchancurr;
        private System.Windows.Forms.TextBox txtchanuser;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private My_Pay_Roll_SystemDataSet1 my_Pay_Roll_SystemDataSet1;
        private My_Pay_Roll_SystemDataSet1TableAdapters.UACTableAdapter uACTableAdapter;
    }
}