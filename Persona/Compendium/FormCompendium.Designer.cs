namespace Persona5Royal.Persona.Compendium
{
    partial class FormCompendium
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompendium));
            WvCompendium = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)WvCompendium).BeginInit();
            SuspendLayout();
            // 
            // WvCompendium
            // 
            WvCompendium.AllowExternalDrop = true;
            WvCompendium.CreationProperties = null;
            WvCompendium.DefaultBackgroundColor = Color.White;
            WvCompendium.Location = new Point(328, 106);
            WvCompendium.Name = "WvCompendium";
            WvCompendium.Size = new Size(75, 23);
            WvCompendium.TabIndex = 0;
            WvCompendium.ZoomFactor = 1D;
            // 
            // FormCompendium
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(WvCompendium);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCompendium";
            Text = "COMPENDIO";
            ((System.ComponentModel.ISupportInitialize)WvCompendium).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 WvCompendium;
    }
}