using Bll;
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
    public partial class FormConsultaEstudiantesInscritos : Form
    {

        InstitucionService service = new InstitucionService();
        public FormConsultaEstudiantesInscritos()
        {
            InitializeComponent();
            cmboIes.Items.Add("IE NACIONAL LOPERENA");
            cmboIes.Items.Add("PUDENCIA DAZA");
            cmboIes.Items.Add("SAN JOAQUIN");
            cmboIes.Items.Add("FRANCISCO MOLINA SANCHEZ");
            cmboIes.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnConsultarEs_Click(object sender, EventArgs e)
        {

            FiltroTipo();
            ContarEs();
        }
        private void FiltroTipo()
        {
            var response = service.ConsultarEs();
            if (response.ErrorEs==false)
            {
                dataGVEs.DataSource = response.Estudiantes;
            }
            else
            {
                MessageBox.Show(response.MessageEs);
            }
        }
        private void ContarEs()
        {
            int total = 0;
            try
            {


                foreach (DataGridViewRow row in dataGVEs.Rows)
                {
                    total += Convert.ToInt32(row.Cells["Nombre"].Value);
                    service.ContarEs(total);
                    if (total != 0)
                    {
                        lblConteocuposdisponibles.Text = Convert.ToString(total);
                    }
                    else
                    {
                        lblConteocuposdisponibles.Text = "0";
                    }
                }
            }
            catch
            {

            }
            }
        }
    }

