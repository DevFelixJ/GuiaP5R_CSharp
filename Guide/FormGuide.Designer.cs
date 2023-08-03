namespace Persona5Royal.Guide
{
    partial class FormGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide));
            BtnCalendar = new Button();
            BtnPalaces = new Button();
            BtnCrosswords = new Button();
            BtnJobs = new Button();
            BtnReturn = new Button();
            SuspendLayout();
            // 
            // BtnCalendar
            // 
            BtnCalendar.BackColor = Color.Crimson;
            BtnCalendar.Font = new Font("p5hatty", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCalendar.ForeColor = SystemColors.ButtonFace;
            BtnCalendar.Location = new Point(12, 12);
            BtnCalendar.Name = "BtnCalendar";
            BtnCalendar.Size = new Size(223, 58);
            BtnCalendar.TabIndex = 1;
            BtnCalendar.Text = "CALENDARIO";
            BtnCalendar.UseVisualStyleBackColor = false;
            BtnCalendar.Click += BtnCalendar_Click;
            // 
            // BtnPalaces
            // 
            BtnPalaces.BackColor = Color.Crimson;
            BtnPalaces.Font = new Font("p5hatty", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPalaces.ForeColor = SystemColors.ButtonFace;
            BtnPalaces.Location = new Point(12, 261);
            BtnPalaces.Name = "BtnPalaces";
            BtnPalaces.Size = new Size(223, 58);
            BtnPalaces.TabIndex = 2;
            BtnPalaces.Text = "PALACIOS";
            BtnPalaces.UseVisualStyleBackColor = false;
            BtnPalaces.Click += BtnPalaces_Click;
            // 
            // BtnCrosswords
            // 
            BtnCrosswords.BackColor = Color.Crimson;
            BtnCrosswords.Font = new Font("p5hatty", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCrosswords.ForeColor = SystemColors.ButtonFace;
            BtnCrosswords.Location = new Point(565, 12);
            BtnCrosswords.Name = "BtnCrosswords";
            BtnCrosswords.Size = new Size(223, 58);
            BtnCrosswords.TabIndex = 3;
            BtnCrosswords.Text = "CRUCIGRAMAS";
            BtnCrosswords.UseVisualStyleBackColor = false;
            BtnCrosswords.Click += BtnCrosswords_Click;
            // 
            // BtnJobs
            // 
            BtnJobs.BackColor = Color.Crimson;
            BtnJobs.Font = new Font("p5hatty", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnJobs.ForeColor = SystemColors.ButtonFace;
            BtnJobs.Location = new Point(565, 261);
            BtnJobs.Name = "BtnJobs";
            BtnJobs.Size = new Size(223, 58);
            BtnJobs.TabIndex = 4;
            BtnJobs.Text = "TRABAJOS";
            BtnJobs.UseVisualStyleBackColor = false;
            BtnJobs.Click += BtnJobs_Click;
            // 
            // BtnReturn
            // 
            BtnReturn.BackColor = Color.Crimson;
            BtnReturn.Font = new Font("p5hatty", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnReturn.ForeColor = SystemColors.ButtonFace;
            BtnReturn.Location = new Point(325, 400);
            BtnReturn.Name = "BtnReturn";
            BtnReturn.Size = new Size(140, 38);
            BtnReturn.TabIndex = 12;
            BtnReturn.Text = "VOLVER";
            BtnReturn.UseVisualStyleBackColor = false;
            BtnReturn.Click += BtnReturn_Click;
            // 
            // FormGuide
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnReturn);
            Controls.Add(BtnJobs);
            Controls.Add(BtnCrosswords);
            Controls.Add(BtnPalaces);
            Controls.Add(BtnCalendar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormGuide";
            Text = "GUIA";
            Load += FormGuide_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BtnCalendar;
        private Button BtnPalaces;
        private Button BtnCrosswords;
        private Button BtnJobs;
        private Button BtnReturn;
    }
}