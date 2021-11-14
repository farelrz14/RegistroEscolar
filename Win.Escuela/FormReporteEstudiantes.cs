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
    public partial class FormReporteEstudiantes : Form
    {
        public FormReporteEstudiantes()
        {
            InitializeComponent();

            var _estudiantesBL = new EstudiantesBL();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _estudiantesBL.ObtenerEstudiantes();

            var reporte = new ReporteEstudiantes();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
