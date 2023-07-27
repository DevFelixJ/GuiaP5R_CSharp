namespace Persona5Royal.Builds.Queen
{
    partial class FormQueen
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
            WvQueen = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)WvQueen).BeginInit();
            SuspendLayout();
            // 
            // WvQueen
            // 
            WvQueen.AllowExternalDrop = true;
            WvQueen.CreationProperties = null;
            WvQueen.DefaultBackgroundColor = Color.White;
            WvQueen.Location = new Point(363, 214);
            WvQueen.Name = "WvQueen";
            WvQueen.Size = new Size(75, 23);
            WvQueen.TabIndex = 1;
            WvQueen.ZoomFactor = 1D;
            // 
            // FormQueen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(WvQueen);
            Name = "FormQueen";
            Text = "QUEEN";
            Load += FormQueen_Load;
            ((System.ComponentModel.ISupportInitialize)WvQueen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 WvQueen;
    }
}