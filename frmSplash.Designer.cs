namespace calculadora
{
    partial class frmSplash
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            label1 = new Label();
            carregamentoFalso = new ProgressBar();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblLoading = new Label();
            tmrLoading = new System.Windows.Forms.Timer(components);
            tmrEfeito = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 32F, FontStyle.Bold);
            label1.Location = new Point(121, 0);
            label1.Name = "label1";
            label1.Size = new Size(544, 59);
            label1.TabIndex = 1;
            label1.Text = "MATADORA DE BURROS";
            // 
            // carregamentoFalso
            // 
            carregamentoFalso.Location = new Point(12, 414);
            carregamentoFalso.Name = "carregamentoFalso";
            carregamentoFalso.Size = new Size(776, 24);
            carregamentoFalso.TabIndex = 2;
            carregamentoFalso.Click += carregamentoFalso_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Cursor = Cursors.AppStarting;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(428, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(423, 379);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(202, 62);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(319, 454);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // lblLoading
            // 
            lblLoading.AutoSize = true;
            lblLoading.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblLoading.ForeColor = SystemColors.Control;
            lblLoading.Location = new Point(20, 365);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new Size(0, 46);
            lblLoading.TabIndex = 5;
            lblLoading.TextAlign = ContentAlignment.TopCenter;
            // 
            // tmrLoading
            // 
            tmrLoading.Enabled = true;
            tmrLoading.Interval = 1000;
            tmrLoading.Tick += tmrLoading_Tick;
            // 
            // tmrEfeito
            // 
            tmrEfeito.Enabled = true;
            tmrEfeito.Interval = 500;
            tmrEfeito.Tick += tmrEfeito_Tick;
            // 
            // frmSplash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(830, 451);
            Controls.Add(lblLoading);
            Controls.Add(carregamentoFalso);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Cursor = Cursors.AppStarting;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmSplash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calcula mortes";
            Load += frmSplash_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ProgressBar carregamentoFalso;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblLoading;
        private System.Windows.Forms.Timer tmrLoading;
        private System.Windows.Forms.Timer tmrEfeito;
    }
}
