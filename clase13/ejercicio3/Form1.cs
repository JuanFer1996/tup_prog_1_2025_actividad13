using ejercicio3.Models;

namespace ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Lote lote = new Lote();
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Lote lote = new Lote();
            Form2 form2 = new Form2();
            if( form2.ShowDialog() == DialogResult.OK)
            {
                lote.AsignarNumeroLote(Convert.ToInt32(form2.tbValor.Text));

                btnMedida.Enabled = true;
                btnVerTodas.Enabled = true;
            }
            else
            {
                btnMedida.Enabled = false;
                btnVerTodas.Enabled = false;
            }
        }

        private void btnMedida_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            if (form2.ShowDialog() == DialogResult.OK)
            {
                double medida = Convert.ToDouble(form2.tbValor.Text);
                lote.RegistrarMedida( medida );
            }
        }

        private void btnVerTodas_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            form3.listBox1.Items.Clear();
            
            for (int i = 0; i < lote.VerCantidad(); i++)
            {
                form3.listBox1.Items.Add(lote.VerMedida(i));
            }

            form3.ShowDialog();
        }
    }
}
