using ModelosRally;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace VistasRally
{
    public partial class Form1 : Form
    {
        public event EventHandler<AgregarPilotoEventArgs> OnAgregarPiloto;
        public event EventHandler<AgregarNaveganteEventArgs> OnAgregarNavegante;
        public event EventHandler<AgregarEquipoEventArgs> OnAgregarEquipo;
        public static int counter = 1;


        public Form1()
        {
            InitializeComponent();
            List<Vehiculo> listaV = new List<Vehiculo>();
            Vehiculo auto1 = new Vehiculo("Hyundai",1400);
            Vehiculo auto2 = new Vehiculo("Redbull",1600);
            Vehiculo auto3 = new Vehiculo("Volkswagen",2000);
            listaV.Add(auto1);
            listaV.Add(auto2);
            listaV.Add(auto3);

            this.RolComboBox.DataSource = Enum.GetValues(typeof(Rol));
            this.comboBox3.DataSource = listaV;
        }

        private void AgregarPilotoButton_Click(object sender, EventArgs e)
        {
            if (OnAgregarPiloto != null)
            {
                AgregarPilotoEventArgs pilotoArgs = new AgregarPilotoEventArgs();
                pilotoArgs.nombre = this.NameTextBox.Text;
                OnAgregarPiloto(this, pilotoArgs);
            }
               
        }

        public void ActualizarListadoPilotos(Persona pilotoNuevo)
        {
            PilotNameComboBox.Items.Add(pilotoNuevo);
        }
        public void ActualizarAsignarPilotos(Persona pilotoNuevo)
        {
            comboBox1.Items.Add(pilotoNuevo);
        }
        public void ActualizarAsignarNavegantes(Persona pilotoNuevo)
        {
            comboBox2.Items.Add(pilotoNuevo);
        }
        public void ActualizarListadoEquipos(Equipo pilotoNuevo)
        {
            comboBox4.Items.Add(pilotoNuevo);
        }
        public bool isChecked(CheckBox checkbox)
        {
            if (checkbox.CheckState == CheckState.Checked) return true;
            else return false;
        }





        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RolComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string texto = RolComboBox.SelectedItem.ToString();
            //label4.Text = texto;//
            if (texto == "Piloto")
            {
                panel1.Visible = true;
                panel2.Visible = false;

            }
            else
            {
                panel2.Visible = true;
                panel1.Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OnAgregarNavegante != null)
            {
                AgregarNaveganteEventArgs NaveganteArgs = new AgregarNaveganteEventArgs();
                NaveganteArgs.nombre = this.NameTextBox.Text;
                OnAgregarNavegante(this, NaveganteArgs);
            }

        }

        private void PilotNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            /*if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true)
            {
                button3.Visible = true;
               

            }
            else
            {
                button3.Visible = false;
            }
            */
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
            
            if (OnAgregarEquipo != null)
            {

                AgregarEquipoEventArgs EquipoArgs = new AgregarEquipoEventArgs();
                EquipoArgs.nombre = "equipo " + counter.ToString();
                EquipoArgs.piloto = comboBox1.SelectedItem as Persona;
                EquipoArgs.navegante = comboBox2.SelectedItem as Persona;
                EquipoArgs.vehiculo = comboBox3.SelectedItem as Vehiculo;
                OnAgregarEquipo(this, EquipoArgs);
                counter += 1;
            }

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            panel3.Visible = false;

            button3.Visible = false;


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
        private void CheckBox1_CheckedChanged(Object sender, EventArgs e)
        {

            /*//MessageBox.Show("hola");//
            if (isChecked(checkBox1) && isChecked(checkBox2) && isChecked(checkBox3))
            {
                //MessageBox.Show("chao");//
                button3.Visible = true;


            }
            else
            {
                //MessageBox.Show("chao 2");//
                button3.Visible = false;
            }

            //MessageBox.Show("You are in the CheckBox.CheckedChanged event.");//
            */
        }
        private void CheckBox2_CheckedChanged(Object sender, EventArgs e)
        {

            //MessageBox.Show("hola");//
            /*
            if (isChecked(checkBox1) &&  isChecked(checkBox2) && isChecked(checkBox3))
            {
                //MessageBox.Show("chao");//
                button3.Visible = true;


            }
            else
            {
                //MessageBox.Show("chao2");//
                button3.Visible = false;
            }
            //MessageBox.Show("You are in the CheckBox.CheckedChanged event.");//
            */
        }
        private void CheckBox3_CheckedChanged(Object sender, EventArgs e)
        {

           /* MessageBox.Show("hola");
            if (isChecked(checkBox1) &&  isChecked(checkBox2) && isChecked(checkBox3))
            {
                MessageBox.Show("chao");
                button3.Visible = true;


            }
            else
            {
                MessageBox.Show("chao2");
                button3.Visible = false;
            }
            //MessageBox.Show("You are in the CheckBox.CheckedChanged event.");//
            */
        }

        private void CheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            //MessageBox.Show("hola");//

            if (isChecked(checkBox1) && isChecked(checkBox2) && isChecked(checkBox3))
            {
                //MessageBox.Show("chao");//
                button3.Visible = true;


            }
            else
            {
                //MessageBox.Show("chao2");//
                button3.Visible = false;
            }

        }

        private void CheckBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            //MessageBox.Show("hola");//

            if (isChecked(checkBox1) && isChecked(checkBox2) && isChecked(checkBox3))
            {
                //MessageBox.Show("chao");//
                button3.Visible = true;


            }
            else
            {
                //MessageBox.Show("chao2");//
                button3.Visible = false;
            }

        }

        private void CheckBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            //MessageBox.Show("hola");//

            if (isChecked(checkBox1) && isChecked(checkBox2) && isChecked(checkBox3))
            {
                //MessageBox.Show("chao");//
                button3.Visible = true;


            }
            else
            {
                //MessageBox.Show("chao2");//
                button3.Visible = false;
            }

        }
    }
}
