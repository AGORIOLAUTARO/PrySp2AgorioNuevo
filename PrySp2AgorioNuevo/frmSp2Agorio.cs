namespace PrySp2AgorioNuevo
{
    public partial class frmSp2Agorio : Form
    {
        public frmSp2Agorio()
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

            if (Distancia <= 0)
            {
                MessageBox.Show("La distancia debe ser mayor a 0 km.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (diasEstancia < 1 || diasEstancia > 30)
            {
                MessageBox.Show("Los días de estancia deben estar entre 1 y 30.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            disTotal = Distancia * 2;
            Precio = disTotal * PrecioKm;

            if (Distancia >= 100 && diasEstancia >= 7)
            {
                Precio = Precio - (Precio * Descuento);
            }

            MessageBox.Show($"El precio del boleto es: {Precio} pesos",
                           "Resultado",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
        }   
    }
}
