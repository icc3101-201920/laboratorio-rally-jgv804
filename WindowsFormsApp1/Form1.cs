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


        public Form1()
        {
            InitializeComponent();
            this.RolComboBox.DataSource = Enum.GetValues(typeof(Rol));
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
    }
}
