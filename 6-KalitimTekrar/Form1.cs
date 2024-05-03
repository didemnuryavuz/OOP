using System.Data.SqlClient;

namespace _6_KalitimTekrar
{
    public partial class Form1 : Form
    {
        SqlConnection _conn;  //SqlServer'a baglanmak icin gerekli
        SqlCommand _command;  //Baglanti uzerinden sorgu calistirmak icin gerekli
        SqlDataReader _reader;//Command Nesnesi UZerinden okuma yapmak icin gerekli
        string _sql, constr = "Server=LAPTOP-7J52A9UD\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;";


        List<Shipper> Shippers= new List<Shipper>();
        public Form1()
        {
            //Connection String Nedir:
            // Herhangi bir database e baglanmak istedigimizde bu veri tabani ile ilgili bilgiler iceren 
            // ve ";" ile ayrilmis bir soz dizimidir
            _conn = new SqlConnection(constr);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _conn.Open();
                //MessageBox.Show("Baglanti Basarili");
                _sql = "Select * From Shippers";
                _command = new SqlCommand(_sql, _conn);
                _reader = _command.ExecuteReader();
                while (_reader.Read())
                {
                    listBox1.Items.Add(_reader["ShipperID"] + " " + _reader["CompanyName"] + " " + _reader["Phone"] + " ");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                _conn?.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                _conn.Open();
                
                _sql = "Select * From Shippers";
                _command = new SqlCommand(_sql, _conn);
                _reader = _command.ExecuteReader();
                while (_reader.Read())
                {
                    Shipper shipper = new Shipper();
                    shipper.ShipperID = int.Parse(_reader[0].ToString());
                    shipper.CompanyName = _reader[1].ToString();
                    shipper.Phone = _reader[2].ToString();
                    Shippers.Add(shipper);

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                _conn?.Close();
            }
        }
    }
}
