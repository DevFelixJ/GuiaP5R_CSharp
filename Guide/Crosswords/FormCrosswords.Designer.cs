namespace Persona5Royal.Guide.Crosswords
{
    partial class FormCrosswords
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
            WvCrosswords = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)WvCrosswords).BeginInit();
            SuspendLayout();
            // 
            // WvCrosswords
            // 
            WvCrosswords.AllowExternalDrop = true;
            WvCrosswords.CreationProperties = null;
            WvCrosswords.DefaultBackgroundColor = Color.White;
            WvCrosswords.Location = new Point(274, 79);
            WvCrosswords.Name = "WvCrosswords";
            WvCrosswords.Size = new Size(75, 23);
            WvCrosswords.TabIndex = 0;
            WvCrosswords.ZoomFactor = 1D;
            WvCrosswords.Click += WvCrosswords_Click;
            // 
            // FormCrosswords
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(800, 450);
            Controls.Add(WvCrosswords);
            Name = "FormCrosswords";
            Text = "CRUCIGRAMAS";
            Load += FormCrosswords_Load_1;
            ((System.ComponentModel.ISupportInitialize)WvCrosswords).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 WvCrosswords;
    }
}