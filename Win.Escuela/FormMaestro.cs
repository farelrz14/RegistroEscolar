using BL.Escuela;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Escuela
{
    public partial class FormMaestro : Form
    {
        MaestrosBL _maestros;

        public FormMaestro()
        {
            InitializeComponent();

            _maestros = new MaestrosBL();
            maestroBindingSource.DataSource = _maestros.ObtenerMaestros();
        }

        private void maestroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            maestroBindingSource.EndEdit();
            var maestro = (Maestro)maestroBindingSource.Current;



            var resultado = _maestros.GuardarMaestro(maestro);

            if (resultado.Exitoso == true)
            {
                maestroBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Catedratico Guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _maestros.AgregarMaestro();
            maestroBindingSource.MoveLast();

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
                var resultado = MessageBox.Show("Desea eliminar este Catedratico?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }
            }
        }

        private void Eliminar(int id)
        {
            var resultado = _maestros.EliminarMaestro(id);

            if (resultado == true)
            {
                maestroBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar al Catedratico");
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            _maestros.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
            
        }
    }
}
