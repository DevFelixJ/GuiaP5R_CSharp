using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona5Royal.Utilities
{
    static class FormTracker
    {
        // Lista para almacenar las instancias de formularios abiertos
        private static List<Form> openedForms = new List<Form>();

        // Método para agregar un formulario a la lista de instancias abiertas
        public static void AddOpenedForm(Form form)
        {
            openedForms.Add(form);
        }

        // Método para eliminar un formulario de la lista de instancias abiertas
        public static void RemoveOpenedForm(Form form)
        {
            openedForms.Remove(form);
        }

        // Método para obtener el número de instancias abiertas actualmente
        public static int GetOpenedFormCount()
        {
            return openedForms.Count;
        }

    }
}
