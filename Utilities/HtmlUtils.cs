using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Web.WebView2.WinForms;
using Persona5Royal.Persona;

namespace Persona5Royal.Utilities
{
    internal class HtmlUtils
    {
        private const string folderPathCompendium = "Assets\\Html\\listCompendium\\";
        public static void OpenHtml(WebView2 webView, string fileName)
        {
            string appDirectory = Application.StartupPath;
            string filePath = Path.Combine(appDirectory, folderPathCompendium, fileName);
            webView.Source = new Uri(filePath);
        }
    }
}
