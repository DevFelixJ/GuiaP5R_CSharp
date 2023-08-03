namespace Persona5Royal.Guide.Jobs
{
    partial class FormJobs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJobs));
            Btn777 = new Button();
            BtnFlorista = new Button();
            BtnRamen = new Button();
            BtnReturn = new Button();
            SuspendLayout();
            // 
            // Btn777
            // 
            Btn777.BackColor = Color.Crimson;
            Btn777.Font = new Font("p5hatty", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Btn777.ForeColor = SystemColors.ButtonFace;
            Btn777.Location = new Point(288, 59);
            Btn777.Name = "Btn777";
            Btn777.Size = new Size(223, 58);
            Btn777.TabIndex = 3;
            Btn777.Text = "777";
            Btn777.UseVisualStyleBackColor = false;
            Btn777.Click += Btn777_Click;
            // 
            // BtnFlorista
            // 
            BtnFlorista.BackColor = Color.Crimson;
            BtnFlorista.Font = new Font("p5hatty", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnFlorista.ForeColor = SystemColors.ButtonFace;
            BtnFlorista.Location = new Point(288, 156);
            BtnFlorista.Name = "BtnFlorista";
            BtnFlorista.Size = new Size(223, 58);
            BtnFlorista.TabIndex = 4;
            BtnFlorista.Text = "FLORISTA";
            BtnFlorista.UseVisualStyleBackColor = false;
            BtnFlorista.Click += BtnFlorista_Click;
            // 
            // BtnRamen
            // 
            BtnRamen.BackColor = Color.Crimson;
            BtnRamen.Font = new Font("p5hatty", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnRamen.ForeColor = SystemColors.ButtonFace;
            BtnRamen.Location = new Point(288, 254);
            BtnRamen.Name = "BtnRamen";
            BtnRamen.Size = new Size(223, 58);
            BtnRamen.TabIndex = 5;
            BtnRamen.Text = "RAMEN";
            BtnRamen.UseVisualStyleBackColor = false;
            BtnRamen.Click += BtnRamen_Click;
            // 
            // BtnReturn
            // 
            BtnReturn.BackColor = Color.Crimson;
            BtnReturn.Font = new Font("p5hatty", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnReturn.ForeColor = SystemColors.ButtonFace;
            BtnReturn.Location = new Point(648, 400);
            BtnReturn.Name = "BtnReturn";
            BtnReturn.Size = new Size(140, 38);
            BtnReturn.TabIndex = 12;
            BtnReturn.Text = "VOLVER";
            BtnReturn.UseVisualStyleBackColor = false;
            BtnReturn.Click += BtnReturn_Click;
            // 
            // FormJobs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnReturn);
            Controls.Add(BtnRamen);
            Controls.Add(BtnFlorista);
            Controls.Add(Btn777);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormJobs";
            Text = "TRABAJOS";
            Load += FormJobs_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Btn777;
        private Button BtnFlorista;
        private Button BtnRamen;
        private Button BtnReturn;
    }
}