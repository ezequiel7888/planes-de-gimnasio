using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace planes_de_gimnasio
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declaramos las variables
            string lista;
            
            //asignar a la variable valor lo que ingresemos en el cuadro de texto
   
            lista = Convert.ToString(textBox1.Text);

            //agregamos lo que tenga la variable valor al listbox

            listbox1.Items.Add(lista);

            //limpiar el cuadro de texto y darle el enfoque
            textBox1.Text = "";
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //declarar una variable tipo entero
            string valor;
            int valor1;
            valor1 = Convert.ToInt32(textBox1.Text); //lo que ingresamos al cuadro de texto sera el indice
            if (valor1 > listbox1.Items.Count - 1)
            {
                MessageBox.Show("el valor ingresado esta fuera del indice");
                textBox1.Text = "";
                textBox1.Focus();

            }
            else
            {
                valor = listbox1.Items[valor1].ToString();
                //MessageBox.Show("el plan elegido es:" + valor);
                label3.Text = valor;
            }


        }

        private void listbox1_MouseClick(object sender, MouseEventArgs e)
        {
            //me muestra el contenido del listbox que yo seleccione
            textBox1.Text = listbox1.SelectedItem.ToString();
            //me muestra el indice del contenido seleccionado en el listbox
            label3.Text = listbox1.SelectedIndex.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //declaramos las variables 
            string listaejercicios;

            //asignar a la variable valor lo que ingresemos en el cuadro de texto

            listaejercicios = Convert.ToString(textBox2.Text);

            //agregamos lo que tenga la variable valor al listbox

            listBox2.Items.Add(listaejercicios);

            //limpiar el cuadro de texto y darle el enfoque
            textBox2.Text = "";
            textBox2.Focus();



        }

        private void button4_Click(object sender, EventArgs e)
        {
            //declarar una variable tipo entero
            string valor;
            int valor2;
            valor2 = Convert.ToInt32(textBox2.Text); //lo que ingresamos al cuadro de texto sera el indice
            if (valor2 > listBox2.Items.Count - 1)
            {
                MessageBox.Show("el valor ingresado esta fuera del indice");
                textBox2.Text = "";
                textBox2.Focus();
            }
            else
            {
                valor = listBox2.Items[valor2].ToString();
                //MessageBox.Show("el plan elegido es:" + valor);
                label5.Text = valor;




            }
        }

        private void listBox2_MouseClick(object sender, MouseEventArgs e)
        {
            //me muestra el contenido del listbox que yo seleccione
            textBox2.Text = listBox2.SelectedItem.ToString();
            //me muestra el indice del contenido seleccionado en el listbox
            label6.Text = listBox2.SelectedIndex.ToString();



        }

        private void button5_Click(object sender, EventArgs e)
        {
            //me muestra un mensaje del evento de clic del boton aceptar indicando las cantidades de planes agregadas al listbox
            MessageBox.Show("usted eligio un total de :" + listbox1.Items.Add(textBox1));
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //me muestra un mensaje del evento de clic del boton indicando las cantidades de ejercicios agregados al listbox 
            MessageBox.Show("usted eligio un total de:" + listBox2.Items.Add(textBox2));


            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //declaramos la variable
            int valor;
            valor = Convert.ToInt32(textBox4.Text);
            //generar nuestro ciclo for i = i +3
            for (int i = 0; i < valor; i++)
            {
                textBox3.Text += i.ToString() + "\r\n";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //declaramos la variable
            int valor;
            valor = Convert.ToInt32(textBox5.Text);
            //generar nuestro ciclo for i = i +3
            for (int i = 0; i < valor; i++)
            {
                textBox6.Text += i.ToString() + "\r\n";
            }
        }
    }
 }
