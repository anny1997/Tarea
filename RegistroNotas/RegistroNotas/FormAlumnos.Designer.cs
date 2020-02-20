namespace RegistroNotas
{
    partial class FormAlumnos
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
            System.Windows.Forms.Label anioCursadoLabel;
            System.Windows.Forms.Label cursoLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label numeroIdentidadLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlumnos));
            this.listaAlumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaAlumnosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.listaAlumnosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.anioCursadoTextBox = new System.Windows.Forms.TextBox();
            this.cursoTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.numeroIdentidadTextBox = new System.Windows.Forms.TextBox();
            anioCursadoLabel = new System.Windows.Forms.Label();
            cursoLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            numeroIdentidadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaAlumnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaAlumnosBindingNavigator)).BeginInit();
            this.listaAlumnosBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // anioCursadoLabel
            // 
            anioCursadoLabel.AutoSize = true;
            anioCursadoLabel.Location = new System.Drawing.Point(39, 109);
            anioCursadoLabel.Name = "anioCursadoLabel";
            anioCursadoLabel.Size = new System.Drawing.Size(75, 13);
            anioCursadoLabel.TabIndex = 3;
            anioCursadoLabel.Text = "años Cursado:";
            // 
            // cursoLabel
            // 
            cursoLabel.AutoSize = true;
            cursoLabel.Location = new System.Drawing.Point(39, 135);
            cursoLabel.Name = "cursoLabel";
            cursoLabel.Size = new System.Drawing.Size(37, 13);
            cursoLabel.TabIndex = 5;
            cursoLabel.Text = "Curso:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(39, 31);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 7;
            idLabel.Text = "Id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(39, 57);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 9;
            nombreLabel.Text = "Nombre:";
            // 
            // numeroIdentidadLabel
            // 
            numeroIdentidadLabel.AutoSize = true;
            numeroIdentidadLabel.Location = new System.Drawing.Point(39, 83);
            numeroIdentidadLabel.Name = "numeroIdentidadLabel";
            numeroIdentidadLabel.Size = new System.Drawing.Size(94, 13);
            numeroIdentidadLabel.TabIndex = 11;
            numeroIdentidadLabel.Text = "Numero Identidad:";
            // 
            // listaAlumnosBindingSource
            // 
            this.listaAlumnosBindingSource.DataSource = typeof(BL.Notas.Alumno);
            // 
            // listaAlumnosBindingNavigator
            // 
            this.listaAlumnosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.listaAlumnosBindingNavigator.BindingSource = this.listaAlumnosBindingSource;
            this.listaAlumnosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaAlumnosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.listaAlumnosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listaAlumnosBindingNavigatorSaveItem});
            this.listaAlumnosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaAlumnosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaAlumnosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaAlumnosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaAlumnosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaAlumnosBindingNavigator.Name = "listaAlumnosBindingNavigator";
            this.listaAlumnosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaAlumnosBindingNavigator.Size = new System.Drawing.Size(371, 25);
            this.listaAlumnosBindingNavigator.TabIndex = 0;
            this.listaAlumnosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // listaAlumnosBindingNavigatorSaveItem
            // 
            this.listaAlumnosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaAlumnosBindingNavigatorSaveItem.Enabled = false;
            this.listaAlumnosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaAlumnosBindingNavigatorSaveItem.Image")));
            this.listaAlumnosBindingNavigatorSaveItem.Name = "listaAlumnosBindingNavigatorSaveItem";
            this.listaAlumnosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listaAlumnosBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // anioCursadoTextBox
            // 
            this.anioCursadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaAlumnosBindingSource, "AnioCursado", true));
            this.anioCursadoTextBox.Location = new System.Drawing.Point(139, 106);
            this.anioCursadoTextBox.Name = "anioCursadoTextBox";
            this.anioCursadoTextBox.Size = new System.Drawing.Size(104, 20);
            this.anioCursadoTextBox.TabIndex = 4;
            // 
            // cursoTextBox
            // 
            this.cursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaAlumnosBindingSource, "Curso", true));
            this.cursoTextBox.Location = new System.Drawing.Point(139, 132);
            this.cursoTextBox.Name = "cursoTextBox";
            this.cursoTextBox.Size = new System.Drawing.Size(104, 20);
            this.cursoTextBox.TabIndex = 6;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaAlumnosBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(139, 28);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(104, 20);
            this.idTextBox.TabIndex = 8;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaAlumnosBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(139, 54);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(104, 20);
            this.nombreTextBox.TabIndex = 10;
            // 
            // numeroIdentidadTextBox
            // 
            this.numeroIdentidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaAlumnosBindingSource, "NumeroIdentidad", true));
            this.numeroIdentidadTextBox.Location = new System.Drawing.Point(139, 80);
            this.numeroIdentidadTextBox.Name = "numeroIdentidadTextBox";
            this.numeroIdentidadTextBox.Size = new System.Drawing.Size(104, 20);
            this.numeroIdentidadTextBox.TabIndex = 12;
            // 
            // FormAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 261);
            this.Controls.Add(anioCursadoLabel);
            this.Controls.Add(this.anioCursadoTextBox);
            this.Controls.Add(cursoLabel);
            this.Controls.Add(this.cursoTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(numeroIdentidadLabel);
            this.Controls.Add(this.numeroIdentidadTextBox);
            this.Controls.Add(this.listaAlumnosBindingNavigator);
            this.Name = "FormAlumnos";
            this.Text = "Alumnos";
            ((System.ComponentModel.ISupportInitialize)(this.listaAlumnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaAlumnosBindingNavigator)).EndInit();
            this.listaAlumnosBindingNavigator.ResumeLayout(false);
            this.listaAlumnosBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaAlumnosBindingSource;
        private System.Windows.Forms.BindingNavigator listaAlumnosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton listaAlumnosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox anioCursadoTextBox;
        private System.Windows.Forms.TextBox cursoTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox numeroIdentidadTextBox;
    }
}