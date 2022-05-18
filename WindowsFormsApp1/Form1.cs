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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public string itemText;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (inputform inform = new inputform())
            {
                DialogResult resultado = inform.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    Pedido pedidoR = inform.pedidoR;
                    itemreciever.Text=pedidoR.Item;
                    precioreciever.Text=pedidoR.precio;
                    MessageBox.Show("Pedido exitoso");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}