
namespace Proyecto_Registro.UI
{
    partial class rRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rRoles));
            this.label1 = new System.Windows.Forms.Label();
            this.idnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Busquedabutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deletebutton = new System.Windows.Forms.Button();
            this.DetalledataGridView = new System.Windows.Forms.DataGridView();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.PermisocomboBox = new System.Windows.Forms.ComboBox();
            this.AsignadocheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ActivocheckBox = new System.Windows.Forms.CheckBox();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.idnumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roles ID";
            // 
            // idnumericUpDown
            // 
            this.idnumericUpDown.Location = new System.Drawing.Point(80, 17);
            this.idnumericUpDown.Name = "idnumericUpDown";
            this.idnumericUpDown.Size = new System.Drawing.Size(31, 23);
            this.idnumericUpDown.TabIndex = 1;
            // 
            // Busquedabutton
            // 
            this.Busquedabutton.Image = ((System.Drawing.Image)(resources.GetObject("Busquedabutton.Image")));
            this.Busquedabutton.Location = new System.Drawing.Point(117, 17);
            this.Busquedabutton.Name = "Busquedabutton";
            this.Busquedabutton.Size = new System.Drawing.Size(26, 24);
            this.Busquedabutton.TabIndex = 2;
            this.Busquedabutton.UseVisualStyleBackColor = true;
            this.Busquedabutton.Click += new System.EventHandler(this.Busquedabutton_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcion";
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(80, 54);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(140, 23);
            this.DescripciontextBox.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deletebutton);
            this.groupBox1.Controls.Add(this.DetalledataGridView);
            this.groupBox1.Controls.Add(this.Agregarbutton);
            this.groupBox1.Controls.Add(this.PermisocomboBox);
            this.groupBox1.Controls.Add(this.AsignadocheckBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(-4, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 286);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle";
            // 
            // deletebutton
            // 
            this.deletebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deletebutton.Image = ((System.Drawing.Image)(resources.GetObject("deletebutton.Image")));
            this.deletebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deletebutton.Location = new System.Drawing.Point(176, 234);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(94, 44);
            this.deletebutton.TabIndex = 9;
            this.deletebutton.Text = "Remover";
            this.deletebutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // DetalledataGridView
            // 
            this.DetalledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalledataGridView.Location = new System.Drawing.Point(6, 57);
            this.DetalledataGridView.Name = "DetalledataGridView";
            this.DetalledataGridView.RowTemplate.Height = 25;
            this.DetalledataGridView.Size = new System.Drawing.Size(427, 171);
            this.DetalledataGridView.TabIndex = 8;
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Agregarbutton.Image")));
            this.Agregarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Agregarbutton.Location = new System.Drawing.Point(258, 15);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(89, 38);
            this.Agregarbutton.TabIndex = 7;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // PermisocomboBox
            // 
            this.PermisocomboBox.FormattingEnabled = true;
            this.PermisocomboBox.Location = new System.Drawing.Point(95, 28);
            this.PermisocomboBox.Name = "PermisocomboBox";
            this.PermisocomboBox.Size = new System.Drawing.Size(75, 23);
            this.PermisocomboBox.TabIndex = 1;
            // 
            // AsignadocheckBox
            // 
            this.AsignadocheckBox.AutoSize = true;
            this.AsignadocheckBox.Location = new System.Drawing.Point(176, 28);
            this.AsignadocheckBox.Name = "AsignadocheckBox";
            this.AsignadocheckBox.Size = new System.Drawing.Size(76, 19);
            this.AsignadocheckBox.TabIndex = 6;
            this.AsignadocheckBox.Text = "Asignado";
            this.AsignadocheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Permiso ID";
            // 
            // ActivocheckBox
            // 
            this.ActivocheckBox.AutoSize = true;
            this.ActivocheckBox.Location = new System.Drawing.Point(369, 12);
            this.ActivocheckBox.Name = "ActivocheckBox";
            this.ActivocheckBox.Size = new System.Drawing.Size(60, 19);
            this.ActivocheckBox.TabIndex = 2;
            this.ActivocheckBox.Text = "Activo";
            this.ActivocheckBox.UseVisualStyleBackColor = true;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = ((System.Drawing.Image)(resources.GetObject("Nuevobutton.Image")));
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.Location = new System.Drawing.Point(88, 373);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(85, 41);
            this.Nuevobutton.TabIndex = 6;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Eliminarbutton.Image")));
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.Location = new System.Drawing.Point(179, 374);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(94, 41);
            this.Eliminarbutton.TabIndex = 7;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Guardarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Guardarbutton.Image")));
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.Location = new System.Drawing.Point(279, 375);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(94, 40);
            this.Guardarbutton.TabIndex = 8;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // rRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(441, 416);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.ActivocheckBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Busquedabutton);
            this.Controls.Add(this.idnumericUpDown);
            this.Controls.Add(this.label1);
            this.Name = "rRoles";
            this.Text = "rRoles";
            this.Load += new System.EventHandler(this.rRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.idnumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown idnumericUpDown;
        private System.Windows.Forms.Button Busquedabutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.DataGridView DetalledataGridView;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.ComboBox PermisocomboBox;
        private System.Windows.Forms.CheckBox AsignadocheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ActivocheckBox;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
    }
}