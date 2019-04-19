using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Persona> personas = new List<Persona>();

        public Form1()
        {
            InitializeComponent();
        }    

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonGuardar1_Click(object sender, EventArgs e)
        {
            if (!hayCamposVacios())
            {
                personas.Add(new Persona(this.txtNombre.Text, this.txtApellido.Text, this.radioButtonActivo().Text));
                this.labelResultado.Text = "guardado";
                vaciarCampos();//limpia los campos
            }
            
          
        }

        private bool hayCamposVacios()
        {
            if (this.txtApellido.Text.Any() || this.txtNombre.Text.Any())
            {
                return false;
            }
            return true;
        }

        private RadioButton radioButtonActivo()
        {
            if (radioButtomVaron.Checked) return this.radioButtomVaron;
            if (radioButtonMujer.Checked) return this.radioButtonMujer;
            return this.radioButtonNoBinario;
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            Form2 vista = new Form2(personas);
            vista.Show();
        }

        public void vaciarCampos()
        {
            this.txtApellido.Text = "";
            this.txtNombre.Text = "";
        }
    }
}
