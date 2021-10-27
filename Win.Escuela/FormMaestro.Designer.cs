namespace Win.Escuela
{
    partial class FormMaestro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMaestro));
            System.Windows.Forms.Label catedraticoLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label activoLabel;
            this.maestroBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.maestroBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.catedraticoTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.maestroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            catedraticoLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            activoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.maestroBindingNavigator)).BeginInit();
            this.maestroBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maestroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // maestroBindingNavigator
            // 
            this.maestroBindingNavigator.AddNewItem = null;
            this.maestroBindingNavigator.BindingSource = this.maestroBindingSource;
            this.maestroBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.maestroBindingNavigator.DeleteItem = null;
            this.maestroBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.maestroBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.maestroBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.maestroBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.maestroBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.maestroBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.maestroBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.maestroBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.maestroBindingNavigator.Name = "maestroBindingNavigator";
            this.maestroBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.maestroBindingNavigator.Size = new System.Drawing.Size(420, 27);
            this.maestroBindingNavigator.TabIndex = 0;
            this.maestroBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // maestroBindingNavigatorSaveItem
            // 
            this.maestroBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.maestroBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("maestroBindingNavigatorSaveItem.Image")));
            this.maestroBindingNavigatorSaveItem.Name = "maestroBindingNavigatorSaveItem";
            this.maestroBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.maestroBindingNavigatorSaveItem.Text = "Guardar datos";
            this.maestroBindingNavigatorSaveItem.Click += new System.EventHandler(this.maestroBindingNavigatorSaveItem_Click);
            // 
            // catedraticoLabel
            // 
            catedraticoLabel.AutoSize = true;
            catedraticoLabel.Location = new System.Drawing.Point(33, 118);
            catedraticoLabel.Name = "catedraticoLabel";
            catedraticoLabel.Size = new System.Drawing.Size(84, 17);
            catedraticoLabel.TabIndex = 1;
            catedraticoLabel.Text = "Catedratico:";
            // 
            // catedraticoTextBox
            // 
            this.catedraticoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maestroBindingSource, "Catedratico", true));
            this.catedraticoTextBox.Location = new System.Drawing.Point(123, 115);
            this.catedraticoTextBox.Name = "catedraticoTextBox";
            this.catedraticoTextBox.Size = new System.Drawing.Size(179, 22);
            this.catedraticoTextBox.TabIndex = 2;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(33, 76);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 3;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maestroBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(123, 73);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(179, 22);
            this.idTextBox.TabIndex = 4;
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(33, 158);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(50, 17);
            activoLabel.TabIndex = 5;
            activoLabel.Text = "Activo:";
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.maestroBindingSource, "Activo", true));
            this.activoCheckBox.Location = new System.Drawing.Point(123, 155);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.activoCheckBox.TabIndex = 6;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // toolStripButtonCancelar
            // 
            this.toolStripButtonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelar.Image")));
            this.toolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            this.toolStripButtonCancelar.Size = new System.Drawing.Size(70, 24);
            this.toolStripButtonCancelar.Text = "Cancelar";
            this.toolStripButtonCancelar.Visible = false;
            this.toolStripButtonCancelar.Click += new System.EventHandler(this.toolStripButtonCancelar_Click);
            // 
            // maestroBindingSource
            // 
            this.maestroBindingSource.DataSource = typeof(BL.Escuela.Maestro);
            // 
            // FormMaestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 321);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(catedraticoLabel);
            this.Controls.Add(this.catedraticoTextBox);
            this.Controls.Add(this.maestroBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMaestro";
            this.Text = "Maestro";
            ((System.ComponentModel.ISupportInitialize)(this.maestroBindingNavigator)).EndInit();
            this.maestroBindingNavigator.ResumeLayout(false);
            this.maestroBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maestroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource maestroBindingSource;
        private System.Windows.Forms.BindingNavigator maestroBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton maestroBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox catedraticoTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
    }
}