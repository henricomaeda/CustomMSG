namespace CustomMSG
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.TxtMessage = new System.Windows.Forms.TextBox();
            this.LblMessage = new System.Windows.Forms.Label();
            this.Colour = new System.Windows.Forms.ColorDialog();
            this.PicLicense = new System.Windows.Forms.PictureBox();
            this.BtnForeColour = new System.Windows.Forms.Button();
            this.BtnBackColour = new System.Windows.Forms.Button();
            this.BtnSend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicLicense)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtMessage
            // 
            this.TxtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtMessage.Font = new System.Drawing.Font("Arial", 12F);
            this.TxtMessage.Location = new System.Drawing.Point(23, 236);
            this.TxtMessage.Name = "TxtMessage";
            this.TxtMessage.Size = new System.Drawing.Size(618, 26);
            this.TxtMessage.TabIndex = 2;
            this.TxtMessage.Text = "Eu sou uma mensagem.";
            // 
            // LblMessage
            // 
            this.LblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblMessage.AutoSize = true;
            this.LblMessage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMessage.Location = new System.Drawing.Point(20, 215);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(86, 18);
            this.LblMessage.TabIndex = 5;
            this.LblMessage.Text = "Mensagem";
            // 
            // PicLicense
            // 
            this.PicLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicLicense.Image = global::CustomMSG.Properties.Resources.License;
            this.PicLicense.Location = new System.Drawing.Point(589, 21);
            this.PicLicense.Name = "PicLicense";
            this.PicLicense.Size = new System.Drawing.Size(52, 52);
            this.PicLicense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLicense.TabIndex = 8;
            this.PicLicense.TabStop = false;
            this.PicLicense.Click += new System.EventHandler(this.PicLicense_Click);
            // 
            // BtnForeColour
            // 
            this.BtnForeColour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnForeColour.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnForeColour.Image = global::CustomMSG.Properties.Resources.Colour;
            this.BtnForeColour.Location = new System.Drawing.Point(221, 268);
            this.BtnForeColour.Name = "BtnForeColour";
            this.BtnForeColour.Size = new System.Drawing.Size(185, 49);
            this.BtnForeColour.TabIndex = 7;
            this.BtnForeColour.Text = "COR DA LETRA";
            this.BtnForeColour.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnForeColour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnForeColour.UseVisualStyleBackColor = true;
            this.BtnForeColour.Click += new System.EventHandler(this.BtnColourAndSend_Click);
            // 
            // BtnBackColour
            // 
            this.BtnBackColour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnBackColour.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBackColour.Image = global::CustomMSG.Properties.Resources.Colour;
            this.BtnBackColour.Location = new System.Drawing.Point(23, 268);
            this.BtnBackColour.Name = "BtnBackColour";
            this.BtnBackColour.Size = new System.Drawing.Size(192, 49);
            this.BtnBackColour.TabIndex = 6;
            this.BtnBackColour.Text = "COR DO FUNDO";
            this.BtnBackColour.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBackColour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBackColour.UseVisualStyleBackColor = true;
            this.BtnBackColour.Click += new System.EventHandler(this.BtnColourAndSend_Click);
            // 
            // BtnSend
            // 
            this.BtnSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSend.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSend.Image = global::CustomMSG.Properties.Resources.Message;
            this.BtnSend.Location = new System.Drawing.Point(412, 268);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(229, 49);
            this.BtnSend.TabIndex = 3;
            this.BtnSend.Text = "ENVIAR MENSAGEM";
            this.BtnSend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnColourAndSend_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 338);
            this.Controls.Add(this.PicLicense);
            this.Controls.Add(this.BtnForeColour);
            this.Controls.Add(this.BtnBackColour);
            this.Controls.Add(this.LblMessage);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.TxtMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomMSG";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicLicense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtMessage;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.Label LblMessage;
        private System.Windows.Forms.ColorDialog Colour;
        private System.Windows.Forms.Button BtnBackColour;
        private System.Windows.Forms.Button BtnForeColour;
        private System.Windows.Forms.PictureBox PicLicense;
    }
}

