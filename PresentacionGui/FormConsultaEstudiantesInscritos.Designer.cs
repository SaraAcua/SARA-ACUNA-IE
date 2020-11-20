
namespace PresentacionGui
{
    partial class FormConsultaEstudiantesInscritos
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
            this.lblConteo = new System.Windows.Forms.Label();
            this.lblConteocuposdisponibles = new System.Windows.Forms.Label();
            this.dataGVEs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmboIes = new System.Windows.Forms.ComboBox();
            this.btnConsultarEs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVEs)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConteo
            // 
            this.lblConteo.AutoSize = true;
            this.lblConteo.Location = new System.Drawing.Point(259, 300);
            this.lblConteo.Name = "lblConteo";
            this.lblConteo.Size = new System.Drawing.Size(103, 13);
            this.lblConteo.TabIndex = 11;
            this.lblConteo.Text = "Estudiantes inscritos";
            // 
            // lblConteocuposdisponibles
            // 
            this.lblConteocuposdisponibles.AutoSize = true;
            this.lblConteocuposdisponibles.Location = new System.Drawing.Point(369, 300);
            this.lblConteocuposdisponibles.Name = "lblConteocuposdisponibles";
            this.lblConteocuposdisponibles.Size = new System.Drawing.Size(19, 13);
            this.lblConteocuposdisponibles.TabIndex = 10;
            this.lblConteocuposdisponibles.Text = "----";
            // 
            // dataGVEs
            // 
            this.dataGVEs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVEs.Location = new System.Drawing.Point(41, 153);
            this.dataGVEs.Name = "dataGVEs";
            this.dataGVEs.Size = new System.Drawing.Size(487, 113);
            this.dataGVEs.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Consulta Estudiantes Inscritos";
            // 
            // cmboIes
            // 
            this.cmboIes.FormattingEnabled = true;
            this.cmboIes.Location = new System.Drawing.Point(64, 87);
            this.cmboIes.Name = "cmboIes";
            this.cmboIes.Size = new System.Drawing.Size(154, 21);
            this.cmboIes.TabIndex = 7;
            // 
            // btnConsultarEs
            // 
            this.btnConsultarEs.Location = new System.Drawing.Point(252, 85);
            this.btnConsultarEs.Name = "btnConsultarEs";
            this.btnConsultarEs.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarEs.TabIndex = 6;
            this.btnConsultarEs.Text = "Consultar";
            this.btnConsultarEs.UseVisualStyleBackColor = true;
            this.btnConsultarEs.Click += new System.EventHandler(this.btnConsultarEs_Click);
            // 
            // FormConsultaEstudiantesInscritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(568, 380);
            this.Controls.Add(this.lblConteo);
            this.Controls.Add(this.lblConteocuposdisponibles);
            this.Controls.Add(this.dataGVEs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmboIes);
            this.Controls.Add(this.btnConsultarEs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConsultaEstudiantesInscritos";
            this.Text = "FormConsultaEstudiantesInscritos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGVEs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConteo;
        private System.Windows.Forms.Label lblConteocuposdisponibles;
        private System.Windows.Forms.DataGridView dataGVEs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmboIes;
        private System.Windows.Forms.Button btnConsultarEs;
    }
}