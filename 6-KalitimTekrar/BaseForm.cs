using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_KalitimTekrar
{
    public partial class BaseForm : Form
    {
        public SqlConnection _conn;  //SqlServer'a baglanmak icin gerekli
        public SqlCommand _command;  //Baglanti uzerinden sorgu calistirmak icin gerekli
        public SqlDataReader _reader;//Command Nesnesi UZerinden okuma yapmak icin gerekli
        public string _sql, constr = "Server=LAPTOP-7J52A9UD\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;";

        //Button 3 Nesneleri 
        public DataSet northwindDs = new DataSet(); //Yuklenen Datalari Tutar
        public SqlDataAdapter _adapter;             //DataSete Veri Doldurmaya Yarar

        List<Shipper> Shippers = new List<Shipper>();

        public BaseForm()
        {
            _conn = new SqlConnection(constr);
            //InitializeComponent();
        }
    }
}
