
namespace KutuphaneProjesi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnkitap = new System.Windows.Forms.Button();
            this.btnogrenci = new System.Windows.Forms.Button();
            this.btntur = new System.Windows.Forms.Button();
            this.btnodunc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnkitap
            // 
            this.btnkitap.Image = ((System.Drawing.Image)(resources.GetObject("btnkitap.Image")));
            this.btnkitap.Location = new System.Drawing.Point(62, 49);
            this.btnkitap.Name = "btnkitap";
            this.btnkitap.Size = new System.Drawing.Size(170, 75);
            this.btnkitap.TabIndex = 0;
            this.btnkitap.Text = "kitap işlemleri ";
            this.btnkitap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnkitap.UseVisualStyleBackColor = true;
            this.btnkitap.Click += new System.EventHandler(this.btnkitap_Click);
            // 
            // btnogrenci
            // 
            this.btnogrenci.Image = ((System.Drawing.Image)(resources.GetObject("btnogrenci.Image")));
            this.btnogrenci.Location = new System.Drawing.Point(262, 49);
            this.btnogrenci.Name = "btnogrenci";
            this.btnogrenci.Size = new System.Drawing.Size(170, 75);
            this.btnogrenci.TabIndex = 1;
            this.btnogrenci.Text = "ögrenci işlemleri";
            this.btnogrenci.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnogrenci.UseVisualStyleBackColor = true;
            this.btnogrenci.Click += new System.EventHandler(this.btnogrenci_Click);
            // 
            // btntur
            // 
            this.btntur.Image = ((System.Drawing.Image)(resources.GetObject("btntur.Image")));
            this.btntur.Location = new System.Drawing.Point(62, 165);
            this.btntur.Name = "btntur";
            this.btntur.Size = new System.Drawing.Size(170, 75);
            this.btntur.TabIndex = 2;
            this.btntur.Text = "tür işlemleri";
            this.btntur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btntur.UseVisualStyleBackColor = true;
            this.btntur.Click += new System.EventHandler(this.btntur_Click);
            // 
            // btnodunc
            // 
            this.btnodunc.Image = ((System.Drawing.Image)(resources.GetObject("btnodunc.Image")));
            this.btnodunc.Location = new System.Drawing.Point(262, 165);
            this.btnodunc.Name = "btnodunc";
            this.btnodunc.Size = new System.Drawing.Size(170, 75);
            this.btnodunc.TabIndex = 3;
            this.btnodunc.Text = "ödünç kitap işlemleri";
            this.btnodunc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnodunc.UseVisualStyleBackColor = true;
            this.btnodunc.Click += new System.EventHandler(this.btnodunc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnodunc);
            this.Controls.Add(this.btntur);
            this.Controls.Add(this.btnogrenci);
            this.Controls.Add(this.btnkitap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnkitap;
        private System.Windows.Forms.Button btnogrenci;
        private System.Windows.Forms.Button btntur;
        private System.Windows.Forms.Button btnodunc;
    }
}

