using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionGui
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        private void AbrirFormEnPanel(object Formhijo)
        {


            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;
            fh.Show();


        }
        private void button1_Click(object sender, EventArgs e)
        {
            ConsultarIES iES = new ConsultarIES();
            AbrirFormEnPanel(iES);
        }

        private void btnRegistroEstudiante_Click(object sender, EventArgs e)
        {
            FormRegistroEstudiante form = new FormRegistroEstudiante();
            AbrirFormEnPanel(form);
        }

        private void btnConsultaEstudiantefIL_Click(object sender, EventArgs e)
        {
            FormConsultaEstudiantesInscritos form = new FormConsultaEstudiantesInscritos();
            AbrirFormEnPanel(form);
        }
    }
}
