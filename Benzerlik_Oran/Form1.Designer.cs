namespace Benzerlik_Oran
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnyükle2 = new System.Windows.Forms.Button();
            this.btnyükle1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btntxt = new System.Windows.Forms.Button();
            this.btnencokbenzeyen = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.column_resim_ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_benzerlik_orani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnyükle2);
            this.groupBox1.Controls.Add(this.btnyükle1);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 524);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnyükle2
            // 
            this.btnyükle2.Location = new System.Drawing.Point(383, 437);
            this.btnyükle2.Name = "btnyükle2";
            this.btnyükle2.Size = new System.Drawing.Size(144, 40);
            this.btnyükle2.TabIndex = 3;
            this.btnyükle2.Text = "Seç ve Hesapla";
            this.btnyükle2.UseVisualStyleBackColor = true;
            this.btnyükle2.Click += new System.EventHandler(this.btnyükle2_Click);
            // 
            // btnyükle1
            // 
            this.btnyükle1.Location = new System.Drawing.Point(36, 437);
            this.btnyükle1.Name = "btnyükle1";
            this.btnyükle1.Size = new System.Drawing.Size(144, 40);
            this.btnyükle1.TabIndex = 2;
            this.btnyükle1.Text = "Seç";
            this.btnyükle1.UseVisualStyleBackColor = true;
            this.btnyükle1.Click += new System.EventHandler(this.btnyükle1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(324, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(267, 390);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 390);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btntxt
            // 
            this.btntxt.Location = new System.Drawing.Point(661, 79);
            this.btntxt.Name = "btntxt";
            this.btntxt.Size = new System.Drawing.Size(149, 44);
            this.btntxt.TabIndex = 10;
            this.btntxt.Text = "Text çıktı al";
            this.btntxt.UseVisualStyleBackColor = true;
            this.btntxt.Click += new System.EventHandler(this.btntxt_Click);
            // 
            // btnencokbenzeyen
            // 
            this.btnencokbenzeyen.Location = new System.Drawing.Point(661, 158);
            this.btnencokbenzeyen.Name = "btnencokbenzeyen";
            this.btnencokbenzeyen.Size = new System.Drawing.Size(149, 44);
            this.btnencokbenzeyen.TabIndex = 9;
            this.btnencokbenzeyen.Text = "En çok benzeyen";
            this.btnencokbenzeyen.UseVisualStyleBackColor = true;
            this.btnencokbenzeyen.Click += new System.EventHandler(this.btnencokbenzeyen_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_resim_ad,
            this.column_benzerlik_orani,
            this.Yol});
            this.dataGridView1.Location = new System.Drawing.Point(998, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(635, 848);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // column_resim_ad
            // 
            this.column_resim_ad.HeaderText = "Resim_İsim";
            this.column_resim_ad.MinimumWidth = 6;
            this.column_resim_ad.Name = "column_resim_ad";
            this.column_resim_ad.Width = 125;
            // 
            // column_benzerlik_orani
            // 
            this.column_benzerlik_orani.HeaderText = "Benzerlik_Oranı";
            this.column_benzerlik_orani.MinimumWidth = 6;
            this.column_benzerlik_orani.Name = "column_benzerlik_orani";
            this.column_benzerlik_orani.Width = 125;
            // 
            // Yol
            // 
            this.Yol.HeaderText = "Yol";
            this.Yol.MinimumWidth = 6;
            this.Yol.Name = "Yol";
            this.Yol.Width = 125;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(661, 237);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 22);
            this.textBox1.TabIndex = 14;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(683, 306);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(197, 230);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1671, 853);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Emine ÖZGÜR";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(683, 562);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 41);
            this.button1.TabIndex = 17;
            this.button1.Text = "En çok benzeyen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(661, 266);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(284, 22);
            this.textBox2.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1835, 893);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btntxt);
            this.Controls.Add(this.btnencokbenzeyen);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnyükle2;
        private System.Windows.Forms.Button btnyükle1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btntxt;
        private System.Windows.Forms.Button btnencokbenzeyen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_resim_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_benzerlik_orani;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

