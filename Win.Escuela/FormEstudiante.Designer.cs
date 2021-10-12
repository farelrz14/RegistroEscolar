namespace Win.Escuela
{
    partial class FormEstudiante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstudiante));
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label clasesLabel;
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.Label edadLabel;
            System.Windows.Forms.Label estMatriculadoLabel;
            System.Windows.Forms.Label gradoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label numeroCuentaLabel;
            System.Windows.Forms.Label telefonoLabel;
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.listaEstudiantesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.listaEstudiantesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.clasesTextBox = new System.Windows.Forms.TextBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.edadTextBox = new System.Windows.Forms.TextBox();
            this.estMatriculadoCheckBox = new System.Windows.Forms.CheckBox();
            this.gradoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.numeroCuentaTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxListClass = new System.Windows.Forms.ComboBox();
            this.listaEstudiantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            clasesLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            edadLabel = new System.Windows.Forms.Label();
            estMatriculadoLabel = new System.Windows.Forms.Label();
            gradoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            numeroCuentaLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaEstudiantesBindingNavigator)).BeginInit();
            this.listaEstudiantesBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaEstudiantesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 35);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 35);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(72, 38);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(76, 35);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 35);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 35);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 35);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 35);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // listaEstudiantesBindingNavigatorSaveItem
            // 
            this.listaEstudiantesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaEstudiantesBindingNavigatorSaveItem.Enabled = false;
            this.listaEstudiantesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaEstudiantesBindingNavigatorSaveItem.Image")));
            this.listaEstudiantesBindingNavigatorSaveItem.Name = "listaEstudiantesBindingNavigatorSaveItem";
            this.listaEstudiantesBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 35);
            this.listaEstudiantesBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // listaEstudiantesBindingNavigator
            // 
            this.listaEstudiantesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.listaEstudiantesBindingNavigator.BackColor = System.Drawing.Color.MediumAquamarine;
            this.listaEstudiantesBindingNavigator.BindingSource = this.listaEstudiantesBindingSource;
            this.listaEstudiantesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaEstudiantesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.listaEstudiantesBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaEstudiantesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.listaEstudiantesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.listaEstudiantesBindingNavigatorSaveItem});
            this.listaEstudiantesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaEstudiantesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaEstudiantesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaEstudiantesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaEstudiantesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaEstudiantesBindingNavigator.Name = "listaEstudiantesBindingNavigator";
            this.listaEstudiantesBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.listaEstudiantesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaEstudiantesBindingNavigator.Size = new System.Drawing.Size(764, 38);
            this.listaEstudiantesBindingNavigator.TabIndex = 0;
            this.listaEstudiantesBindingNavigator.Text = "bindingNavigator1";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(49, 197);
            apellidoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(88, 25);
            apellidoLabel.TabIndex = 1;
            apellidoLabel.Text = "Apellido:";
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEstudiantesBindingSource, "Apellido", true));
            this.apellidoTextBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.apellidoTextBox.Location = new System.Drawing.Point(226, 192);
            this.apellidoTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(317, 30);
            this.apellidoTextBox.TabIndex = 2;
            // 
            // clasesLabel
            // 
            clasesLabel.AutoSize = true;
            clasesLabel.Location = new System.Drawing.Point(49, 430);
            clasesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            clasesLabel.Name = "clasesLabel";
            clasesLabel.Size = new System.Drawing.Size(79, 25);
            clasesLabel.TabIndex = 3;
            clasesLabel.Text = "Clases:";
            // 
            // clasesTextBox
            // 
            this.clasesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEstudiantesBindingSource, "Clases", true));
            this.clasesTextBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.clasesTextBox.Location = new System.Drawing.Point(226, 425);
            this.clasesTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.clasesTextBox.Name = "clasesTextBox";
            this.clasesTextBox.Size = new System.Drawing.Size(164, 30);
            this.clasesTextBox.TabIndex = 4;
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Location = new System.Drawing.Point(49, 334);
            correoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(78, 25);
            correoLabel.TabIndex = 5;
            correoLabel.Text = "Correo:";
            // 
            // correoTextBox
            // 
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEstudiantesBindingSource, "Correo", true));
            this.correoTextBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.correoTextBox.Location = new System.Drawing.Point(226, 329);
            this.correoTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(317, 30);
            this.correoTextBox.TabIndex = 6;
            // 
            // edadLabel
            // 
            edadLabel.AutoSize = true;
            edadLabel.Location = new System.Drawing.Point(49, 244);
            edadLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            edadLabel.Name = "edadLabel";
            edadLabel.Size = new System.Drawing.Size(64, 25);
            edadLabel.TabIndex = 7;
            edadLabel.Text = "Edad:";
            // 
            // edadTextBox
            // 
            this.edadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEstudiantesBindingSource, "Edad", true));
            this.edadTextBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.edadTextBox.Location = new System.Drawing.Point(226, 239);
            this.edadTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.edadTextBox.Name = "edadTextBox";
            this.edadTextBox.Size = new System.Drawing.Size(40, 30);
            this.edadTextBox.TabIndex = 8;
            // 
            // estMatriculadoLabel
            // 
            estMatriculadoLabel.AutoSize = true;
            estMatriculadoLabel.Location = new System.Drawing.Point(49, 469);
            estMatriculadoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            estMatriculadoLabel.Name = "estMatriculadoLabel";
            estMatriculadoLabel.Size = new System.Drawing.Size(119, 25);
            estMatriculadoLabel.TabIndex = 9;
            estMatriculadoLabel.Text = "Matriculado:";
            // 
            // estMatriculadoCheckBox
            // 
            this.estMatriculadoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaEstudiantesBindingSource, "estMatriculado", true));
            this.estMatriculadoCheckBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.estMatriculadoCheckBox.Location = new System.Drawing.Point(226, 470);
            this.estMatriculadoCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.estMatriculadoCheckBox.Name = "estMatriculadoCheckBox";
            this.estMatriculadoCheckBox.Size = new System.Drawing.Size(317, 24);
            this.estMatriculadoCheckBox.TabIndex = 10;
            this.estMatriculadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // gradoLabel
            // 
            gradoLabel.AutoSize = true;
            gradoLabel.Location = new System.Drawing.Point(49, 381);
            gradoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            gradoLabel.Name = "gradoLabel";
            gradoLabel.Size = new System.Drawing.Size(72, 25);
            gradoLabel.TabIndex = 11;
            gradoLabel.Text = "Grado:";
            // 
            // gradoTextBox
            // 
            this.gradoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEstudiantesBindingSource, "Grado", true));
            this.gradoTextBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gradoTextBox.Location = new System.Drawing.Point(226, 376);
            this.gradoTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gradoTextBox.Name = "gradoTextBox";
            this.gradoTextBox.Size = new System.Drawing.Size(164, 30);
            this.gradoTextBox.TabIndex = 12;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(49, 150);
            nombreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(87, 25);
            nombreLabel.TabIndex = 13;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEstudiantesBindingSource, "Nombre", true));
            this.nombreTextBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.nombreTextBox.Location = new System.Drawing.Point(226, 145);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(317, 30);
            this.nombreTextBox.TabIndex = 14;
            // 
            // numeroCuentaLabel
            // 
            numeroCuentaLabel.AutoSize = true;
            numeroCuentaLabel.Location = new System.Drawing.Point(49, 104);
            numeroCuentaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            numeroCuentaLabel.Name = "numeroCuentaLabel";
            numeroCuentaLabel.Size = new System.Drawing.Size(153, 25);
            numeroCuentaLabel.TabIndex = 15;
            numeroCuentaLabel.Text = "Cuenta número:";
            // 
            // numeroCuentaTextBox
            // 
            this.numeroCuentaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEstudiantesBindingSource, "numeroCuenta", true));
            this.numeroCuentaTextBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.numeroCuentaTextBox.Location = new System.Drawing.Point(226, 99);
            this.numeroCuentaTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numeroCuentaTextBox.Name = "numeroCuentaTextBox";
            this.numeroCuentaTextBox.Size = new System.Drawing.Size(164, 30);
            this.numeroCuentaTextBox.TabIndex = 16;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(49, 291);
            telefonoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(95, 25);
            telefonoLabel.TabIndex = 17;
            telefonoLabel.Text = "Teléfono:";
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEstudiantesBindingSource, "Telefono", true));
            this.telefonoTextBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.telefonoTextBox.Location = new System.Drawing.Point(226, 286);
            this.telefonoTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(164, 30);
            this.telefonoTextBox.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxListClass);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(28, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 471);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de alumnos";
            // 
            // comboBoxListClass
            // 
            this.comboBoxListClass.FormattingEnabled = true;
            this.comboBoxListClass.Items.AddRange(new object[] {
            "Matemáticas",
            "Inglés",
            "Español",
            "Ciencias Naturales"});
            this.comboBoxListClass.Location = new System.Drawing.Point(394, 364);
            this.comboBoxListClass.Name = "comboBoxListClass";
            this.comboBoxListClass.Size = new System.Drawing.Size(121, 33);
            this.comboBoxListClass.TabIndex = 20;
            this.comboBoxListClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxListClass_SelectedIndexChanged);
            // 
            // listaEstudiantesBindingSource
            // 
            this.listaEstudiantesBindingSource.DataSource = typeof(BL.Escuela.Estudiantes);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(549, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "<<---- Falta programar";
            // 
            // FormEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(764, 574);
            this.Controls.Add(this.label1);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(clasesLabel);
            this.Controls.Add(this.clasesTextBox);
            this.Controls.Add(correoLabel);
            this.Controls.Add(this.correoTextBox);
            this.Controls.Add(edadLabel);
            this.Controls.Add(this.edadTextBox);
            this.Controls.Add(estMatriculadoLabel);
            this.Controls.Add(this.estMatriculadoCheckBox);
            this.Controls.Add(gradoLabel);
            this.Controls.Add(this.gradoTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(numeroCuentaLabel);
            this.Controls.Add(this.numeroCuentaTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(this.listaEstudiantesBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudiante";
            ((System.ComponentModel.ISupportInitialize)(this.listaEstudiantesBindingNavigator)).EndInit();
            this.listaEstudiantesBindingNavigator.ResumeLayout(false);
            this.listaEstudiantesBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listaEstudiantesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaEstudiantesBindingSource;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton listaEstudiantesBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator listaEstudiantesBindingNavigator;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox clasesTextBox;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.TextBox edadTextBox;
        private System.Windows.Forms.CheckBox estMatriculadoCheckBox;
        private System.Windows.Forms.TextBox gradoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox numeroCuentaTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxListClass;
        private System.Windows.Forms.Label label1;
    }
}