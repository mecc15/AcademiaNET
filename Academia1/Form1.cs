using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicadeNegocios;

namespace Academia1
{
    public partial class Form1 : Form
    {
        TransacAlumno obj = new TransacAlumno();
        String res="";  
        public Form1()
        {
            InitializeComponent();
            llenar();
        }
        void llenar()
        {
            dataGridView1.DataSource = obj.mostrar_Alumnos();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            res=obj.agregar_alumno(textBox2.Text, textBox3.Text, textBox4.Text, maskedTextBox1.Text);
            button2.Enabled = false;
            llenar();
            if(res=="1")
              MessageBox.Show("Registro Insertado Correctamente");
            else
              MessageBox.Show("Dato no insertado " + res);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            llenar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            maskedTextBox1.Clear();
            button2.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            res=obj.modificar_alumno(textBox1.Text,textBox2.Text, textBox3.Text, textBox4.Text, maskedTextBox1.Text);
            llenar();
            if (res == "1")
                MessageBox.Show("Registro Modificado Correctamente");
            else
                MessageBox.Show("Registro No Modificado " + res);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de Eliminar el registro", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                res = obj.eliminar_alumno(textBox1.Text);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                maskedTextBox1.Clear();
                llenar();
                if (res == "1")
                    MessageBox.Show("Registro Eliminado Correctamente");
                else
                    MessageBox.Show("Registro No Eliminado " + res);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource=obj.buscar_Alumnos(textBox6.Text);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            int v = Int32.Parse(textBox6.Text);
            Form2 ob = new Form2(v);
            ob.Show();
        }
    }
}
