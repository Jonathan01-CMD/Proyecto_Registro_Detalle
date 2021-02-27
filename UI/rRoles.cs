using Proyecto_Registro.BLL;
using Proyecto_Registro.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Registro.UI
{
    public partial class rRoles : Form
    {
        public List<RolesDetalles> Detalles { get; set; }
        public rRoles()
        {
            InitializeComponent();
            this.Detalles = new List<RolesDetalles>(); 
        }
        private void CargaGrid()
        {
            DetalledataGridView.DataSource = null;
            DetalledataGridView.DataSource = this.Detalles;
        }

        private void Limpiar()
        {
            errorProvider1.Clear();
            bool paso = false;
            idnumericUpDown.Value = 0;
            DescripciontextBox.Clear();
            ActivocheckBox.Checked = false;
            AsignadocheckBox.Checked = false;
            this.Detalles = new List<RolesDetalles>();
            CargaGrid();
        }

        private void LlenarCampo(Roles roles)
        {
            idnumericUpDown.Value = roles.RolID;
            DescripciontextBox.Text = roles.Descripcion;
            ActivocheckBox.Checked = roles.esActivo;
        }

        private Roles LlenarClase()
        {
            Roles rol = new Roles();
            rol.RolID = (int)idnumericUpDown.Value;
            rol.Descripcion = DescripciontextBox.Text;
            rol.esActivo = ActivocheckBox.Checked;
            rol.Detalles = this.Detalles;

            return rol;
        } 

        private bool ExisteEnLaBaseDeDatos()
        {
            Roles rol = RolesBLL.Buscar((int)idnumericUpDown.Value);
         
            return (rol != null);
        }

        private bool Validar()
        {
            bool paso = true;
            errorProvider1.Clear();

            if (DescripciontextBox.Text == string.Empty)
            {
                errorProvider1.SetError(DescripciontextBox, "El campo Descripcion no puede estar vacío");
                DescripciontextBox.Focus();
                paso = false;
            }
            if (RolesBLL.ExisteDescripcion(DescripciontextBox.Text, (int)idnumericUpDown.Value))
            {
                errorProvider1.SetError(DescripciontextBox, "Este Rol ya existe");
                DescripciontextBox.Focus();
                paso = false;
            }
            if (PermisocomboBox.Text == string.Empty)
            {
                errorProvider1.SetError(PermisocomboBox, "Debe seleccionar un Id");
                PermisocomboBox.Focus();
                paso = false;
            }
            if (this.Detalles.Count == 0)
            {
                errorProvider1.SetError(DetalledataGridView, "Debe agregar un Permiso");
                PermisocomboBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void rRoles_Load(object sender, EventArgs e)
        {
            PermisocomboBox.DataSource = PermisosBLL.GetPermisos();
            PermisocomboBox.DisplayMember = "PermisoId";
            PermisocomboBox.ValueMember = "DetallePermiso";
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            if (DetalledataGridView.DataSource != null)
                this.Detalles = (List<RolesDetalles>)DetalledataGridView.DataSource;

            this.Detalles.Add(
                new RolesDetalles(
                    id: 0,
                    rolId: (int)idnumericUpDown.Value,
                    permisoId: Convert.ToInt32(PermisocomboBox.Text),
                    EsAsignado: AsignadocheckBox.Checked
                )
            );
            CargaGrid();
            PermisocomboBox.Focus();
            AsignadocheckBox.Checked = false;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            int id;
            int.TryParse(idnumericUpDown.Text, out id);
            Limpiar();
            if (UsuariosBLL.Eliminar(id))
                MessageBox.Show("Usuario eliminado correctamente", "Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                errorProvider1.SetError(idnumericUpDown, "ID no existente");
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if((DetalledataGridView.Rows.Count > 0) && (DetalledataGridView.CurrentRow != null))
            {
                Detalles.RemoveAt(DetalledataGridView.CurrentRow.Index);
                CargaGrid();
            }
            else
            {
                errorProvider1.SetError(DetalledataGridView, "No hay filas");
                DetalledataGridView.Focus();
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Roles rol;
            bool paso = false;
            if (!Validar())
            {
                return;
            }

            rol = LlenarClase();

            paso = RolesBLL.Guardar(rol);

            if (!ExisteEnLaBaseDeDatos())
            {
                Limpiar();
                MessageBox.Show("Usuario guardado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Limpiar();
                MessageBox.Show("Usuario modificado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Busquedabutton_Click(object sender, EventArgs e)
        {
            int id;
            Roles roles = new Roles();
            int.TryParse(idnumericUpDown.Text, out id);

            Limpiar();

            roles = RolesBLL.Buscar(id);

            if (roles != null)
            {
                MessageBox.Show("Persona Encotrada");
                LlenarCampo(roles);
            }
            else
            {
                MessageBox.Show("Persona no Encontrada");
            }
        }
        private void Busquedabutton_Click_1(object sender, EventArgs e)
        {
            int id;
            Roles rol = new Roles();
            int.TryParse(idnumericUpDown.Text, out id);

            Limpiar();

            rol = RolesBLL.Buscar(id);

            if (rol != null)
            {
                MessageBox.Show("Rol Encotrada");
                LlenarCampo(rol);
            }
            else
            {
                MessageBox.Show("Rol no Encontrada");
                MessageBox.Show("Rol no Encontrada");
            }
        }
    }
}
