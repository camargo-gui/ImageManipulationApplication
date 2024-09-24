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
            pictBoxImg1 = new PictureBox();
            pictBoxImg2 = new PictureBox();
            btnOpenFile = new Button();
            // this.btnLimpar = new System.Windows.Forms.Button();
            openFileDialog = new OpenFileDialog();
            btnNormalVerticalMirror = new Button();
            btnNormalHorizontalMirror = new Button();
            verticalMirrorDMA = new Button();
            btnNegativoSemDMA = new Button();
            btnFourConected = new Button();
            btnThinning = new Button();
            ((System.ComponentModel.ISupportInitialize)pictBoxImg1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictBoxImg2).BeginInit();
            SuspendLayout();
            // 
            // pictBoxImg1
            // 
            pictBoxImg1.BackColor = SystemColors.ControlLightLight;
            pictBoxImg1.Location = new System.Drawing.Point(5, 6);
            pictBoxImg1.Name = "pictBoxImg1";
            pictBoxImg1.Size = new Size(600, 500);
            pictBoxImg1.TabIndex = 102;
            pictBoxImg1.TabStop = false;
            // 
            //pictBoxImg2


            pictBoxImg2.BackColor = SystemColors.ControlLightLight;
            pictBoxImg2.Location = new System.Drawing.Point(611, 6);
            pictBoxImg2.Name = "pictBoxImg2";
            pictBoxImg2.Size = new Size(600, 500);
            pictBoxImg2.TabIndex = 105;
            pictBoxImg2.TabStop = false;

            // btnOpenFile
            // 
            btnOpenFile.Location = new System.Drawing.Point(5, 512);
            btnOpenFile.Name = "btnOpenOmage";
            btnOpenFile.Size = new Size(101, 23);
            btnOpenFile.TabIndex = 106;
            btnOpenFile.Text = "Open Image";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += clickOpenImage;
            // 
            // btnLimpar
            // 
            // this.btnLimpar.Location = new System.Drawing.Point(112, 512);
            // this.btnLimpar.Name = "btnLimpar";
            // this.btnLimpar.Size = new System.Drawing.Size(101, 23);
            // this.btnLimpar.TabIndex = 107;
            // this.btnLimpar.Text = "Limpar";
            // this.btnLimpar.UseVisualStyleBackColor = true;
            // this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // // btnVerticalMirror
            // 
            //btnNormalVerticalMirror.Location = new System.Drawing.Point(219, 512);
            //btnNormalVerticalMirror.Name = "btnNormalVerticalMirror";
            //btnNormalVerticalMirror.Size = new Size(208, 23);
            //btnNormalVerticalMirror.TabIndex = 108;
            //btnNormalVerticalMirror.Text = "Normal Vertical Mirror";
            //btnNormalVerticalMirror.UseVisualStyleBackColor = true;
            //btnNormalVerticalMirror.Click += clickNormalVerticalMirror;
            //// // btnHorizontalMirror
            //// 
            //btnNormalHorizontalMirror.Location = new System.Drawing.Point(219, 541);
            //btnNormalHorizontalMirror.Name = "btnNormalHorizontalMirror";
            //btnNormalHorizontalMirror.Size = new Size(208, 23);
            //btnNormalHorizontalMirror.TabIndex = 108;
            //btnNormalHorizontalMirror.Text = "Normal Horizontal Mirror";
            //btnNormalHorizontalMirror.UseVisualStyleBackColor = true;
            //btnNormalHorizontalMirror.Click += clickNormalHorizontalMirror;
            //// 
            //// btnLuminanciaComDMA
            //// 
            //verticalMirrorDMA.Location = new System.Drawing.Point(433, 541);
            //verticalMirrorDMA.Name = "btnVerticalMirrorDMA";
            //verticalMirrorDMA.Size = new Size(208, 23);
            //verticalMirrorDMA.TabIndex = 109;
            //verticalMirrorDMA.Text = "Vertical Mirror DMA";
            //verticalMirrorDMA.UseVisualStyleBackColor = true;
            //verticalMirrorDMA.Click += clickVerticalMirrorDMA;
            // 
            // btn4Conectada
            // 
            btnFourConected.Location = new System.Drawing.Point(219, 512);
            btnFourConected.Name = "btnThinning";
            btnFourConected.Size = new Size(208, 23);
            btnFourConected.TabIndex = 111;
            btnFourConected.Text = "Thinning";
            btnFourConected.UseVisualStyleBackColor = true;
            btnFourConected.Click += clickThinning;
            // btn8Conectada
            // 
            btnNegativoSemDMA.Location = new System.Drawing.Point(219, 541);
            btnNegativoSemDMA.Name = "ContourExtraction";
            btnNegativoSemDMA.Size = new Size(208, 23);
            btnNegativoSemDMA.TabIndex = 110;
            btnNegativoSemDMA.Text = "ContourExtraction";
            btnNegativoSemDMA.UseVisualStyleBackColor = true;
            btnNegativoSemDMA.Click += clickContour;
            // btnThinning
            // 
            //btnThinning.Location = new System.Drawing.Point(647, 541);
            //btnThinning.Name = "btnThinning";
            //btnThinning.Size = new Size(208, 23);
            //btnThinning.TabIndex = 110;
            //btnThinning.Text = "Thinning";
            //btnThinning.UseVisualStyleBackColor = true;
            //btnThinning.Click += clickThinning;
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 608);
            Controls.Add(btnFourConected);
            Controls.Add(verticalMirrorDMA);
            Controls.Add(btnNegativoSemDMA);
            Controls.Add(btnNormalVerticalMirror);
            Controls.Add(btnNormalHorizontalMirror);
            // this.Controls.Add(this.btnLimpar);
            Controls.Add(btnOpenFile);
            Controls.Add(pictBoxImg2);
            Controls.Add(pictBoxImg1);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulário Principal";
            ((System.ComponentModel.ISupportInitialize)pictBoxImg1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictBoxImg2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictBoxImg1;
        private System.Windows.Forms.PictureBox pictBoxImg2;
        private System.Windows.Forms.Button btnOpenFile;
        //private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnNormalHorizontalMirror;
        private System.Windows.Forms.Button btnNormalVerticalMirror;
        private System.Windows.Forms.Button verticalMirrorDMA;
        private System.Windows.Forms.Button btnNegativoSemDMA;
        private System.Windows.Forms.Button btnFourConected;
        private System.Windows.Forms.Button btnEightConected;
        private System.Windows.Forms.Button btnThinning;
    }
}
