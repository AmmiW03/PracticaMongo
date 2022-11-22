using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PracticaMongo.Modelos;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using MongoDB.Bson;

namespace PracticaMongo.Vistas
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
            ActualizarTablaUsuarios();
        }

        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMatriculaUsuario.Text != "" && txtNombre.Text != "" && txtApellidoP.Text != "" && txtApellidoM.Text != "")
                {
                    List<String> lstPermisos = new List<String>();
                    lstPermisos.Add("");
                    clsUsuarioModelo oUsuario = new clsUsuarioModelo()
                    {
                        MatriculaUsuario = txtMatriculaUsuario.Text,
                        Nombre = txtNombre.Text,
                        ApellidoP = txtApellidoP.Text,
                        ApellidoM = txtApellidoM.Text,
                        Permisos = lstPermisos
                    };

                    clsMetodosMongoDB.CrearUsuario(oUsuario);
                    MessageBox.Show("Usuario agregado correctamente");
                }
                else
                {
                    MessageBox.Show("No se agregó correctamente");
                }

                txtMatriculaUsuario.Text = String.Empty;
                txtNombre.Text = String.Empty;
                txtApellidoP.Text = String.Empty;
                txtApellidoM.Text = String.Empty;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
          
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMatriculaUsuario.Text != "" && txtNombre.Text != "" && txtApellidoP.Text != "" && txtApellidoM.Text != "")
                {
                    clsUsuarioModelo oUsuario = clsMetodosMongoDB.ObtenerUsuario(txtMatriculaUsuarioC.Text);
                    oUsuario.MatriculaUsuario = txtMatriculaUsuario.Text;
                    oUsuario.Nombre = txtNombre.Text;
                    oUsuario.ApellidoP = txtApellidoP.Text;
                    oUsuario.ApellidoM = txtApellidoM.Text;
                    clsMetodosMongoDB.ActualizarUsuario(oUsuario, txtMatriculaUsuarioC.Text);
                }
                else
                {
                    MessageBox.Show("Favor de llenar todos los campos");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No es exitosa");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMatriculaUsuario.Text != "" && txtNombre.Text != "" && txtApellidoP.Text != "" && txtApellidoM.Text != "")
                {

                        clsUsuarioModelo oUsuario = clsMetodosMongoDB.ObtenerUsuario(txtMatriculaUsuarioC.Text);
                        oUsuario.MatriculaUsuario = txtMatriculaUsuario.Text;
                        oUsuario.Nombre = txtNombre.Text;
                        oUsuario.ApellidoP = txtApellidoP.Text;
                        oUsuario.ApellidoM = txtApellidoM.Text;
                        clsMetodosMongoDB.Eliminarusuario(oUsuario);
                }
                else
                {
                    MessageBox.Show("Favor de llenar todos los campos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No es exitosa");
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Actualiza Tabla Usuarios
        /// </summary>
        private void ActualizarTablaUsuarios()
        {
            var coleccionBD = clsConexionMongoDB.ObtenerUsuariosColeccion();
            List<clsUsuarioModelo> lstColeccion = coleccionBD.Find(D => true).ToList();

            dgvUsuarios.Rows.Clear();
            foreach (clsUsuarioModelo oUsuario in lstColeccion)
            {
                dgvUsuarios.Rows.Add(oUsuario.MatriculaUsuario, oUsuario.Nombre, oUsuario.ApellidoP, oUsuario.ApellidoM, oUsuario.FechaHoraEntrada, oUsuario.FechaHoraSalida );
            }
        }

        /// <summary>
        /// Actualizar Tabla Permisos
        /// </summary>
        /// <param name="oUsuario"></param>
        private void ActualizarTablaPermisos(clsUsuarioModelo oUsuario)
        {
            for ( int i = 0 ; i < oUsuario.Permisos.Count ; i++)
            {
                dgvPermisos.Rows.Add(oUsuario.Permisos[i]);
            }
        }
       
        /// <summary>
        /// Devuelve hora y fecha actual
        /// </summary>
        /// <returns> String </returns>
        private String FechaHoraActual()
        {
            DateTime oHoraActual = DateTime.Now;
            return oHoraActual.ToString();
        }

        /// <summary>
        /// Asigna hora y fecha a una entrada o salida
        /// </summary>
        /// <param name="bEntrada"></param>
        private void AsignarHoraFecha(bool bEntrada)
        {
            clsUsuarioModelo oUsuario = clsMetodosMongoDB.ObtenerUsuario(txtMatriculaUsuarioC.Text);
            if (oUsuario == null)
            {
                MessageBox.Show("Usuario no encontrado, vuelva a intentar");
                return;
            }
            if (bEntrada)
            {
                oUsuario.FechaHoraEntrada = FechaHoraActual();
                clsMetodosMongoDB.ActualizarUsuario(oUsuario, oUsuario.MatriculaUsuario);
                MessageBox.Show("Hora de entrada registrada" + oUsuario.FechaHoraEntrada, "Registro de entrada");
            }
            else
            {
                oUsuario.FechaHoraSalida = FechaHoraActual();
                clsMetodosMongoDB.ActualizarUsuario(oUsuario, oUsuario.MatriculaUsuario);
                MessageBox.Show("Hora de salida registrada" + oUsuario.FechaHoraEntrada, "Registro de salida");
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnActualizarTabla_Click(object sender, EventArgs e)
        {
            ActualizarTablaUsuarios();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            AsignarHoraFecha(true);
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            AsignarHoraFecha(false);
        }

        private void btnAgregarPermiso_Click_1(object sender, EventArgs e)
        {
            try
            {
                if ( txtMatriculaUsuarioC.Text != String.Empty && txtPermisos.Text != String.Empty )
                {
                    clsUsuarioModelo oUsuario = clsMetodosMongoDB.ObtenerUsuario(txtMatriculaUsuarioC.Text);
                    oUsuario.Permisos.Add(txtPermisos.Text);
                    clsMetodosMongoDB.ActualizarUsuario(oUsuario, oUsuario.MatriculaUsuario);

                    MessageBox.Show("Permiso agregado con éxito");
                }
                else
                {
                    MessageBox.Show("Existen campos vacios, verifique la información");
                }
            }
            catch( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnEliminarPermiso_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtMatriculaUsuarioC.Text != String.Empty && txtPermisos.Text != String.Empty ) 
                {
                    clsUsuarioModelo oUsuario = clsMetodosMongoDB.ObtenerUsuario(txtMatriculaUsuarioC.Text);

                    for (int i = 0; i < oUsuario.Permisos.Count; i++)
                    {
                        if (oUsuario.Permisos[i] == txtPermisos.Text)
                        {
                            oUsuario.Permisos.RemoveAt(i);
                        }
                    }
                    MessageBox.Show("Permiso eliminado con éxito");
                }
                else
                {
                    MessageBox.Show("Existen campos vacios, verifique la información");
                }
            }

            catch( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var coleccionBD = clsConexionMongoDB.ObtenerUsuariosColeccion();
                clsUsuarioModelo oUsuario = coleccionBD.Find(D => D.MatriculaUsuario == dgvUsuarios.CurrentRow.Cells[0].Value.ToString()).First();
                txtMatriculaUsuarioC.Text = oUsuario.MatriculaUsuario;
                txtNombreC.Text = oUsuario.Nombre;
                txtApellidoPC.Text = oUsuario.ApellidoP;
                txtApellidoMC.Text = oUsuario.ApellidoM;

                ActualizarTablaPermisos(oUsuario);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
