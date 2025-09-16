namespace PrySp2AgorioNuevo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int PrecioKm = 5;
        double Descuento = 0.5;
        int diasEstancia;
        double Distancia;
        double disTotal;
        double Precio;


        private void nudCantDias_ValueChanged(object sender, EventArgs e)
        {
            if (nudCantDias.Value > 0)
            {
                btnCalcular.Enabled = true;

            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }

        private void txtDistancia_TextChanged(object sender, EventArgs e)
        {
            if (txtDistancia.Text != "")
            {
                nudCantDias.Enabled = true;
            }
            else
            {
                nudCantDias.Enabled = false;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            diasEstancia = Convert.ToInt32(nudCantDias.Value);
            Distancia = Convert.ToDouble(txtDistancia.Text.ToString());

            if (diasEstancia > 0)
            {
                disTotal = Distancia * PrecioKm;
                Precio = disTotal - (disTotal * Descuento);
                lblPrecioFinal.Text = "El precio final es: $" + Precio.ToString();
            }
            else
            {
                Precio = Distancia * PrecioKm;
                lblPrecioFinal.Text = "El precio final es: $" + Precio.ToString();
            }
        }
    }
}
