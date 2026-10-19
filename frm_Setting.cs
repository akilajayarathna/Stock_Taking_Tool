using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Taking_Tool
{
    public partial class frm_Setting : Form
    {
        public frm_Setting()
        {
            InitializeComponent();
        }

        private void frm_Setting_Load(object sender, EventArgs e)
        {
            txt_Servername.Text = cls_MainDb.Server;
            txt_Databese.Text = cls_MainDb.Database;
            btn_Save_Connection.Enabled = false;
            txt_Machine_id.ReadOnly = true;
            btn_Cheack_MachineID.Enabled = true;
            string unit, machineid;
            if (cls_DbCreate.GetSystemDetails(out unit, out machineid))
            {
                txt_Unit_No.Text = unit;
                txt_Machine_id.Text = machineid;
                LockContrals();
            }
            else
            {
                btn_Save.Enabled = false;
            }
        }

        private void txt_Servername_TextChanged(object sender, EventArgs e)
        {
            btn_Save_Connection.Enabled = true;
        }

        private void btn_Test_Connection_Click(object sender, EventArgs e)
        {
            if (txt_Servername.Text.Trim() == "" || txt_Databese.Text.Trim() == "")
            {
                MessageBox.Show("Please enter server name and database name.");
                return;
            }
            btn_Save_Connection.Enabled = false;
            // Cursor == Cursors.WaitCursor;

            try
            {
                string cs = cls_MainDb.BuildConnectionString(txt_Servername.Text, txt_Databese.Text);
                using (var con = new SqlConnection(cs))
                {
                    con.Open();
                }
                btn_Save_Connection.Enabled = true;
                MessageBox.Show("Connection successful.");
            }
            catch (Exception ex)
            {
                btn_Save_Connection.Enabled = false;
                MessageBox.Show("Connection failed:\n " + ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btn_Save_Connection_Click(object sender, EventArgs e)
        {
            cls_MainDb.Save(txt_Servername.Text, txt_Databese.Text);
            MessageBox.Show("Saved");
            DialogResult = DialogResult.OK;
        }

        private void btn_Cheack_MachineID_Click(object sender, EventArgs e)
        {
            string id = cls_MachineInfo.GetprocessorId();
            if (id == "")
            {
                MessageBox.Show("Cant Taking Machine Id..!!");
                return;
            }
            txt_Machine_id.Text = id;
            txt_Unit_No.ReadOnly = false;
            txt_Unit_No.Focus();
            btn_Save.Enabled = true;
        }

        private void txtUnitNo_TextChanged(object sender, EventArgs e)
        {
            UpdateSaveStatus();
        }

        private void UpdateSaveStatus()
        {
            btn_Save.Enabled = txt_Unit_No.ReadOnly && txt_Unit_No.Text.Trim() != "" && txt_Machine_id.Text.Trim() != "";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("if unit number is saved", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            try
            {
                cls_DbCreate.SaveSystemDetails(txt_Unit_No.Text, txt_Machine_id.Text);
                LockContrals();
                MessageBox.Show("Saved Details");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Saved Failed: \n" + ex.Message);
            }
        }
        private void LockContrals()
        {
            txt_Unit_No.ReadOnly = true;
            txt_Machine_id.ReadOnly = true;
            btn_Save.Enabled = false;
        }
    }
}
