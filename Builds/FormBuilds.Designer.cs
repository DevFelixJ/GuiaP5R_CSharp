namespace Persona5Royal.Builds
{
    partial class FormBuilds
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuilds));
            BtnPanther = new Button();
            BtnJoker = new Button();
            BtnFox = new Button();
            BtnSkull = new Button();
            BtnMona = new Button();
            BtnNoir = new Button();
            BtnCrow = new Button();
            BtnViolet = new Button();
            BtnReturn = new Button();
            SuspendLayout();
            // 
            // BtnPanther
            // 
            BtnPanther.Image = (Image)resources.GetObject("BtnPanther.Image");
            BtnPanther.Location = new Point(12, 12);
            BtnPanther.Name = "BtnPanther";
            BtnPanther.Size = new Size(168, 153);
            BtnPanther.TabIndex = 1;
            BtnPanther.UseVisualStyleBackColor = true;
            BtnPanther.Click += BtnPanther_Click;
            // 
            // BtnJoker
            // 
            BtnJoker.Image = Properties.Resources.Joker;
            BtnJoker.Location = new Point(215, 12);
            BtnJoker.Name = "BtnJoker";
            BtnJoker.Size = new Size(168, 153);
            BtnJoker.TabIndex = 2;
            BtnJoker.UseVisualStyleBackColor = true;
            BtnJoker.Click += BtnJoker_Click;
            // 
            // BtnFox
            // 
            BtnFox.Image = Properties.Resources.Fox;
            BtnFox.Location = new Point(416, 12);
            BtnFox.Name = "BtnFox";
            BtnFox.Size = new Size(168, 153);
            BtnFox.TabIndex = 3;
            BtnFox.UseVisualStyleBackColor = true;
            BtnFox.Click += BtnFox_Click;
            // 
            // BtnSkull
            // 
            BtnSkull.Image = Properties.Resources.Skull;
            BtnSkull.Location = new Point(610, 12);
            BtnSkull.Name = "BtnSkull";
            BtnSkull.Size = new Size(168, 153);
            BtnSkull.TabIndex = 4;
            BtnSkull.UseVisualStyleBackColor = true;
            BtnSkull.Click += BtnSkull_Click;
            // 
            // BtnMona
            // 
            BtnMona.Image = (Image)resources.GetObject("BtnMona.Image");
            BtnMona.Location = new Point(12, 191);
            BtnMona.Name = "BtnMona";
            BtnMona.Size = new Size(177, 153);
            BtnMona.TabIndex = 5;
            BtnMona.UseVisualStyleBackColor = true;
            BtnMona.Click += BtnMona_Click;
            // 
            // BtnNoir
            // 
            BtnNoir.Image = Properties.Resources.Noir;
            BtnNoir.Location = new Point(215, 191);
            BtnNoir.Name = "BtnNoir";
            BtnNoir.Size = new Size(168, 153);
            BtnNoir.TabIndex = 6;
            BtnNoir.UseVisualStyleBackColor = true;
            BtnNoir.Click += BtnNoir_Click;
            // 
            // BtnCrow
            // 
            BtnCrow.Image = Properties.Resources.Crow;
            BtnCrow.Location = new Point(416, 191);
            BtnCrow.Name = "BtnCrow";
            BtnCrow.Size = new Size(168, 153);
            BtnCrow.TabIndex = 7;
            BtnCrow.UseVisualStyleBackColor = true;
            BtnCrow.Click += BtnCrow_Click;
            // 
            // BtnViolet
            // 
            BtnViolet.Image = Properties.Resources.Violet;
            BtnViolet.Location = new Point(610, 191);
            BtnViolet.Name = "BtnViolet";
            BtnViolet.Size = new Size(168, 153);
            BtnViolet.TabIndex = 8;
            BtnViolet.UseVisualStyleBackColor = true;
            BtnViolet.Click += BtnViolet_Click;
            // 
            // BtnReturn
            // 
            BtnReturn.BackColor = Color.Crimson;
            BtnReturn.Font = new Font("p5hatty", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnReturn.ForeColor = SystemColors.ButtonFace;
            BtnReturn.Location = new Point(330, 400);
            BtnReturn.Name = "BtnReturn";
            BtnReturn.Size = new Size(140, 38);
            BtnReturn.TabIndex = 12;
            BtnReturn.Text = "VOLVER";
            BtnReturn.UseVisualStyleBackColor = false;
            BtnReturn.Click += BtnReturn_Click;
            // 
            // FormBuilds
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnReturn);
            Controls.Add(BtnViolet);
            Controls.Add(BtnCrow);
            Controls.Add(BtnNoir);
            Controls.Add(BtnMona);
            Controls.Add(BtnSkull);
            Controls.Add(BtnFox);
            Controls.Add(BtnJoker);
            Controls.Add(BtnPanther);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormBuilds";
            Text = "BUILDS";
            Load += FormBuilds_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BtnPanther;
        private Button BtnJoker;
        private Button BtnFox;
        private Button BtnSkull;
        private Button BtnMona;
        private Button BtnNoir;
        private Button BtnCrow;
        private Button BtnViolet;
        private Button BtnReturn;
    }
}