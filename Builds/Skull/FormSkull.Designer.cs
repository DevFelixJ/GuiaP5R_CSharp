namespace Persona5Royal.Builds.Skull
{
    partial class FormSkull
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSkull));
            WvSkull = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)WvSkull).BeginInit();
            SuspendLayout();
            // 
            // WvSkull
            // 
            WvSkull.AllowExternalDrop = true;
            WvSkull.CreationProperties = null;
            WvSkull.DefaultBackgroundColor = Color.White;
            WvSkull.Location = new Point(363, 214);
            WvSkull.Name = "WvSkull";
            WvSkull.Size = new Size(75, 23);
            WvSkull.TabIndex = 1;
            WvSkull.ZoomFactor = 1D;
            WvSkull.Click += WvSkull_Click;
            // 
            // FormSkull
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(WvSkull);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormSkull";
            Text = "SKULL";
            ((System.ComponentModel.ISupportInitialize)WvSkull).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 WvSkull;
    }
}