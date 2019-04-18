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

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("nombre");
            dataTable.Columns.Add("apellido");
            dataTable.Columns.Add("sexo");


            foreach (var item in personas)
                {
                DataRow dataRow = dataTable.NewRow();
                dataRow["nombre"] = item.nombre;
                dataRow["apellido"] = item.apellido;
                dataRow["sexo"] = item.sexo;
                }

            dataGridView1.DataSource = dataTable;

            
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
