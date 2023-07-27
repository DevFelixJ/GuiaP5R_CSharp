namespace Persona5Royal.Builds.Violet
{
    partial class FormViolet
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
            WvViolet = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)WvViolet).BeginInit();
            SuspendLayout();
            // 
            // WvViolet
            // 
            WvViolet.AllowExternalDrop = true;
            WvViolet.CreationProperties = null;
            WvViolet.DefaultBackgroundColor = Color.White;
            WvViolet.Location = new Point(363, 214);
            WvViolet.Name = "WvViolet";
            WvViolet.Size = new Size(75, 23);
            WvViolet.TabIndex = 1;
            WvViolet.ZoomFactor = 1D;
            WvViolet.Click += WvViolet_Click;
            // 
            // FormViolet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(WvViolet);
            Name = "FormViolet";
            Text = "VIOLET";
            ((System.ComponentModel.ISupportInitialize)WvViolet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 WvViolet;
    }
}