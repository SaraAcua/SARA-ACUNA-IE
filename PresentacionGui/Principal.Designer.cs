
namespace PresentacionGui
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.btnConsultaIES = new System.Windows.Forms.Button();
            this.btnRegistroEstudiante = new System.Windows.Forms.Button();
            this.btnConsultaEstudiantefIL = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 57);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Controls.Add(this.btnConsultaIES);
            this.flowLayoutPanel1.Controls.Add(this.btnRegistroEstudiante);
            this.flowLayoutPanel1.Controls.Add(this.btnConsultaEstudiantefIL);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 57);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 380);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(200, 57);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(568, 380);
            this.pnlContenedor.TabIndex = 2;
            // 
            // btnConsultaIES
            // 
            this.btnConsultaIES.Location = new System.Drawing.Point(3, 3);
            this.btnConsultaIES.Name = "btnConsultaIES";
            this.btnConsultaIES.Size = new System.Drawing.Size(191, 52);
            this.btnConsultaIES.TabIndex = 0;
            this.btnConsultaIES.Text = "Consultar IES ";
            this.btnConsultaIES.UseVisualStyleBackColor = true;
            this.btnConsultaIES.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegistroEstudiante
            // 
            this.btnRegistroEstudiante.Location = new System.Drawing.Point(3, 61);
            this.btnRegistroEstudiante.Name = "btnRegistroEstudiante";
            this.btnRegistroEstudiante.Size = new System.Drawing.Size(191, 59);
            this.btnRegistroEstudiante.TabIndex = 1;
            this.btnRegistroEstudiante.Text = "Registrar Estudiante";
            this.btnRegistroEstudiante.UseVisualStyleBackColor = true;
            // 
            // btnConsultaEstudiantefIL
            // 
            this.btnConsultaEstudiantefIL.Location = new System.Drawing.Point(3, 126);
            this.btnConsultaEstudiantefIL.Name = "btnConsultaEstudiantefIL";
            this.btnConsultaEstudiantefIL.Size = new System.Drawing.Size(191, 66);
            this.btnConsultaEstudiantefIL.TabIndex = 2;
            this.btnConsultaEstudiantefIL.Text = "Consulta filtrada";
            this.btnConsultaEstudiantefIL.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 437);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Principal";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnConsultaIES;
        private System.Windows.Forms.Button btnRegistroEstudiante;
        private System.Windows.Forms.Button btnConsultaEstudiantefIL;
        private System.Windows.Forms.Panel pnlContenedor;
    }
}

