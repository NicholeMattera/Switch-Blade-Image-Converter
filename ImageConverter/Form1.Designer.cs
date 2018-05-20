namespace ImageConverter
{
    partial class frmMain
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
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.opnDialog = new System.Windows.Forms.OpenFileDialog();
            this.savDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(93, 12);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.convert);
            // 
            // btnOpen
            // 
            this.btnOpen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOpen.Location = new System.Drawing.Point(12, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.open);
            // 
            // picPreview
            // 
            this.picPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreview.Location = new System.Drawing.Point(13, 42);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(640, 360);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 3;
            this.picPreview.TabStop = false;
            // 
            // opnDialog
            // 
            this.opnDialog.Filter = "PNG Images|*.png";
            // 
            // savDialog
            // 
            this.savDialog.DefaultExt = "bin";
            this.savDialog.FileName = "splash.bin";
            this.savDialog.Filter = "Binary File|*.bin";
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnOpen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnConvert;
            this.ClientSize = new System.Drawing.Size(666, 415);
            this.Controls.Add(this.picPreview);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnConvert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Image Converter";
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.OpenFileDialog opnDialog;
        private System.Windows.Forms.SaveFileDialog savDialog;
    }
}

