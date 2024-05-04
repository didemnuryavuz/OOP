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
    public partial class ShipperCrud : BaseForm
    {
        public ShipperCrud()
        {

            InitializeComponent();
            _adapter = new SqlDataAdapter("Select * From Shippers", _conn);
            _adapter.Fill(northwindDs, "Shippers");
            dataGridView1.DataSource = northwindDs.Tables["Shippers"];
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Boş Veri eklenemez.");
                return;
            }

            SqlCommand cmd = new SqlCommand($"insert into shippers (companyname,phone) values('{textBox1.Text}','{textBox2.Text}')", _conn);


            _conn.Open();
            int sonuc = cmd.ExecuteNonQuery();
            if (sonuc > 0)
            {
                northwindDs.Tables.Clear();
                MessageBox.Show("Verileriniz Basarili bir sekilde eklenmistir.");
                _adapter.Fill(northwindDs, "Shippers");
                dataGridView1.DataSource = northwindDs.Tables["Shippers"];
            }
            _conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Boş Veri eklenemez.");
                return;
            }
            _sql = $"Update shippers set CompanyName='{textBox1.Text}', Phone='{textBox2.Text}' where shipperId={lblId.Text}";
            _conn.Open();
            _command = new SqlCommand(_sql, _conn);
            _command.ExecuteNonQuery();
            int sonuc = _command.ExecuteNonQuery();
            if (sonuc > 0)
            {
                northwindDs.Tables.Clear();
                MessageBox.Show("Verileriniz Basarili bir sekilde güncellenmistir.");
                _adapter.Fill(northwindDs, "Shippers");
                dataGridView1.DataSource = northwindDs.Tables["Shippers"];
            }
            _conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = dataGridView1.CurrentRow.Index;
            lblId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lblId.Text=="0")
            {
                MessageBox.Show("Silinecek kayit yok");
                return;
            }
            _sql = $"Delete from shippers  where shipperId={lblId.Text}";
            _conn.Open();
            _command = new SqlCommand(_sql, _conn);
            _command.ExecuteNonQuery();
            int sonuc = _command.ExecuteNonQuery();
            if (sonuc > 0)
            {
                northwindDs.Tables.Clear();
                MessageBox.Show("Basarili bir sekilde silinmistir.");
                _adapter.Fill(northwindDs, "Shippers");
                dataGridView1.DataSource = northwindDs.Tables["Shippers"];
            }
            _conn.Close();

        }
    }
}
