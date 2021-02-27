
namespace WindowsFormsApp1
{
    partial class rUsuario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rUsuario));
            this.ConfirmClaveTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmClave = new System.Windows.Forms.Label();
            this.Rol = new System.Windows.Forms.Label();
            this.RolComboBox = new System.Windows.Forms.ComboBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.ClaveTextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.AliasTextBox = new System.Windows.Forms.TextBox();
            this.Clave = new System.Windows.Forms.Label();
            this.Nombres = new System.Windows.Forms.Label();
            this.Alias = new System.Windows.Forms.Label();
            this.ActivoCheckBox = new System.Windows.Forms.CheckBox();
            this.ID = new System.Windows.Forms.Label();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labFecha = new System.Windows.Forms.Label();
            this.Errores = new System.Windows.Forms.ErrorProvider(this.components);
            this.IdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Errores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConfirmClaveTextBox
            // 
            this.ConfirmClaveTextBox.Location = new System.Drawing.Point(403, 142);
            this.ConfirmClaveTextBox.Name = "ConfirmClaveTextBox";
            this.ConfirmClaveTextBox.PasswordChar = '*';
            this.ConfirmClaveTextBox.Size = new System.Drawing.Size(167, 23);
            this.ConfirmClaveTextBox.TabIndex = 28;
            // 
            // ConfirmClave
            // 
            this.ConfirmClave.AutoSize = true;
            this.ConfirmClave.Location = new System.Drawing.Point(304, 145);
            this.ConfirmClave.Name = "ConfirmClave";
            this.ConfirmClave.Size = new System.Drawing.Size(93, 15);
            this.ConfirmClave.TabIndex = 27;
            this.ConfirmClave.Text = "Confirmar Clave";
            // 
            // Rol
            // 
            this.Rol.AutoSize = true;
            this.Rol.Location = new System.Drawing.Point(361, 71);
            this.Rol.Name = "Rol";
            this.Rol.Size = new System.Drawing.Size(24, 15);
            this.Rol.TabIndex = 26;
            this.Rol.Text = "Rol";
            // 
            // RolComboBox
            // 
            this.RolComboBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RolComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RolComboBox.FormattingEnabled = true;
            this.RolComboBox.Items.AddRange(new object[] {
            "Ingeniero en sistemas",
            "Profesor",
            "Ingeniero Civil",
            "Pintor",
            "Doctor",
            "Bombero",
            "Mecanico",
            "Juez",
            "Abogado"});
            this.RolComboBox.Location = new System.Drawing.Point(403, 68);
            this.RolComboBox.Name = "RolComboBox";
            this.RolComboBox.Size = new System.Drawing.Size(167, 23);
            this.RolComboBox.TabIndex = 25;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.EmailTextBox.Location = new System.Drawing.Point(403, 105);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(167, 23);
            this.EmailTextBox.TabIndex = 24;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(361, 108);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(36, 15);
            this.Email.TabIndex = 23;
            this.Email.Text = "Email";
            // 
            // ClaveTextBox
            // 
            this.ClaveTextBox.Location = new System.Drawing.Point(74, 142);
            this.ClaveTextBox.Name = "ClaveTextBox";
            this.ClaveTextBox.PasswordChar = '*';
            this.ClaveTextBox.Size = new System.Drawing.Size(179, 23);
            this.ClaveTextBox.TabIndex = 22;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(74, 102);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(179, 23);
            this.NombreTextBox.TabIndex = 21;
            // 
            // AliasTextBox
            // 
            this.AliasTextBox.BackColor = System.Drawing.Color.White;
            this.AliasTextBox.Location = new System.Drawing.Point(74, 68);
            this.AliasTextBox.Name = "AliasTextBox";
            this.AliasTextBox.Size = new System.Drawing.Size(179, 23);
            this.AliasTextBox.TabIndex = 20;
            // 
            // Clave
            // 
            this.Clave.AutoSize = true;
            this.Clave.Location = new System.Drawing.Point(12, 145);
            this.Clave.Name = "Clave";
            this.Clave.Size = new System.Drawing.Size(36, 15);
            this.Clave.TabIndex = 19;
            this.Clave.Text = "Clave";
            // 
            // Nombres
            // 
            this.Nombres.AutoSize = true;
            this.Nombres.Location = new System.Drawing.Point(12, 105);
            this.Nombres.Name = "Nombres";
            this.Nombres.Size = new System.Drawing.Size(56, 15);
            this.Nombres.TabIndex = 18;
            this.Nombres.Text = "Nombres";
            // 
            // Alias
            // 
            this.Alias.AutoSize = true;
            this.Alias.Location = new System.Drawing.Point(12, 71);
            this.Alias.Name = "Alias";
            this.Alias.Size = new System.Drawing.Size(32, 15);
            this.Alias.TabIndex = 17;
            this.Alias.Text = "Alias";
            // 
            // ActivoCheckBox
            // 
            this.ActivoCheckBox.AutoSize = true;
            this.ActivoCheckBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ActivoCheckBox.Location = new System.Drawing.Point(193, 33);
            this.ActivoCheckBox.Name = "ActivoCheckBox";
            this.ActivoCheckBox.Size = new System.Drawing.Size(60, 19);
            this.ActivoCheckBox.TabIndex = 31;
            this.ActivoCheckBox.Text = "Activo";
            this.ActivoCheckBox.UseVisualStyleBackColor = false;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(12, 36);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(17, 15);
            this.ID.TabIndex = 32;
            this.ID.Text = "Id";
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.Location = new System.Drawing.Point(156, 171);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(86, 43);
            this.NuevoButton.TabIndex = 34;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.Location = new System.Drawing.Point(248, 171);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(107, 43);
            this.GuardarButton.TabIndex = 35;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.Location = new System.Drawing.Point(361, 171);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(107, 43);
            this.EliminarButton.TabIndex = 36;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.Location = new System.Drawing.Point(148, 31);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(25, 25);
            this.BuscarButton.TabIndex = 38;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.CustomFormat = "dd / MM / yyyy";
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(403, 30);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(167, 23);
            this.FechaDateTimePicker.TabIndex = 39;
            this.FechaDateTimePicker.Value = new System.DateTime(2021, 1, 30, 0, 0, 0, 0);
            // 
            // labFecha
            // 
            this.labFecha.AutoSize = true;
            this.labFecha.Location = new System.Drawing.Point(359, 34);
            this.labFecha.Name = "labFecha";
            this.labFecha.Size = new System.Drawing.Size(38, 15);
            this.labFecha.TabIndex = 40;
            this.labFecha.Text = "Fecha";
            // 
            // Errores
            // 
            this.Errores.ContainerControl = this;
            // 
            // IdNumericUpDown
            // 
            this.IdNumericUpDown.Location = new System.Drawing.Point(74, 32);
            this.IdNumericUpDown.Name = "IdNumericUpDown";
            this.IdNumericUpDown.Size = new System.Drawing.Size(68, 23);
            this.IdNumericUpDown.TabIndex = 42;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IdNumericUpDown);
            this.groupBox1.Controls.Add(this.labFecha);
            this.groupBox1.Controls.Add(this.FechaDateTimePicker);
            this.groupBox1.Controls.Add(this.BuscarButton);
            this.groupBox1.Controls.Add(this.EliminarButton);
            this.groupBox1.Controls.Add(this.GuardarButton);
            this.groupBox1.Controls.Add(this.NuevoButton);
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Controls.Add(this.ActivoCheckBox);
            this.groupBox1.Controls.Add(this.ConfirmClaveTextBox);
            this.groupBox1.Controls.Add(this.ConfirmClave);
            this.groupBox1.Controls.Add(this.Rol);
            this.groupBox1.Controls.Add(this.RolComboBox);
            this.groupBox1.Controls.Add(this.EmailTextBox);
            this.groupBox1.Controls.Add(this.Email);
            this.groupBox1.Controls.Add(this.ClaveTextBox);
            this.groupBox1.Controls.Add(this.NombreTextBox);
            this.groupBox1.Controls.Add(this.AliasTextBox);
            this.groupBox1.Controls.Add(this.Clave);
            this.groupBox1.Controls.Add(this.Nombres);
            this.groupBox1.Controls.Add(this.Alias);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 225);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // rUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(622, 249);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registros Usuarios";
            this.Load += new System.EventHandler(this.rUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Errores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox ConfirmClaveTextBox;
        private System.Windows.Forms.Label ConfirmClave;
        private System.Windows.Forms.Label Rol;
        private System.Windows.Forms.ComboBox RolComboBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox ClaveTextBox;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox AliasTextBox;
        private System.Windows.Forms.Label Clave;
        private System.Windows.Forms.Label Nombres;
        private System.Windows.Forms.Label Alias;
        private System.Windows.Forms.CheckBox ActivoCheckBox;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label labFecha;
        private System.Windows.Forms.ErrorProvider Errores;
        private System.Windows.Forms.NumericUpDown IdNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

