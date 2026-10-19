using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Taking_Tool
{
    public partial class frm_Loging : Form
    {
        private int attempt = 0;
        public frm_Loging()
        {
            InitializeComponent();
        }

        private string CheackLoging(string user,string pass)
        {
            if (user == "admin" && pass == "onimta1+")return "admin";
            if (user == "user" && pass == "1111") return "user";
            return null;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string Username = txt_Username.Text.Trim().ToLower();
            string role = CheackLoging(Username, txt_Password.Text);

            if(role != null)
            {
                cls_Session.Username = Username;
                cls_Session.Role= role;
                DialogResult = DialogResult.OK;
                return;
            }
            attempt++;
            if(attempt >= 3)
            {
                MessageBox.Show("Too many faild attempt!!!");
                DialogResult = DialogResult.Cancel;
                return;
            }
            MessageBox.Show("Username or Password is incorrect.");
            txt_Password.Clear();
            txt_Password.Focus();

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
