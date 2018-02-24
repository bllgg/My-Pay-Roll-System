//This is the login form 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace My_Pay_Roll_System
{
    public partial class frmlogin : Form
    {

        public static string USER_TYPE;
           
        public frmlogin()
        {
            InitializeComponent();
        }
        
        //these are the variables for dealing with database
        DataTable dt;
        DataRow dr;
        string code;

        //this is for close button
        private void button3_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        //this is for clear button
        private void button2_Click(object sender, EventArgs e)
        {
            txtpass.Clear();
            txtuser.Clear();
        }

        //this is for ok button
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.uACTableAdapter.Fill(this.my_Pay_Roll_SystemDataSet2.UAC);
                dt = my_Pay_Roll_SystemDataSet2.UAC;
                code = txtuser.Text;
                dr = dt.Rows.Find(code);

                //this will check admin accounts
                if (txtpass.Text == dr["Password"].ToString() && dr["Accountype"].ToString() == "Administrator")
                {
                    USER_TYPE = "Administrator";
                    MDIParent1 main = new MDIParent1();
                    main.Show();

                }
                //this will check standard accounts
                else if (txtpass.Text == dr["Password"].ToString() && dr["Accountype"].ToString() == "Standard")
                {
                    USER_TYPE = "Standard";
                    MDIParent1 main = new MDIParent1();
                    main.Show();
                    

                }
                // this will run when username or password error
                else
                {
                    MessageBox.Show("Invalid password. Try again!", "Invalid Username Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("An error has occured. Please enter correct username and password","Access is denied!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                this.uACTableAdapter.Fill(this.my_Pay_Roll_SystemDataSet2.UAC);
                dt = my_Pay_Roll_SystemDataSet2.UAC;
                code = txtuser.Text;
                dr = dt.Rows.Find(code);
                // only admins can get access to setting form
                if (txtpass.Text == dr["Password"].ToString() && dr["Accountype"].ToString() == "Administrator")
                {

                    frmuac settings = new frmuac();
                    settings.Show();
                    

                }
                else
                {
                    MessageBox.Show("Access is denied. Make sure that you're trying to login as Administrator!", "Access is denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Access is denied. Try again. Make sure that you're trying to login as Administrator", "Access is denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmloggin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'my_Pay_Roll_SystemDataSet2.UAC' table. You can move, or remove it, as needed.
            this.uACTableAdapter.Fill(this.my_Pay_Roll_SystemDataSet2.UAC);

        }
    }
}
