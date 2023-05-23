
namespace KutuphaneProjesi
{
    partial class formTur
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
            this.gridtur = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtturadi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridtur)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridtur
            // 
            this.gridtur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridtur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridtur.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridtur.Location = new System.Drawing.Point(85, 259);
            this.gridtur.Name = "gridtur";
            this.gridtur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridtur.Size = new System.Drawing.Size(630, 150);
            this.gridtur.TabIndex = 5;
            this.gridtur.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridtur_CellClick);
            this.gridtur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridtur_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnkaydet);
            this.groupBox3.Controls.Add(this.btnsil);
            this.groupBox3.Controls.Add(this.btnguncelle);
            this.groupBox3.Location = new System.Drawing.Point(204, 157);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 96);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // btnkaydet
            // 
            this.btnkaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkaydet.ImageIndex = 0;
            this.btnkaydet.Location = new System.Drawing.Point(26, 27);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(87, 40);
            this.btnkaydet.TabIndex = 15;
            this.btnkaydet.Text = "kaydet";
            this.btnkaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnsil
            // 
            this.btnsil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsil.ImageIndex = 1;
            this.btnsil.Location = new System.Drawing.Point(136, 27);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(78, 40);
            this.btnsil.TabIndex = 16;
            this.btnsil.Text = "sil";
            this.btnsil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguncelle.ImageIndex = 2;
            this.btnguncelle.Location = new System.Drawing.Point(234, 27);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(87, 40);
            this.btnguncelle.TabIndex = 17;
            this.btnguncelle.Text = "güncelle";
            this.btnguncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtturadi);
            this.groupBox1.Location = new System.Drawing.Point(85, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 110);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "tür adi";
            // 
            // txtturadi
            // 
            this.txtturadi.Location = new System.Drawing.Point(279, 58);
            this.txtturadi.Name = "txtturadi";
            this.txtturadi.Size = new System.Drawing.Size(100, 20);
            this.txtturadi.TabIndex = 4;
            // 
            // formTur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridtur);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "formTur";
            this.Text = "formTur";
            this.Load += new System.EventHandler(this.formTur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridtur)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridtur;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtturadi;
    }
}