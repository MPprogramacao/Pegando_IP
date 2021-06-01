
namespace Pegando_IP
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIPv4 = new System.Windows.Forms.Button();
            this.btnIPv6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIPv4
            // 
            this.btnIPv4.Location = new System.Drawing.Point(37, 30);
            this.btnIPv4.Name = "btnIPv4";
            this.btnIPv4.Size = new System.Drawing.Size(150, 46);
            this.btnIPv4.TabIndex = 0;
            this.btnIPv4.Text = "IPv4";
            this.btnIPv4.UseVisualStyleBackColor = true;
            this.btnIPv4.Click += new System.EventHandler(this.btnIP_Click);
            // 
            // btnIPv6
            // 
            this.btnIPv6.Location = new System.Drawing.Point(39, 92);
            this.btnIPv6.Name = "btnIPv6";
            this.btnIPv6.Size = new System.Drawing.Size(150, 46);
            this.btnIPv6.TabIndex = 1;
            this.btnIPv6.Text = "IPv6";
            this.btnIPv6.UseVisualStyleBackColor = true;
            this.btnIPv6.Click += new System.EventHandler(this.btnIPv6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 173);
            this.Controls.Add(this.btnIPv6);
            this.Controls.Add(this.btnIPv4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " IP Local";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIPv4;
        private System.Windows.Forms.Button btnIPv6;
    }
}

