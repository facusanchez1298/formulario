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
    public partial class Form2 : Form
    {
        private List<Persona> personas {get; set;}
        public Form2(List<Persona> personas)
        {
            this.personas = personas;
            InitializeComponent();
            cargarTabla(personas);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
                      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarTabla(personas);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargarTablaBusqueda();
        }  


        public void cargarTabla(List<Persona> personas)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("nombre", typeof(String));
            dataTable.Columns.Add("apellido", typeof(String));
            dataTable.Columns.Add("sexo", typeof(String));

            for (int i = 0; i < personas.Count; i++)
            {
                string nombre = personas.ElementAt(i).nombre;
                string apellido = personas.ElementAt(i).apellido;
                string sexo = personas.ElementAt(i).sexo;
                dataTable.Rows.Add(nombre, apellido, sexo);
            }



            dataGridView1.DataSource = dataTable;
        }

        public void cargarTablaBusqueda()
        {
            List<Persona> personaBusqueda = new List<Persona>();

            var lista = from item in personas
                        select item;

            if (textNombre.Text != "")
            {
              lista = from item in lista
                         where item.nombre == textNombre.Text
                         select item;
            }

            if (textApellido.Text != "")
            {
                 lista = from item in lista
                            where item.apellido == textApellido.Text
                            select item;
            }

            if (radioVaron.Checked)
            {
                 lista = from item in lista
                         where item.sexo == radioVaron.Text
                         select item;
            }

            if (radioMujer.Checked)
            {
                lista = from item in lista
                        where item.sexo == radioMujer.Text
                        select item;
            }

            if (radioNoBinario.Checked)
            {
                lista = from item in lista
                        where item.sexo == radioNoBinario.Text
                        select item;
            }


            foreach (Persona persona in lista)
            {
                personaBusqueda.Add(persona);
            }

            cargarTabla(personaBusqueda);

        }

     
    }
}
