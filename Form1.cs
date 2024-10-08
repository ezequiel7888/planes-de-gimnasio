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
   
            lista = Convert.ToString(txtbox1.Text);

            //agregamos lo que tenga la variable valor al listbox

            listbx1.Items.Add(lista);

            //limpiar el cuadro de texto y darle el enfoque
            txtbox1.Text = "";
            txtbox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //declarar una variable tipo entero
            string valor;
            int valor1;
            valor1 = Convert.ToInt32(txtbox1.Text); //lo que ingresamos al cuadro de texto sera el indice
            if (valor1 > listbx1.Items.Count - 1)
            {
                MessageBox.Show("el valor ingresado esta fuera del indice");
                txtbox1.Text = "";
                txtbox1.Focus();

            }
            else
            {
                valor = listbx1.Items[valor1].ToString();
                //MessageBox.Show("el plan elegido es:" + valor);
                label3.Text = valor;
            }


        }

        private void listbox1_MouseClick(object sender, MouseEventArgs e)
        {
            //me muestra el contenido del listbox que yo seleccione
            txtbox1.Text = listbx1.SelectedItem.ToString();
            //me muestra el indice del contenido seleccionado en el listbox
            label3.Text = listbx1.SelectedIndex.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //declaramos las variables 
            string listaejercicios;

            //asignar a la variable valor lo que ingresemos en el cuadro de texto

            listaejercicios = Convert.ToString(txtbox2.Text);

            //agregamos lo que tenga la variable valor al listbox

            listbx2.Items.Add(listaejercicios);

            //limpiar el cuadro de texto y darle el enfoque
            txtbox2.Text = "";
            txtbox2.Focus();



        }

        private void button4_Click(object sender, EventArgs e)
        {
            //declarar una variable tipo entero
            string valor;
            int valor2;
            valor2 = Convert.ToInt32(txtbox2.Text); //lo que ingresamos al cuadro de texto sera el indice
            if (valor2 > listbx2.Items.Count - 1)
            {
                MessageBox.Show("el valor ingresado esta fuera del indice");
                txtbox2.Text = "";
                txtbox2.Focus();
            }
            else
            {
                valor = listbx2.Items[valor2].ToString();
                //MessageBox.Show("el plan elegido es:" + valor);
                label5.Text = valor;




            }
        }

        private void listBox2_MouseClick(object sender, MouseEventArgs e)
        {
            //me muestra el contenido del listbox que yo seleccione
            txtbox2.Text = listbx2.SelectedItem.ToString();
            //me muestra el indice del contenido seleccionado en el listbox
            label6.Text = listbx2.SelectedIndex.ToString();



        }

        private void button5_Click(object sender, EventArgs e)
        {
            //me muestra un mensaje del evento de clic del boton aceptar indicando las cantidades de planes agregadas al listbox
            MessageBox.Show("usted eligio un total de :" + listbx1.Items.Add(txtbox1));
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //me muestra un mensaje del evento de clic del boton indicando las cantidades de ejercicios agregados al listbox 
            MessageBox.Show("usted eligio un total de:" + listbx2.Items.Add(txtbox2));


            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //declaramos la variable
            int valor;
            valor = Convert.ToInt32(txtbox3.Text);
            //generar nuestro ciclo for i = i +3
            for (int i = 0; i < valor; i++)
            {
                txtbox4.Text += i.ToString() + "\r\n";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //declaramos la variable
            int valor;
            valor = Convert.ToInt32(txtbox5.Text);
            //generar nuestro ciclo for i = i +3
            for (int i = 0; i < valor; i++)
            {
                txtbox6.Text += i.ToString() + "\r\n";
            }
        }
    }
 }
