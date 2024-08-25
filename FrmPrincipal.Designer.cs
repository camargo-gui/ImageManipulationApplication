namespace ImageManipulationApplication
{
    partial class FrmPrincipal
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
            this.pictBoxImg1 = new System.Windows.Forms.PictureBox();
            this.pictBoxImg2 = new System.Windows.Forms.PictureBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnNormalVerticalMirror = new System.Windows.Forms.Button();
            this.btnNormalHorizontalMirror = new System.Windows.Forms.Button();
            this.verticalMirrorDMA = new System.Windows.Forms.Button();
            this.btnNegativoSemDMA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictBoxImg1
            // 
            this.pictBoxImg1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictBoxImg1.Location = new System.Drawing.Point(5, 6);
            this.pictBoxImg1.Name = "pictBoxImg1";
            this.pictBoxImg1.Size = new System.Drawing.Size(600, 500);
            this.pictBoxImg1.TabIndex = 102;
            this.pictBoxImg1.TabStop = false;
            // 
            // pictBoxImg2
            // 
            this.pictBoxImg2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictBoxImg2.Location = new System.Drawing.Point(611, 6);
            this.pictBoxImg2.Name = "pictBoxImg2";
            this.pictBoxImg2.Size = new System.Drawing.Size(600, 500);
            this.pictBoxImg2.TabIndex = 105;
            this.pictBoxImg2.TabStop = false;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(5, 512);
            this.btnOpenFile.Name = "btnOpenOmage";
            this.btnOpenFile.Size = new System.Drawing.Size(101, 23);
            this.btnOpenFile.TabIndex = 106;
            this.btnOpenFile.Text = "Open Image";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.clickOpenImage);
            // 
            // btnLimpar
            // 
            //this.btnLimpar.Location = new System.Drawing.Point(112, 512);
            //this.btnLimpar.Name = "btnLimpar";
            //this.btnLimpar.Size = new System.Drawing.Size(101, 23);
            //this.btnLimpar.TabIndex = 107;
            //this.btnLimpar.Text = "Limpar";
            //this.btnLimpar.UseVisualStyleBackColor = true;
            //this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            //// 
            //// btnVerticalMirror
            // 
            this.btnNormalVerticalMirror.Location = new System.Drawing.Point(219, 512);
            this.btnNormalVerticalMirror.Name = "btnNormalVerticalMirror";
            this.btnNormalVerticalMirror.Size = new System.Drawing.Size(208, 23);
            this.btnNormalVerticalMirror.TabIndex = 108;
            this.btnNormalVerticalMirror.Text = "Normal Vertical Mirror";
            this.btnNormalVerticalMirror.UseVisualStyleBackColor = true;
            this.btnNormalVerticalMirror.Click += new System.EventHandler(this.clickNormalVerticalMirror);

            //// btnHorizontalMirror
            // 
            this.btnNormalHorizontalMirror.Location = new System.Drawing.Point(219, 541);
            this.btnNormalHorizontalMirror.Name = "btnNormalHorizontalMirror";
            this.btnNormalHorizontalMirror.Size = new System.Drawing.Size(208, 23);
            this.btnNormalHorizontalMirror.TabIndex = 108;
            this.btnNormalHorizontalMirror.Text = "Normal Horizontal Mirror";
            this.btnNormalHorizontalMirror.UseVisualStyleBackColor = true;
            this.btnNormalHorizontalMirror.Click += new System.EventHandler(this.clickNormalHorizontalMirror);
            // 
            // btnLuminanciaComDMA
            // 
            this.verticalMirrorDMA.Location = new System.Drawing.Point(433, 541);
            this.verticalMirrorDMA.Name = "btnVerticalMirrorDMA";
            this.verticalMirrorDMA.Size = new System.Drawing.Size(208, 23);
            this.verticalMirrorDMA.TabIndex = 109;
            this.verticalMirrorDMA.Text = "Vertical Mirror DMA";
            this.verticalMirrorDMA.UseVisualStyleBackColor = true;
            this.verticalMirrorDMA.Click += new System.EventHandler(this.clickVerticalMirrorDMA);
            //// 
            //// btnNegativoComDMA
            //// 
            //this.btnNegativoComDMA.Location = new System.Drawing.Point(433, 541);
            //this.btnNegativoComDMA.Name = "btnNegativoComDMA";
            //this.btnNegativoComDMA.Size = new System.Drawing.Size(208, 23);
            //this.btnNegativoComDMA.TabIndex = 111;
            //this.btnNegativoComDMA.Text = "Negativo com DMA";
            //this.btnNegativoComDMA.UseVisualStyleBackColor = true;
            //this.btnNegativoComDMA.Click += new System.EventHandler(this.btnNegativoComDMA_Click);
            //// 
            //// btnNegativoSemDMA
            //// 
            //this.btnNegativoSemDMA.Location = new System.Drawing.Point(433, 512);
            //this.btnNegativoSemDMA.Name = "btnNegativoSemDMA";
            //this.btnNegativoSemDMA.Size = new System.Drawing.Size(208, 23);
            //this.btnNegativoSemDMA.TabIndex = 110;
            //this.btnNegativoSemDMA.Text = "Negativo sem DMA";
            //this.btnNegativoSemDMA.UseVisualStyleBackColor = true;
            //this.btnNegativoSemDMA.Click += new System.EventHandler(this.btnNegativoSemDMA_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 608);
            this.Controls.Add(this.verticalMirrorDMA);
            this.Controls.Add(this.btnNegativoSemDMA);
            this.Controls.Add(this.btnNormalVerticalMirror);
            this.Controls.Add(this.btnNormalHorizontalMirror);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.pictBoxImg2);
            this.Controls.Add(this.pictBoxImg1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBoxImg1;
        private System.Windows.Forms.PictureBox pictBoxImg2;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnNormalHorizontalMirror;
        private System.Windows.Forms.Button btnNormalVerticalMirror;
        private System.Windows.Forms.Button verticalMirrorDMA;
        private System.Windows.Forms.Button btnNegativoSemDMA;
    }
}
