namespace Persona5Royal.Guide.Jobs._777
{
    partial class Form777
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
            Wv777 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)Wv777).BeginInit();
            SuspendLayout();
            // 
            // Wv777
            // 
            Wv777.AllowExternalDrop = true;
            Wv777.CreationProperties = null;
            Wv777.DefaultBackgroundColor = Color.White;
            Wv777.Location = new Point(340, 92);
            Wv777.Name = "Wv777";
            Wv777.Size = new Size(75, 23);
            Wv777.TabIndex = 0;
            Wv777.ZoomFactor = 1D;
            Wv777.Click += Wv777_Click;
            // 
            // Form777
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(800, 450);
            Controls.Add(Wv777);
            Name = "Form777";
            Text = "TIENDA 777";
            ((System.ComponentModel.ISupportInitialize)Wv777).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 Wv777;
    }
}