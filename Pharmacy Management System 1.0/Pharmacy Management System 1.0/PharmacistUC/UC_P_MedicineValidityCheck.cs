using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System_1._0.PharmacistUC
{
    public partial class UC_P_MedicineValidityCheck : UserControl
    {
        function fn = new function();
        String query;
        public UC_P_MedicineValidityCheck()

        {
            InitializeComponent();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtCheck.SelectedIndex == 0)
            {
                query = "select * from medic where eDate >= getData()";
                DataSet ds = fn.getData(query);
                gunaDataGridView1.DataSource = ds.Tables[0];
                setLabel.Text = "Valid Medicines.";
                setLabel.ForeColor = Color.Black;


            }
        }
    }
}
