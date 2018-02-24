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
    public partial class frmuac : Form
    {
        public frmuac()
        {
            InitializeComponent();
        }
        DataTable dt;
        DataRow dr;
        string acctype,code;
        DialogResult res;

        private void frmuac_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'my_Pay_Roll_SystemDataSet1.UAC' table. You can move, or remove it, as needed.
            this.uACTableAdapter.Fill(this.my_Pay_Roll_SystemDataSet1.UAC);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Add user operation
                this.uACTableAdapter.Fill(this.my_Pay_Roll_SystemDataSet1.UAC);
                dt = my_Pay_Roll_SystemDataSet1.UAC;
                dr = dt.NewRow();

                //Passing Data
                dr["Username"] = txtnewuser.Text;
                dr["Password"] = txtnewpass.Text;

                if (radnewadmin.Checked == true)
                {
                    acctype = "Administrator";
                }
                else if (radnewstand.Checked == true)
                {
                    acctype = "Standard";
                }
                
                dr["Accountype"] = acctype;

                if (radnewadmin.Checked == true || radnewstand.Checked == true )
                {
                    dt.Rows.Add(dr);
                    uACTableAdapter.Update(my_Pay_Roll_SystemDataSet1);
                    MessageBox.Show("User added successfuly", "User Added", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    txtnewuser.Clear();
                    txtnewpass.Clear();
                    radnewadmin.Checked = false;
                    radnewstand.Checked = false;
                }
                else
                {
                    MessageBox.Show("Please choose your Account type","Account type Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                
            }
            catch
            {
                MessageBox.Show("An Error has occured!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operation cancelled!", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtnewuser.Clear();
            txtnewpass.Clear();
            radnewadmin.Checked = false;
            radnewstand.Checked = false;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //Remove user operation
                this.uACTableAdapter.Fill(this.my_Pay_Roll_SystemDataSet1.UAC);
                dt = my_Pay_Roll_SystemDataSet1.UAC;
                code = txtremuser.Text;
                dr = dt.Rows.Find(code);

                if (code == "Admin")
                {
                    MessageBox.Show("You can't Remove Admin Account","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    if (txtrempass.Text == dr["Password"].ToString())
                    {
                        res = MessageBox.Show("Do you really want to delete this User?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (res == DialogResult.Yes)
                        {
                            dr.Delete();
                            uACTableAdapter.Update(my_Pay_Roll_SystemDataSet1);
                            MessageBox.Show("User deleted successful..", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtremuser.Clear();
                            txtrempass.Clear();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Password.Try again!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("User not found","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operation cancelled!","Cancelled",MessageBoxButtons.OK,MessageBoxIcon.Information);
            txtrempass.Clear();
            txtremuser.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                //Change Password operation
                this.uACTableAdapter.Fill(this.my_Pay_Roll_SystemDataSet1.UAC);
                dt = my_Pay_Roll_SystemDataSet1.UAC;
                code = txtchanuser.Text;
                dr = dt.Rows.Find(code);

                if (txtchancurr.Text == dr["Password"].ToString())
                {
                    res = MessageBox.Show("Do you really want to change this password?", "Change password", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        dr.BeginEdit();
                        dr["Password"] = txtchannew.Text;
                        dr.EndEdit();
                        uACTableAdapter.Update(my_Pay_Roll_SystemDataSet1);
                        MessageBox.Show("Password changed successful..", "Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtchanuser.Clear();
                        txtchancurr.Clear();
                        txtchannew.Clear();

                    }
                }
                else
                {
                    MessageBox.Show("Invalid Password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("An error has occured. Can't Change password!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operation cancelled","Cancelled",MessageBoxButtons.OK,MessageBoxIcon.Information);
            txtchanuser.Clear();
            txtchancurr.Clear();
            txtchannew.Clear();

        }

        
    }
}
