namespace WindowsFormsApp1
{
    public class Pedido
    {
        public string Item { get; set; }
        public string precio { get; set; }

        public Pedido(string item, string precio)
        {
            Item = item;
            this.precio = precio;
        }
    }
}