namespace Topic9AssignmentButActually
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.imgCharacter = new System.Windows.Forms.PictureBox();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.lblThwomp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Brown;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(495, 336);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 71);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Click me.";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // imgCharacter
            // 
            this.imgCharacter.Image = ((System.Drawing.Image)(resources.GetObject("imgCharacter.Image")));
            this.imgCharacter.Location = new System.Drawing.Point(481, 219);
            this.imgCharacter.Name = "imgCharacter";
            this.imgCharacter.Size = new System.Drawing.Size(100, 47);
            this.imgCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCharacter.TabIndex = 1;
            this.imgCharacter.TabStop = false;
            this.imgCharacter.Click += new System.EventHandler(this.imgCharacter_Click);
            this.imgCharacter.Resize += new System.EventHandler(this.imgCharacter_Resize);
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(443, 307);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(193, 26);
            this.lblInstruction.TabIndex = 2;
            this.lblInstruction.Text = "Click on the button or the picture.";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Monotxt_IV25", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(61, 14);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status";
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnQuit.Font = new System.Drawing.Font("Niagara Engraved", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnQuit.Location = new System.Drawing.Point(966, 552);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(91, 47);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Button That Kills You";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.AllowDrop = true;
            this.btnGreen.BackColor = System.Drawing.Color.LimeGreen;
            this.btnGreen.Font = new System.Drawing.Font("Papyrus", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGreen.Location = new System.Drawing.Point(935, 12);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(106, 36);
            this.btnGreen.TabIndex = 5;
            this.btnGreen.Text = "Green Button";
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // lblThwomp
            // 
            this.lblThwomp.AutoSize = true;
            this.lblThwomp.Location = new System.Drawing.Point(415, 253);
            this.lblThwomp.Name = "lblThwomp";
            this.lblThwomp.Size = new System.Drawing.Size(28, 13);
            this.lblThwomp.TabIndex = 6;
            this.lblThwomp.Text = "urgh";
            this.lblThwomp.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 601);
            this.Controls.Add(this.lblThwomp);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.imgCharacter);
            this.Controls.Add(this.btnSubmit);
            this.Name = "MainForm";
            this.Text = "Controls, Events, and Properties";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgCharacter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox imgCharacter;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Label lblThwomp;
    }
}

