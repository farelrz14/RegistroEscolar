using BL.Escuela;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Escuela
{
    public partial class FormEstudiante : Form
    {
        EstudiantesBL _estudiantes;
        GradosBL _gradosBL;

        public FormEstudiante()
        {
            InitializeComponent();

            _estudiantes = new EstudiantesBL();
            listaEstudiantesBindingSource.DataSource = _estudiantes.ObtenerEstudiantes();

            _gradosBL = new GradosBL();
            listaGradosBindingSource.DataSource = _gradosBL.ObtenerGrados();
        }

        private void listaEstudiantesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaEstudiantesBindingSource.EndEdit();
            var estudiante = (Estudiante) listaEstudiantesBindingSource.Current;

            if (fotoPictureBox.Image != null)
            {
                estudiante.Foto = Program.imageToByteArray(fotoPictureBox.Image);
            }
            else
            {
                estudiante.Foto = null;
            }

            var resultado = _estudiantes.GuardarEstudiante(estudiante);

            if (resultado.Exitoso == true)
            {
                listaEstudiantesBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Estudiante Guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _estudiantes.AgregarEstudiante();
            listaEstudiantesBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea eliminar este Estudiante?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }
            }
        }

        private void Eliminar(int id)
        {
            var resultado = _estudiantes.EliminarEstudiante(id);

            if (resultado == true)
            {
                listaEstudiantesBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar al estudiante");
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            _estudiantes.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var estudiante = (Estudiante)listaEstudiantesBindingSource.Current;

            if (estudiante != null)
            {
                openFileDialog1.ShowDialog();
                var archivo = openFileDialog1.FileName;

                if (archivo != "")
                {
                    var fileInfo = new FileInfo(archivo);
                    var fileStream = fileInfo.OpenRead();

                    fotoPictureBox.Image = Image.FromStream(fileStream);
                }
            }
            else
            {
                MessageBox.Show("Cree un registro antes de agregar una fotografia");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fotoPictureBox.Image = null;
        }

        private void listaEstudiantesBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
