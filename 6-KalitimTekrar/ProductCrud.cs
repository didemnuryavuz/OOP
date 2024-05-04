using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _6_KalitimTekrar
{
    public partial class ProductCrud : BaseForm
    {
        public ProductCrud()
        {
            InitializeComponent();
        }
        private void ProductCrud_Load(object sender, EventArgs e)
        {
            _adapter = new SqlDataAdapter("Select * from Categories", _conn);
            _adapter.Fill(northwindDs, "Categories");
            Kategoricmb.DataSource = northwindDs.Tables["Categories"];
            Kategoricmb.DisplayMember = "CategoryName";
            Kategoricmb.ValueMember = "CategoryId";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Kategoricmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(Kategoricmb.Text);
            MessageBox.Show(Kategoricmb.SelectedValue.ToString()); //Id verir.

        }
    }
}
