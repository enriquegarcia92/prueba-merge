using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class inputform : Form
    {
        public Pedido pedidoR { get; set; }
        public inputform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pedidoR = new Pedido(textitem.Text,textprecio.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}