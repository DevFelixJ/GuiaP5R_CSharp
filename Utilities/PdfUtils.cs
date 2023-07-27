using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;
using Persona5Royal.Guide;
using Persona5Royal.Guide.Calendar;

namespace Persona5Royal.Utilities
{
    internal class PdfUtils
    {
        private const string folderPathCalendar = "Assets\\Pdf\\";
        public static void OpenPdf(WebView2 webView, string fileName)
        {
            string appDirectory = Application.StartupPath;
            string filePath = Path.Combine(appDirectory, folderPathCalendar,fileName);
            webView.Source = new Uri(filePath);
        }
    }
}
