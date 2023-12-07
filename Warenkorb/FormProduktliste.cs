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

namespace Warenkorb
{
    public partial class FormProduktliste : Form
    {
        public FormProduktliste()
        {
            InitializeComponent();
        }

        private void buttonHinzufugen_Click(object sender, EventArgs e)
        {
           
        }
       


        private void linkLabelWarenkorb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormWarenkorb formWarenkorb = new FormWarenkorb();
            formWarenkorb.ShowDialog();
        }

        private void FormProduktliste_Load(object sender, EventArgs e)
        {
            getProduct();
        }

        public void getProduct()
        {
            // Verbindung zur Datenbank herstellen
            string connectionString = "Server=mssql1.webland.ch;Database=d041e_blj;User Id=d041e_blj;Password=BljDbPw_01;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // Abfrage vorbereiten
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from products";

            // Abfrage ausführen 
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Product p = new Product();
                p.Name = reader["product_name"].ToString();
                p.Price = Convert.ToDouble(reader["price"]);
                comboBoxProdukt.Items.Add(p);
            }
        }
    }
}
