using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona5Royal.Utilities
{
    internal class ShowInstances
    {

        //Este codigo es para saber cuantas instancias hay abiertas, por si se da el caso de que haya formularios ocultos y no se han cerrado.
        //Este ejemplo es con el archivo FormMain
        /*
        public partial class FormMain : Form
        {
            private static FormMain instance; /////////////////////////////////AQUI SE CREA LA VARIABLE

            private FormMain()
            {
                InitializeComponent();
            }
            public static FormMain GetInstance() /////////////////////////////AQUI SE OBTIENE LA INSTANCIA SI ESTA ABIERTA
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FormMain();
                }

                return instance;
            }
            private void FormMain_Load(object sender, EventArgs e) //////////AQUI LA FUNCION ADDOPENEDFORM DEL ARCHIVO FORMTRACKER METE A LA LISTA EL FORM
            {
                FormTracker.AddOpenedForm(this);

            }

            private void FormMain_FormClosed(object sender, FormClosedEventArgs e) //////// SI EL FORMULARIO SE CIERRA
            {
                FormTracker.RemoveOpenedForm(this);
            }

            private void BtnInstances_Click(object sender, EventArgs e) /////EN ESTE BOTON SE MIRA CUANTAS VECES ESTA ABIERTA LA INSTANCIA
            {
                int numeroInstanciasAbiertas = FormTracker.GetOpenedFormCount();
                string nombreFormularioActual = this.Name;
                MessageBox.Show($"Número de formularios abiertos: {numeroInstanciasAbiertas}\nFormulario actual: {nombreFormularioActual}"); ;
            }
        }
    }
    */
    }
}