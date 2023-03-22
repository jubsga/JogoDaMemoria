
namespace JogoDaMemoria
{
    partial class frmRegras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegras));
            this.btnSair = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblGanhar = new System.Windows.Forms.Label();
            this.lblPerder = new System.Windows.Forms.Label();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.lblInfo3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(201)))), ((int)(((byte)(250)))));
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Josefin Sans", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(145, 610);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(251, 92);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "FECHAR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Chewy", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.lblTitulo.Location = new System.Drawing.Point(181, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(146, 51);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Manual:";
            // 
            // lblGanhar
            // 
            this.lblGanhar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGanhar.AutoSize = true;
            this.lblGanhar.Font = new System.Drawing.Font("Chewy", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanhar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.lblGanhar.Location = new System.Drawing.Point(776, 9);
            this.lblGanhar.Name = "lblGanhar";
            this.lblGanhar.Size = new System.Drawing.Size(146, 51);
            this.lblGanhar.TabIndex = 11;
            this.lblGanhar.Text = "Ganhar:";
            // 
            // lblPerder
            // 
            this.lblPerder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPerder.AutoSize = true;
            this.lblPerder.Font = new System.Drawing.Font("Chewy", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.lblPerder.Location = new System.Drawing.Point(776, 385);
            this.lblPerder.Name = "lblPerder";
            this.lblPerder.Size = new System.Drawing.Size(138, 51);
            this.lblPerder.TabIndex = 12;
            this.lblPerder.Text = "Perder:";
            // 
            // lblInfo1
            // 
            this.lblInfo1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.Font = new System.Drawing.Font("Josefin Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.lblInfo1.Location = new System.Drawing.Point(12, 73);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(530, 456);
            this.lblInfo1.TabIndex = 13;
            this.lblInfo1.Text = resources.GetString("lblInfo1.Text");
            this.lblInfo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfo2
            // 
            this.lblInfo2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Font = new System.Drawing.Font("Josefin Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.lblInfo2.Location = new System.Drawing.Point(642, 73);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(422, 266);
            this.lblInfo2.TabIndex = 14;
            this.lblInfo2.Text = resources.GetString("lblInfo2.Text");
            this.lblInfo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfo3
            // 
            this.lblInfo3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInfo3.AutoSize = true;
            this.lblInfo3.Font = new System.Drawing.Font("Josefin Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.lblInfo3.Location = new System.Drawing.Point(629, 436);
            this.lblInfo3.Name = "lblInfo3";
            this.lblInfo3.Size = new System.Drawing.Size(435, 266);
            this.lblInfo3.TabIndex = 15;
            this.lblInfo3.Text = resources.GetString("lblInfo3.Text");
            this.lblInfo3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInfo3.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmRegras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1126, 753);
            this.Controls.Add(this.lblInfo3);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.lblInfo1);
            this.Controls.Add(this.lblPerder);
            this.Controls.Add(this.lblGanhar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegras";
            this.Text = "frmRegras";
            this.Load += new System.EventHandler(this.frmRegras_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblGanhar;
        private System.Windows.Forms.Label lblPerder;
        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.Label lblInfo3;
    }
}