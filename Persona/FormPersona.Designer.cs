namespace Persona5Royal.Persona
{
    partial class FormPersona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersona));
            BtnReturn = new Button();
            BtnCalculator = new Button();
            BtnCompendium = new Button();
            SuspendLayout();
            // 
            // BtnReturn
            // 
            BtnReturn.BackColor = Color.Crimson;
            BtnReturn.Font = new Font("p5hatty", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnReturn.ForeColor = SystemColors.ButtonFace;
            BtnReturn.Location = new Point(638, 400);
            BtnReturn.Name = "BtnReturn";
            BtnReturn.Size = new Size(140, 38);
            BtnReturn.TabIndex = 13;
            BtnReturn.Text = "VOLVER";
            BtnReturn.UseVisualStyleBackColor = false;
            BtnReturn.Click += BtnReturn_Click;
            // 
            // BtnCalculator
            // 
            BtnCalculator.BackColor = Color.Crimson;
            BtnCalculator.Font = new Font("p5hatty", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCalculator.ForeColor = SystemColors.ButtonFace;
            BtnCalculator.Location = new Point(277, 98);
            BtnCalculator.Name = "BtnCalculator";
            BtnCalculator.Size = new Size(223, 58);
            BtnCalculator.TabIndex = 14;
            BtnCalculator.Text = "CALCULADORA";
            BtnCalculator.UseVisualStyleBackColor = false;
            BtnCalculator.Click += BtnCalculator_Click;
            // 
            // BtnCompendium
            // 
            BtnCompendium.BackColor = Color.Crimson;
            BtnCompendium.Font = new Font("p5hatty", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCompendium.ForeColor = SystemColors.ButtonFace;
            BtnCompendium.Location = new Point(277, 199);
            BtnCompendium.Name = "BtnCompendium";
            BtnCompendium.Size = new Size(223, 58);
            BtnCompendium.TabIndex = 15;
            BtnCompendium.Text = "COMPENDIO";
            BtnCompendium.UseVisualStyleBackColor = false;
            BtnCompendium.Click += BtnCompendium_Click;
            // 
            // FormPersona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnCompendium);
            Controls.Add(BtnCalculator);
            Controls.Add(BtnReturn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormPersona";
            Text = "PERSONA";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnReturn;
        private Button BtnCalculator;
        private Button BtnCompendium;
    }
}