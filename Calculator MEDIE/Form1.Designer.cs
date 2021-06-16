
namespace Calculator_MEDIE
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lstNote = new System.Windows.Forms.ListBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.btnCalculeaza = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblMedie = new System.Windows.Forms.Label();
            this.txtTeza = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTeza = new System.Windows.Forms.Panel();
            this.radCuTeza = new System.Windows.Forms.RadioButton();
            this.radFaraTeza = new System.Windows.Forms.RadioButton();
            this.grpTeza = new System.Windows.Forms.GroupBox();
            this.pnlTeza.SuspendLayout();
            this.grpTeza.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.MediumPurple;
            this.txtNote.Location = new System.Drawing.Point(91, 85);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(132, 23);
            this.txtNote.TabIndex = 1;
            // 
            // lstNote
            // 
            this.lstNote.BackColor = System.Drawing.Color.DarkOrchid;
            this.lstNote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstNote.FormattingEnabled = true;
            this.lstNote.ItemHeight = 21;
            this.lstNote.Location = new System.Drawing.Point(91, 149);
            this.lstNote.Name = "lstNote";
            this.lstNote.Size = new System.Drawing.Size(132, 256);
            this.lstNote.TabIndex = 2;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(1004, 418);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(75, 23);
            this.btnAdauga.TabIndex = 3;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(1004, 465);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(75, 23);
            this.btnSterge.TabIndex = 4;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // btnCalculeaza
            // 
            this.btnCalculeaza.Location = new System.Drawing.Point(1004, 515);
            this.btnCalculeaza.Name = "btnCalculeaza";
            this.btnCalculeaza.Size = new System.Drawing.Size(75, 23);
            this.btnCalculeaza.TabIndex = 5;
            this.btnCalculeaza.Text = "Calculeaza";
            this.btnCalculeaza.UseVisualStyleBackColor = true;
            this.btnCalculeaza.Click += new System.EventHandler(this.btnCalculeaza_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(1004, 565);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblMedie
            // 
            this.lblMedie.AutoSize = true;
            this.lblMedie.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMedie.Location = new System.Drawing.Point(563, 194);
            this.lblMedie.Name = "lblMedie";
            this.lblMedie.Size = new System.Drawing.Size(71, 30);
            this.lblMedie.TabIndex = 7;
            this.lblMedie.Text = "Media";
            // 
            // txtTeza
            // 
            this.txtTeza.Location = new System.Drawing.Point(49, 69);
            this.txtTeza.Name = "txtTeza";
            this.txtTeza.Size = new System.Drawing.Size(100, 23);
            this.txtTeza.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nota Teza";
            // 
            // pnlTeza
            // 
            this.pnlTeza.BackColor = System.Drawing.Color.Thistle;
            this.pnlTeza.Controls.Add(this.label1);
            this.pnlTeza.Controls.Add(this.txtTeza);
            this.pnlTeza.Location = new System.Drawing.Point(496, 362);
            this.pnlTeza.Name = "pnlTeza";
            this.pnlTeza.Size = new System.Drawing.Size(200, 136);
            this.pnlTeza.TabIndex = 11;
            // 
            // radCuTeza
            // 
            this.radCuTeza.AutoSize = true;
            this.radCuTeza.Location = new System.Drawing.Point(75, 97);
            this.radCuTeza.Name = "radCuTeza";
            this.radCuTeza.Size = new System.Drawing.Size(64, 19);
            this.radCuTeza.TabIndex = 0;
            this.radCuTeza.Text = "Cu teza";
            this.radCuTeza.UseVisualStyleBackColor = true;
            // 
            // radFaraTeza
            // 
            this.radFaraTeza.AutoSize = true;
            this.radFaraTeza.Checked = true;
            this.radFaraTeza.Location = new System.Drawing.Point(75, 143);
            this.radFaraTeza.Name = "radFaraTeza";
            this.radFaraTeza.Size = new System.Drawing.Size(72, 19);
            this.radFaraTeza.TabIndex = 1;
            this.radFaraTeza.TabStop = true;
            this.radFaraTeza.Text = "Fara Teza";
            this.radFaraTeza.UseVisualStyleBackColor = true;
            this.radFaraTeza.CheckedChanged += new System.EventHandler(this.radFaraTeza_CheckedChanged);
            // 
            // grpTeza
            // 
            this.grpTeza.BackColor = System.Drawing.Color.MediumOrchid;
            this.grpTeza.Controls.Add(this.radFaraTeza);
            this.grpTeza.Controls.Add(this.radCuTeza);
            this.grpTeza.Location = new System.Drawing.Point(875, 149);
            this.grpTeza.Name = "grpTeza";
            this.grpTeza.Size = new System.Drawing.Size(317, 226);
            this.grpTeza.TabIndex = 0;
            this.grpTeza.TabStop = false;
            this.grpTeza.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdauga;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1204, 676);
            this.Controls.Add(this.pnlTeza);
            this.Controls.Add(this.lblMedie);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculeaza);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.lstNote);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.grpTeza);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlTeza.ResumeLayout(false);
            this.pnlTeza.PerformLayout();
            this.grpTeza.ResumeLayout(false);
            this.grpTeza.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.ListBox lstNote;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Button btnCalculeaza;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblMedie;
        private System.Windows.Forms.TextBox txtTeza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTeza;
        private System.Windows.Forms.RadioButton radCuTeza;
        private System.Windows.Forms.RadioButton radFaraTeza;
        private System.Windows.Forms.GroupBox grpTeza;
    }
}

