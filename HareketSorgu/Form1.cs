using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HareketSorgu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-KIMUOA0\SQLEXPRESS;Initial Catalog=DbHareket;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbHareketDataSet.Hareket' table. You can move, or remove it, as needed.
            this.hareketTableAdapter.Fill(this.dbHareketDataSet.Hareket);



        }
    }
}
