﻿namespace Persona5Royal.Guide.Calendar.SchemeMonths
{
    partial class FormSchemeMonths
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSchemeMonths));
            WvSchemeMonths = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)WvSchemeMonths).BeginInit();
            SuspendLayout();
            // 
            // WvSchemeMonths
            // 
            WvSchemeMonths.AllowExternalDrop = true;
            WvSchemeMonths.CreationProperties = null;
            WvSchemeMonths.DefaultBackgroundColor = Color.White;
            WvSchemeMonths.Location = new Point(66, 26);
            WvSchemeMonths.Name = "WvSchemeMonths";
            WvSchemeMonths.Size = new Size(642, 353);
            WvSchemeMonths.TabIndex = 0;
            WvSchemeMonths.ZoomFactor = 1D;
            WvSchemeMonths.Click += WvSchemeMonths_Click;
            // 
            // FormSchemeMonths
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(WvSchemeMonths);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormSchemeMonths";
            Text = "ESQUEMA MESES";
            ((System.ComponentModel.ISupportInitialize)WvSchemeMonths).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 WvSchemeMonths;
    }
}