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
    public partial class frm_Item_Find : Form
    {
        public string SelCode = "";
        public string SelName = "";
        public string SelBarcode = "";
        public double SelPrice = 0;
        public frm_Item_Find(DataTable dt)
        {
            InitializeComponent();

            dgv_Item_Find.AllowUserToAddRows = false;
            dgv_Item_Find.ReadOnly = true;
            dgv_Item_Find.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Item_Find.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Item_Find.DataSource = dt;
            dgv_Item_Find.CellClick += dgv_Item_Find_CellClick;
        }
        private void dgv_Item_Find_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataRowView r = (DataRowView)dgv_Item_Find.Rows[e.RowIndex].DataBoundItem;
            SelCode     = r["Prod_Code"].ToString();
            SelName     = r["Prod_Name"].ToString();
            SelBarcode  = r["Barcode"].ToString();
            double p;
            double.TryParse(r["Selling_Price"].ToString(), out p);
            SelPrice = p;

            DialogResult = DialogResult.OK;
        }
    }
}
