using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Frm_Calculador : Form
    {
        public Frm_Calculador()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.txt_kilometros.Text == "" || this.txt_litros.Text == "")
                {
                    throw new ParametrosVaciosException("Alguno de los campos está vacío");
                }

                this.rtb_Calculador.Text = $"km/hr : {Calculador.Calcular(int.Parse(this.txt_kilometros.Text), int.Parse(this.txt_litros.Text)) } ";


            }
            catch (ParametrosVaciosException ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(DivideByZeroException)
            {
                MessageBox.Show("No se puede dividir por 0");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
