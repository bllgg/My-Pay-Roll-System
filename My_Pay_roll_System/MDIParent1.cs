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
    

    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
            if (frmlogin.USER_TYPE == "Standard")
            {
                tabControl1.TabPages.RemoveAt(1);
            }
        }
        //Variables
        DataTable dt;
        DataRow dr;
        String gender, civil, code;
        DialogResult res;
        float bs, sp, bon, od, loan, tot, net, epf12, epf8, etf3;
        

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Add button
                // Connecting to Database
                this.empalldetailsTableAdapter.Fill(this.my_Pay_Roll_SystemDataSet.empalldetails);
                dt = my_Pay_Roll_SystemDataSet.empalldetails;
                dr = dt.NewRow();

                //Passing Data
                dr["Empno"] = txtnum.Text;
                dr["Enpname"] = txtname.Text;
                dr["Address"] = txtaddress.Text;
                dr["Telephone"] = txttel.Text;
                dr["NIC"] = txtnic.Text;
                dr["DOB"] = dtpdob.Text;
                dr["Dept"] = cmbdept.Text;
                dr["Blood"] = cmbblood.Text;
                dr["Emgtel"] = txtemg.Text;

                //Radio buttons
                if (radmale.Checked == true)
                {
                    gender = "Male";
                }
                else if (radfemale.Checked == true)
                {
                    gender = "Female";
                }
                dr["Gender"] = gender;

                if (radsingle.Checked == true)
                {
                    civil = "Single";
                }
                else if (radmarried.Checked == true)
                {
                    civil = "Married";
                }
                dr["Civil"] = civil;

                //Updating Data
                dt.Rows.Add(dr);
                empalldetailsTableAdapter.Update(my_Pay_Roll_SystemDataSet);
                MessageBox.Show("Record Added Successfuly", "Record Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //clear Data
                this.clear1();
            }
            catch
            {
                MessageBox.Show("Invalid Employee Number","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        void clear1()
        {
            //clear method 2
            txtnum.Clear();
            txtname.Clear();
            txtaddress.Clear();
            txtnic.Clear();
            txttel.Clear();
            txtemg.Clear();
            cmbdept.Text = "";
            cmbblood.Text = "";
            radmale.Checked = false;
            radfemale.Checked = false;
            radsingle.Checked = false;
            radmarried.Checked = false;
            dtpdob.Text = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.clear1();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.clear2();
        }

        void clear2()
        {
            //clear Method 2
            txtnameedu.Clear();
            txtnumedu.Clear();
            txtol.Clear();
            txtal.Clear();
            txtacd.Clear();
            txtprof.Clear();

        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'my_Pay_Roll_SystemDataSet.UAC' table. You can move, or remove it, as needed.
            this.uACTableAdapter.Fill(this.my_Pay_Roll_SystemDataSet.UAC);
            // TODO: This line of code loads data into the 'my_Pay_Roll_SystemDataSet.empalldetails' table. You can move, or remove it, as needed.
            this.empalldetailsTableAdapter.Fill(this.my_Pay_Roll_SystemDataSet.empalldetails);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Search button
                //Finding Operation
                this.empalldetailsTableAdapter.Fill(this.my_Pay_Roll_SystemDataSet.empalldetails);
                dt = my_Pay_Roll_SystemDataSet.empalldetails;
                code = txtnum.Text;
                dr = dt.Rows.Find(code);

                //Data receiving
                txtname.Text = dr["EnpName"].ToString();
                txtaddress.Text = dr["Address"].ToString();
                txttel.Text = dr["Telephone"].ToString();
                txtnic.Text = dr["NIC"].ToString();
                txtemg.Text = dr["Emgtel"].ToString();
                cmbdept.Text = dr["Dept"].ToString();
                cmbblood.Text = dr["Blood"].ToString();
                dtpdob.Text = dr["DOB"].ToString();

                gender = dr["Gender"].ToString();
                if (gender == "Male")
                {
                    radmale.Checked = true;
                }
                else if (gender == "Female")
                {
                    radfemale.Checked = true;
                }

                civil = dr["Civil"].ToString();
                if (civil == "Single")
                {
                    radsingle.Checked = true;
                }
                else if (civil == "Married")
                {
                    radmarried.Checked = true;
                }
            }
            catch
            {
                MessageBox.Show("Record not found. Try Again!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Update button
                //Finding Operation
                this.empalldetailsTableAdapter.Fill(this.my_Pay_Roll_SystemDataSet.empalldetails);
                dt = my_Pay_Roll_SystemDataSet.empalldetails;
                code = txtnum.Text;
                dr = dt.Rows.Find(code);

                dr.BeginEdit();
                //passing data
                dr["EmpNo"] = txtnum.Text;
                dr["EnpName"] = txtname.Text;
                dr["Address"] = txtaddress.Text;
                dr["Telephone"] = txttel.Text;
                dr["NIC"] = txtnic.Text;
                dr["Dept"] = cmbdept.Text;
                dr["Blood"] = cmbblood.Text;
                dr["Emgtel"] = txtemg.Text;
                dr["DOB"] = dtpdob.Text;

                //Passing Radio Button Detail
                if (radfemale.Checked == true)
                {
                    gender = "Male";
                }
                else if (radfemale.Checked == true)
                {
                    gender = "Female";
                }
                dr["Gender"] = gender;

                if (radsingle.Checked == true)
                {
                    civil = "Single";
                }
                else if (radmarried.Checked == true)
                {
                    civil = "Married";
                }
                dr["Civil"] = civil;

                dr.EndEdit();

                res = MessageBox.Show("Do you want to update this record....?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    //Operating
                    empalldetailsTableAdapter.Update(my_Pay_Roll_SystemDataSet);
                    MessageBox.Show("Record Updated Successfully...","Updated",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.clear1();
                }
            }
            catch
            {
                MessageBox.Show("An error has occured! Can't Update!", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Delete button
                //Finding Operation
                this.empalldetailsTableAdapter.Fill(this.my_Pay_Roll_SystemDataSet.empalldetails);
                dt = my_Pay_Roll_SystemDataSet.empalldetails;
                code = txtnum.Text;
                dr = dt.Rows.Find(code);

                res = MessageBox.Show("Do you really want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    dr.Delete();
                    empalldetailsTableAdapter.Update(my_Pay_Roll_SystemDataSet);
                    this.clear1();
                    MessageBox.Show("Record deleted successful..", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Record not found. Please check employee number again!","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                //Sallery search button
                this.empalldetailsTableAdapter.Fill(this.my_Pay_Roll_SystemDataSet.empalldetails);
                dt = my_Pay_Roll_SystemDataSet.empalldetails;
                code = txtnumsal.Text;
                dr = dt.Rows.Find(code);

                //Data receiving
                txtnamesal.Text = dr["EnpName"].ToString();
                txtbasic.Text = dr["Bsallery"].ToString();
            }
            catch
            {
                MessageBox.Show("Record not found", "No Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                //Sallery Update button
                this.empalldetailsTableAdapter.Fill(this.my_Pay_Roll_SystemDataSet.empalldetails);
                dt = my_Pay_Roll_SystemDataSet.empalldetails;
                code = txtnumsal.Text;
                dr = dt.Rows.Find(code);

                dr.BeginEdit();
                //pasiing data
                dr["Bsallery"] = txtbasic.Text;

                dr.EndEdit();

                res = MessageBox.Show("Do you want to update this record....?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    //Operating
                    empalldetailsTableAdapter.Update(my_Pay_Roll_SystemDataSet);
                    MessageBox.Show("Record Updated Successfully...", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.clear1();
                }
            }
            catch
            {
                MessageBox.Show("Some thing wrong. Can't update..","Error",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtnumsal.Clear();
            txtnamesal.Clear();
            txtbasic.Clear();
            txtbon.Text="0";
            txtsbon.Clear();
            txtloan.Text="0";
            txtother.Text="0";
            txtnet.Clear();
            txtepf12.Clear();
            txtepf8.Clear();
            txtetf3.Clear();
            txttot.Clear();
            cmbmon.Text = "";
            cmbyear.Text = "";

            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                bs = float.Parse(txtbasic.Text);
                bon = float.Parse(txtbon.Text);
                loan = float.Parse(txtloan.Text);
                od = float.Parse(txtother.Text);

                //Calculate
                if (cmbmon.Text == "April")
                {
                    sp = bs * 1;
                }
                else if (cmbmon.Text == "December")
                {
                    sp = bs * 2;
                }
                else
                {
                    sp = 0;
                }
                txtsbon.Text = sp.ToString();
                epf12 = bs * 12 / 100;
                epf8 = bs * 8 / 100;
                etf3 = bs * 3 / 100;
                tot = epf12 + epf8 + etf3;
                net = bs + sp + bon - od - loan - epf8;


                // Transer data
                txtepf12.Text = epf12.ToString();
                txtepf8.Text = epf8.ToString();
                txtetf3.Text = etf3.ToString();
                txtnet.Text = net.ToString();
                txtsbon.Text = sp.ToString();
                txttot.Text = tot.ToString();
            }
            catch
            {
                MessageBox.Show("Please Enter correct details..","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                //Education search button
                this.empalldetailsTableAdapter.Fill(this.my_Pay_Roll_SystemDataSet.empalldetails);
                dt = my_Pay_Roll_SystemDataSet.empalldetails;
                code = txtnumedu.Text;
                dr = dt.Rows.Find(code);

                txtnameedu.Text = dr["EnpName"].ToString();
                txtol.Text = dr["Ol"].ToString();
                txtal.Text = dr["Al"].ToString();
                txtacd.Text = dr["Acd"].ToString();
                txtprof.Text = dr["Prof"].ToString();
            }
            catch
            {
                MessageBox.Show("Record not found","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                //Educatoin Update
                this.empalldetailsTableAdapter.Fill(this.my_Pay_Roll_SystemDataSet.empalldetails);
                dt = my_Pay_Roll_SystemDataSet.empalldetails;
                code = txtnumedu.Text;
                dr = dt.Rows.Find(code);

                dr.BeginEdit();
                dr["Ol"] = txtol.Text;
                dr["Al"] = txtal.Text;
                dr["Acd"] = txtacd.Text;
                dr["Prof"] = txtprof.Text;
                dr.EndEdit();

                res = MessageBox.Show("Do you want to update this record....?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    //Operating
                    empalldetailsTableAdapter.Update(my_Pay_Roll_SystemDataSet);
                    MessageBox.Show("Record Updated Successfully...", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.clear2();
                }
            }
            catch
            {
                MessageBox.Show("Something wrong. Can't update..!!","Update error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void tabsallery_Click(object sender, EventArgs e)
        {
            
        }
        

        
    }
}
