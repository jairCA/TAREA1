namespace Laboratorio_7_Formulario
{
    public partial class frmArquitecto : Form
    {
        Arquitecto arquitecto;
        public frmArquitecto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void frmArquitecto_Load(object sender, EventArgs e)
        {
            cboCondicion.SelectedIndex = 0;
            cboEspecialidad.SelectedIndex = 0;
            cboActividad.SelectedIndex = 0;
            cboAfiliacion.SelectedIndex = 0;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cboCondicion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            string nombre = txtNombre.Text;
            string condicion = cboCondicion.Text;
            string especialidad = cboEspecialidad.Text;
            string actividad = cboActividad.Text;
            string afiliacion = cboAfiliacion.Text;
            arquitecto = new Arquitecto(codigo, nombre, condicion, especialidad, actividad, afiliacion);
            MessageBox.Show("Objeto Creado");
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            txtResultado.AppendText("Codigo: " + arquitecto.Codigo + Environment.NewLine);
            txtResultado.AppendText("Nombre: " + arquitecto.Nombre + Environment.NewLine);
            txtResultado.AppendText("Condicion de Contrato: " + arquitecto.CondicionContrato + Environment.NewLine);
            txtResultado.AppendText("Especialidad: " + arquitecto.Especialidad + Environment.NewLine);
            txtResultado.AppendText("Tipo de Actividad: " + arquitecto.TipoActividad + Environment.NewLine);
            txtResultado.AppendText("Tipo de Afiliacion: " + arquitecto.TipoAfiliacion + Environment.NewLine);
            
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = string.Empty;
            txtNombre.Clear();
            txtResultado.Clear();
        }
    }
}
