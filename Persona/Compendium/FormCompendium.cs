using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Persona5Royal.Utilities;
using Microsoft.Web.WebView2.WinForms;

namespace Persona5Royal.Persona.Compendium
{
    public partial class FormCompendium : Form
    {
        private WebView2 webView;

        public FormCompendium()
        {
            InitializeComponent();

            //Inicializar WebView2
            webView = new WebView2();
            webView.Dock = DockStyle.Fill;
            this.Controls.Add(webView);

            this.Load += FormCompendium_Load;
        }

        private void FormCompendium_Load(object sender, EventArgs e)
        {
            string filename = "index.html";
            HtmlUtils.OpenHtml(webView, filename);
            webView.Focus();

        }
    }
}
