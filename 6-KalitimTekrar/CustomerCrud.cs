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
    public partial class CustomerCrud : BaseForm
    {
        
        public CustomerCrud()
        {
            InitializeComponent();

            _adapter = new SqlDataAdapter("Select * from Customers", _conn);
            _adapter.Fill(northwindDs, "Customers");
            dataGridView1.DataSource = northwindDs.Tables["Customers"];
        }

        private void CustomerCrud_Load(object sender, EventArgs e)
        {
        }
    }
}
