namespace Persona5Royal.Guide.Jobs.Florist
{
    partial class FormFlorist
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
            WvFlorist = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)WvFlorist).BeginInit();
            SuspendLayout();
            // 
            // WvFlorist
            // 
            WvFlorist.AllowExternalDrop = true;
            WvFlorist.CreationProperties = null;
            WvFlorist.DefaultBackgroundColor = Color.White;
            WvFlorist.Location = new Point(291, 77);
            WvFlorist.Name = "WvFlorist";
            WvFlorist.Size = new Size(75, 23);
            WvFlorist.TabIndex = 0;
            WvFlorist.ZoomFactor = 1D;
            WvFlorist.Click += WvFlorist_Click;
            // 
            // FormFlorist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(800, 450);
            Controls.Add(WvFlorist);
            Name = "FormFlorist";
            Text = "FLORISTERIA";
            ((System.ComponentModel.ISupportInitialize)WvFlorist).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 WvFlorist;
    }
}