
namespace PresentacionGui
{
    partial class ConsultarIES
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
            this.btnConsultarIes = new System.Windows.Forms.Button();
            this.cmboIes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGVIes = new System.Windows.Forms.DataGridView();
            this.lblConteocuposdisponibles = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVIes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultarIes
            // 
            this.btnConsultarIes.Location = new System.Drawing.Point(184, 69);
            this.btnConsultarIes.Name = "btnConsultarIes";
            this.btnConsultarIes.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarIes.TabIndex = 0;
            this.btnConsultarIes.Text = "Consultar";
            this.btnConsultarIes.UseVisualStyleBackColor = true;
            this.btnConsultarIes.Click += new System.EventHandler(this.btnConsultarIes_Click);
            // 
            // cmboIes
            // 
            this.cmboIes.FormattingEnabled = true;
            this.cmboIes.Location = new System.Drawing.Point(57, 71);
            this.cmboIes.Name = "cmboIes";
            this.cmboIes.Size = new System.Drawing.Size(121, 21);
            this.cmboIes.TabIndex = 1;
            this.cmboIes.SelectedIndexChanged += new System.EventHandler(this.cmboIes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consulta IES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGVIes
            // 
            this.dataGVIes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVIes.Location = new System.Drawing.Point(34, 137);
            this.dataGVIes.Name = "dataGVIes";
            this.dataGVIes.Size = new System.Drawing.Size(487, 113);
            this.dataGVIes.TabIndex = 3;
            this.dataGVIes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVIes_CellContentClick);
            // 
            // lblConteocuposdisponibles
            // 
            this.lblConteocuposdisponibles.AutoSize = true;
            this.lblConteocuposdisponibles.Location = new System.Drawing.Point(362, 284);
            this.lblConteocuposdisponibles.Name = "lblConteocuposdisponibles";
            this.lblConteocuposdisponibles.Size = new System.Drawing.Size(19, 13);
            this.lblConteocuposdisponibles.TabIndex = 4;
            this.lblConteocuposdisponibles.Text = "----";
            this.lblConteocuposdisponibles.Click += new System.EventHandler(this.lblConteocuposdisponibles_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cupos disponibles";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ConsultarIES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(568, 380);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblConteocuposdisponibles);
            this.Controls.Add(this.dataGVIes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmboIes);
            this.Controls.Add(this.btnConsultarIes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarIES";
            this.Text = "ConsultarIES";
            ((System.ComponentModel.ISupportInitialize)(this.dataGVIes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultarIes;
        private System.Windows.Forms.ComboBox cmboIes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGVIes;
        private System.Windows.Forms.Label lblConteocuposdisponibles;
        private System.Windows.Forms.Label label2;
    }
}