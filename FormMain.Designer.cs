namespace Persona5Royal
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnGuide = new Button();
            BtnConfidents = new Button();
            BtnBuilds = new Button();
            BtnExit = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // BtnGuide
            // 
            BtnGuide.BackColor = Color.Crimson;
            BtnGuide.Font = new Font("p5hatty", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnGuide.ForeColor = SystemColors.ButtonFace;
            BtnGuide.Location = new Point(283, 41);
            BtnGuide.Name = "BtnGuide";
            BtnGuide.Size = new Size(223, 58);
            BtnGuide.TabIndex = 0;
            BtnGuide.Text = "GUIA";
            BtnGuide.UseVisualStyleBackColor = false;
            BtnGuide.Click += BtnGuide_Click;
            // 
            // BtnConfidents
            // 
            BtnConfidents.BackColor = Color.Crimson;
            BtnConfidents.Font = new Font("p5hatty", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnConfidents.ForeColor = SystemColors.ButtonFace;
            BtnConfidents.Location = new Point(283, 151);
            BtnConfidents.Name = "BtnConfidents";
            BtnConfidents.Size = new Size(223, 58);
            BtnConfidents.TabIndex = 1;
            BtnConfidents.Text = "CONFIDENTES";
            BtnConfidents.UseVisualStyleBackColor = false;
            BtnConfidents.Click += BtnConfidents_Click;
            // 
            // BtnBuilds
            // 
            BtnBuilds.BackColor = Color.Crimson;
            BtnBuilds.Font = new Font("p5hatty", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnBuilds.ForeColor = SystemColors.ButtonFace;
            BtnBuilds.Location = new Point(283, 260);
            BtnBuilds.Name = "BtnBuilds";
            BtnBuilds.Size = new Size(223, 58);
            BtnBuilds.TabIndex = 2;
            BtnBuilds.Text = "BUILDS";
            BtnBuilds.UseVisualStyleBackColor = false;
            BtnBuilds.Click += BtnBuilds_Click;
            // 
            // BtnExit
            // 
            BtnExit.BackColor = Color.Crimson;
            BtnExit.Font = new Font("p5hatty", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnExit.ForeColor = SystemColors.ButtonFace;
            BtnExit.Location = new Point(313, 402);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(163, 36);
            BtnExit.TabIndex = 3;
            BtnExit.Text = "SALIR";
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = SystemColors.ActiveCaptionText;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(668, 423);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(120, 15);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Created By DevFelix_J";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(BtnExit);
            Controls.Add(BtnBuilds);
            Controls.Add(BtnConfidents);
            Controls.Add(BtnGuide);
            Name = "FormMain";
            Text = "P5R";
            Load += FormMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnGuide;
        private Button BtnConfidents;
        private Button BtnBuilds;
        private Button BtnExit;
        private LinkLabel linkLabel1;
    }
}