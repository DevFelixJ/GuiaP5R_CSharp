using Persona5Royal.Utilities;
using System.Diagnostics;
using System.Windows.Forms.Design;

namespace Persona5Royal
{
    public partial class FormMain : Form
    {
        private static FormMain instance;
        private FormMain()
        {
            InitializeComponent();
        }
        public static FormMain GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FormMain();
            }

            return instance;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            FormTracker.AddOpenedForm(this);

        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormTracker.RemoveOpenedForm(this);
        }

        ///BOTONES///
        private void BtnGuide_Click(object sender, EventArgs e)//BOTON GUIA
        {

            ReturnForms.GetFormGuide().Show();
            this.Hide();

        }


        private void BtnConfidents_Click(object sender, EventArgs e)//BOTON CONFIDENTES
        {
            ReturnForms.GetFormConfidents1().Show();
            this.Hide();

        }

        private void BtnBuilds_Click(Object sender, EventArgs e)//BOTON BUILDS
        {
            ReturnForms.GetFormBuilds().Show();
            this.Hide();
        }

        private void BtnPersona_Click(object sender, EventArgs e)
        {
            ReturnForms.GetFormPersona().Show();
            this.Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //FUNCION PARA QUE NO SE CREE MAS INSTANCIAS Y MUESTRE EL FORMULARIO PRINCIPAL
        public static void ReturnToMain()
        {
            GetInstance().Show(); // Muestra el formulario principal
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string url = "https://github.com/DevFelixJ";
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                // Manejo de excepciones si ocurre algún error al abrir la URL
                MessageBox.Show("No se pudo abrir la página web: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


    }
}