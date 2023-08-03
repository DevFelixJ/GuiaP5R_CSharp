using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persona5Royal.Builds;
using Persona5Royal.Confidents;
using Persona5Royal.Guide;
using Persona5Royal.Guide.Jobs;
using Persona5Royal.Persona;
//SCRIPT PARA PODER RETORNAR A LOS FORMULARIOS PRINCIPALES
namespace Persona5Royal.Utilities
{
    public static class ReturnForms
    {
        private static FormBuilds formBuilds;
        private static FormConfidents1 formConfidents1;
        private static FormConfidents2 formConfidents2;
        private static FormGuide formGuide;
        private static FormJobs formJobs;
        private static FormPersona formPersona;

        public static FormBuilds GetFormBuilds()
        {
            if (formBuilds == null || formBuilds.IsDisposed)
            {
                formBuilds = new FormBuilds();
            }

            return formBuilds;

        }

        

        public static FormConfidents1 GetFormConfidents1()
        {
            if (formConfidents1 == null || formConfidents1.IsDisposed)
            {
                formConfidents1 = new FormConfidents1();
            }

            //Abre el formulario "FormConfidents1"
            return formConfidents1;

        }
        public static FormConfidents2 GetFormConfidents2()
        {
            if (formConfidents2 == null || formConfidents2.IsDisposed)
            {
                formConfidents2 = new FormConfidents2();
            }

            //Abre el formulario "FormConfidents2"
            return formConfidents2;

        }

        public static FormGuide GetFormGuide()
        {
            if (formGuide == null || formGuide.IsDisposed)
            {
                formGuide = new FormGuide();
            }

            //Abre el formulario "FormGuide"
            return formGuide;
        }
        public static FormJobs GetFormJobs()
        {
            if (formJobs == null || formJobs.IsDisposed)
            {
                formJobs = new FormJobs();
            }

            //Abre el formulario "FormJobs"
            return formJobs;
        }

        public static FormPersona GetFormPersona()
        {
            if (formBuilds == null || formPersona.IsDisposed)
            {
                formPersona = new FormPersona();
            }
            //Abre el formulario "FormPersona"
            return formPersona;

        }
    }
}
