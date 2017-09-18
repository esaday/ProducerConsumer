namespace TK_Cons_F_v0.UI
{
    partial class frmAddSettings
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxSome = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAdi = new System.Windows.Forms.TextBox();
            this.numericUDAltLim = new System.Windows.Forms.NumericUpDown();
            this.numericUDUstLim = new System.Windows.Forms.NumericUpDown();
            this.numericUDBirLim = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDAltLim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDUstLim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDBirLim)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(341, 263);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(185, 60);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = " EKLE";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxSome
            // 
            this.textBoxSome.Location = new System.Drawing.Point(432, 209);
            this.textBoxSome.Multiline = true;
            this.textBoxSome.Name = "textBoxSome";
            this.textBoxSome.Size = new System.Drawing.Size(138, 27);
            this.textBoxSome.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(295, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 16);
            this.label12.TabIndex = 5;
            this.label12.Text = "Aranacak Kelime :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(304, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Geçersiz Değer :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(353, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "Üst Limit :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(358, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Alt Limit :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(310, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Yeni Ayar İsmi :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(350, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 39);
            this.label2.TabIndex = 15;
            this.label2.Text = "&Yeni Ayar";
            // 
            // textBoxAdi
            // 
            this.textBoxAdi.Location = new System.Drawing.Point(431, 100);
            this.textBoxAdi.Name = "textBoxAdi";
            this.textBoxAdi.Size = new System.Drawing.Size(120, 20);
            this.textBoxAdi.TabIndex = 13;
            // 
            // numericUDAltLim
            // 
            this.numericUDAltLim.Location = new System.Drawing.Point(431, 128);
            this.numericUDAltLim.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUDAltLim.Name = "numericUDAltLim";
            this.numericUDAltLim.Size = new System.Drawing.Size(45, 20);
            this.numericUDAltLim.TabIndex = 16;
            this.numericUDAltLim.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUDUstLim
            // 
            this.numericUDUstLim.Location = new System.Drawing.Point(431, 156);
            this.numericUDUstLim.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUDUstLim.Name = "numericUDUstLim";
            this.numericUDUstLim.Size = new System.Drawing.Size(45, 20);
            this.numericUDUstLim.TabIndex = 16;
            this.numericUDUstLim.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUDBirLim
            // 
            this.numericUDBirLim.Location = new System.Drawing.Point(431, 185);
            this.numericUDBirLim.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUDBirLim.Name = "numericUDBirLim";
            this.numericUDBirLim.Size = new System.Drawing.Size(45, 20);
            this.numericUDBirLim.TabIndex = 16;
            this.numericUDBirLim.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // frmAddSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 455);
            this.Controls.Add(this.numericUDBirLim);
            this.Controls.Add(this.numericUDUstLim);
            this.Controls.Add(this.numericUDAltLim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxSome);
            this.Controls.Add(this.textBoxAdi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddSettings";
            this.Text = "AddSettings";
            ((System.ComponentModel.ISupportInitialize)(this.numericUDAltLim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDUstLim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDBirLim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxSome;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAdi;
        private System.Windows.Forms.NumericUpDown numericUDAltLim;
        private System.Windows.Forms.NumericUpDown numericUDUstLim;
        private System.Windows.Forms.NumericUpDown numericUDBirLim;
    }
}