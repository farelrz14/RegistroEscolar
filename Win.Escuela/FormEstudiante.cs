﻿using BL.Escuela;
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
    public partial class FormEstudiante : Form
    {
        EstudiantesBL _estudiantes;

        public FormEstudiante()
        {
            InitializeComponent();

            _estudiantes = new EstudiantesBL();
            listaEstudiantesBindingSource.DataSource = _estudiantes.ObtenerEstudiantes();


        }

        private void comboBoxListClass_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
