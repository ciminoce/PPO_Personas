using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POO_Personas.Datos;
using POO_Personas.Entidades;
using POO_Personas.Windows.Classes;

namespace POO_Personas.Windows
{
    public partial class FrmPersonasAE : Form
    {
        public FrmPersonasAE()
        {
            InitializeComponent();
        }
        private Persona persona;
        private bool esEdicion = false;
        protected override void OnLoad(EventArgs e)
        {
            LocalidadesComboBox.DataSource = Enum.GetValues(typeof(Localidad));
            base.OnLoad(e);
            if (persona != null)
            {
                esEdicion = true;
                DNITextBox.Enabled = false;
                DNITextBox.Text = persona.DNI.ToString();
                ApellidoTextBox.Text = persona.Apellido;
                PrimerNombreTextBox.Text = persona.PrimerNombre;
                SegundoNombreTextBox.Text = persona.SegundoNombre;
                LocalidadesComboBox.SelectedItem = persona.Localidad;
                FechaDateTimePicker.Value = persona.FechaNacimiento;
                MasculinoRadioButton.Checked = persona.Sexo == Sexo.Masculino ? true : false;
            }
        }
        public Persona GetPersona()
        {
            return persona;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                try
                {
                    if (persona == null)
                    {
                        persona = new Persona();
                    }

                    persona.DNI = int.Parse(DNITextBox.Text);
                    persona.Apellido = ApellidoTextBox.Text;
                    persona.PrimerNombre = PrimerNombreTextBox.Text;
                    persona.SegundoNombre = SegundoNombreTextBox.Text;
                    persona.Sexo = MasculinoRadioButton.Checked ? Sexo.Masculino : Sexo.Femenino;
                    persona.FechaNacimiento = FechaDateTimePicker.Value.Date;
                    persona.Localidad = (Localidad) LocalidadesComboBox.SelectedItem;
                    if (esEdicion)
                    {
                        DialogResult = DialogResult.OK;
                        return;
                    }
                    if (RepositorioDePersonas.GetInstancia().ExisteObjeto(persona))
                    {
                        errorProvider1.SetError(DNITextBox,"Persona repetida!!!");
                        return;
                    }
                    RepositorioDePersonas.GetInstancia().Agregar(persona);
                    DialogResult dr2 = MessageBox.Show("Persona Agregada..." + Environment.NewLine +
                                                       "¿Agrega otra?", "Pregunta",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (dr2==DialogResult.No)
                    {
                        DialogResult = DialogResult.OK;
                        return;
                    }

                    persona = null;
                    InicializarControles();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void InicializarControles()
        {
            DNITextBox.Clear();
            ApellidoTextBox.Clear();
            PrimerNombreTextBox.Clear();
            SegundoNombreTextBox.Clear();
            MasculinoRadioButton.Checked = true;
            LocalidadesComboBox.SelectedIndex = 0;
            FechaDateTimePicker.Value=DateTime.Today;
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (FechaDateTimePicker.Value > DateTime.Now)
            {
                valido = false;
                errorProvider1.SetError(FechaDateTimePicker, "Fecha mayor a la fecha actual");
            }
            return valido;
        }

        public void SetPersona(Persona persona)
        {
            this.persona = persona;
        }

        private void DNITextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
            Helper.SoloNumeros(e);
        }

        private void ApellidoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
            Helper.SoloTexto(e);
        }

        private void PrimerNombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
            Helper.SoloTexto(e);
        }

        private void SegundoNombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
            Helper.SoloTexto(e);

        }
    }
}
