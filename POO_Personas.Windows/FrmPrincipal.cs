using POO_Personas.Datos;
using POO_Personas.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace POO_Personas.Windows
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private List<Persona> lista;
        private int cantidad;
        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void SetearFilar(DataGridViewRow r, Persona persona)
        {
            r.DefaultCellStyle.BackColor = persona.Sexo == Sexo.Masculino ? Color.CadetBlue : Color.Pink;
            r.Cells[cmnDni.Index].Value = persona.DNI;
            r.Cells[cmnPersona.Index].Value = persona.ToString();
            r.Cells[cmnSexo.Index].Value = persona.Sexo;
            r.Cells[cmnFechaNacimiento.Index].Value = persona.FechaNacimiento.ToShortDateString();
            r.Cells[cmnLocalidad.Index].Value = persona.Localidad.ToString();
            r.Cells[cmnEdad.Index].Value = persona.GetEdad();
            r.Tag = persona;
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            FrmPersonasAE frm = new FrmPersonasAE();
            frm.Text = "Agregar Persona";
            DialogResult dr = frm.ShowDialog(this);
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            lista = RepositorioDePersonas.GetInstancia().GetLista();
            MostrarDatosGrilla();
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvDatos.SelectedRows[0];
                Persona persona = (Persona)r.Tag;
                DialogResult dr =
                    MessageBox.Show($"¿Desea dar de baja a {persona}?",
                        "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {

                    return;
                }
                RepositorioDePersonas.GetInstancia().Borrar(persona);
                dgvDatos.Rows.Remove(r);
                MessageBox.Show("Registro borrado", "Confirmar Baja", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvDatos.SelectedRows[0];
                Persona persona = (Persona)r.Tag;
                Persona personaCopia = (Persona)persona.Clone();
                FrmPersonasAE frm = new FrmPersonasAE();
                frm.Text = "Editar Persona";
                frm.SetPersona(personaCopia);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                personaCopia = frm.GetPersona();
                RepositorioDePersonas.GetInstancia().Editar(personaCopia);
                SetearFilar(r, personaCopia);
                MessageBox.Show("Registro editado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }


        private void CargarDatosCombo()
        {
            var listaEnum = Enum.GetValues(typeof(Localidad)).Cast<Localidad>().ToList();
            
            foreach (var item in listaEnum)
            {
                this.tscboLocalidades.Items.Add(item);
            }
        }

        private void MostrarDatosGrilla()
        {
            dgvDatos.Rows.Clear();
            foreach (var item in lista)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgvDatos);
                SetearFilar(r, item);
                AgregarFila(r);
            }
        }

        private void comienzanConToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmComienzaCon frm = new FrmComienzaCon();
            frm.Text = "Ingrese caracteres de búsqueda";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                var texto = frm.GetTexto();
                if (texto.Length==0)
                {
                    return;
                }

                Func<Persona, bool> predicado = p => p.Apellido.StartsWith(texto);
                //lista = RepositorioDePersonas.GetInstancia().GetListaFiltradaComienza(texto);
                lista = RepositorioDePersonas.GetInstancia().GetListaFiltrada(predicado);
                MostrarDatosGrilla();
            }
        }

        private void masculinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Func<Persona, bool> predicado = p => p.Sexo == Sexo.Masculino;
            lista = RepositorioDePersonas.GetInstancia().GetListaFiltrada(predicado);
            //lista = RepositorioDePersonas.GetInstancia().GetListaFiltradaPorSexo(Sexo.Masculino);
            MostrarDatosGrilla();
            
        }

        private void femeninoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Func<Persona, bool> predicado = p => p.Sexo == Sexo.Femenino;
            lista = RepositorioDePersonas.GetInstancia().GetListaFiltrada(predicado);

            //lista = RepositorioDePersonas.GetInstancia().GetListaFiltradaPorSexo(Sexo.Femenino);
            MostrarDatosGrilla();

        }

        private void tsbRefrescar_Click(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void tscboLocalidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tscboLocalidades.SelectedIndex>=0)
            {
                var index = tscboLocalidades.SelectedIndex;
                Func<Persona, bool> predicado = p => p.Localidad == (Localidad)index;
                lista = RepositorioDePersonas.GetInstancia().GetListaFiltrada(predicado);

                //lista = RepositorioDePersonas.GetInstancia()
                //    .GetListaFiltradaPorLocalidad((Localidad)index);
                MostrarDatosGrilla();

            }            
        }

        private void aZToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            CargarDatosCombo();
            cantidad = RepositorioDePersonas.GetInstancia().GetCantidad();
            if (cantidad > 0)
            {
                RecargarGrilla();
            }

        }

    }
}
