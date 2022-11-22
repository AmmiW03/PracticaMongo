namespace PracticaMongo.Vistas
{
    partial class frmUsuarios
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblApellidoM = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidoP = new System.Windows.Forms.Label();
            this.lblMatriculaUs = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.txtApellidoM = new System.Windows.Forms.TextBox();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMatriculaUsuario = new System.Windows.Forms.TextBox();
            this.grbDatosC = new System.Windows.Forms.GroupBox();
            this.txtApellidoMC = new System.Windows.Forms.TextBox();
            this.txtApellidoPC = new System.Windows.Forms.TextBox();
            this.txtNombreC = new System.Windows.Forms.TextBox();
            this.txtMatriculaUsuarioC = new System.Windows.Forms.TextBox();
            this.lblMatriculaUsC = new System.Windows.Forms.Label();
            this.lblApellidoMC = new System.Windows.Forms.Label();
            this.lblNombreC = new System.Windows.Forms.Label();
            this.lblApellidoPC = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.clmMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmApellidoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmApellidoM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizarTabla = new System.Windows.Forms.Button();
            this.grbPermisos = new System.Windows.Forms.GroupBox();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.btnAgregarPermiso = new System.Windows.Forms.Button();
            this.btnEliminarPermiso = new System.Windows.Forms.Button();
            this.txtPermisos = new System.Windows.Forms.TextBox();
            this.lblPermisos = new System.Windows.Forms.Label();
            this.dgvPermisos = new System.Windows.Forms.DataGridView();
            this.clmPermisos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDatos.SuspendLayout();
            this.grbDatosC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.grbPermisos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(391, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(253, 31);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Control de Personal";
            // 
            // lblApellidoM
            // 
            this.lblApellidoM.AutoSize = true;
            this.lblApellidoM.Location = new System.Drawing.Point(17, 160);
            this.lblApellidoM.Name = "lblApellidoM";
            this.lblApellidoM.Size = new System.Drawing.Size(89, 13);
            this.lblApellidoM.TabIndex = 5;
            this.lblApellidoM.Text = "Apellido Materno:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 71);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellidoP
            // 
            this.lblApellidoP.AutoSize = true;
            this.lblApellidoP.Location = new System.Drawing.Point(17, 114);
            this.lblApellidoP.Name = "lblApellidoP";
            this.lblApellidoP.Size = new System.Drawing.Size(87, 13);
            this.lblApellidoP.TabIndex = 7;
            this.lblApellidoP.Text = "Apellido Paterno:";
            // 
            // lblMatriculaUs
            // 
            this.lblMatriculaUs.AutoSize = true;
            this.lblMatriculaUs.Location = new System.Drawing.Point(17, 31);
            this.lblMatriculaUs.Name = "lblMatriculaUs";
            this.lblMatriculaUs.Size = new System.Drawing.Size(92, 13);
            this.lblMatriculaUs.TabIndex = 8;
            this.lblMatriculaUs.Text = "Matricula Usuario:";
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.txtApellidoM);
            this.grbDatos.Controls.Add(this.txtApellidoP);
            this.grbDatos.Controls.Add(this.txtNombre);
            this.grbDatos.Controls.Add(this.txtMatriculaUsuario);
            this.grbDatos.Controls.Add(this.lblMatriculaUs);
            this.grbDatos.Controls.Add(this.lblApellidoM);
            this.grbDatos.Controls.Add(this.lblNombre);
            this.grbDatos.Controls.Add(this.lblApellidoP);
            this.grbDatos.Location = new System.Drawing.Point(26, 87);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(260, 200);
            this.grbDatos.TabIndex = 10;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos";
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.Location = new System.Drawing.Point(116, 157);
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Size = new System.Drawing.Size(119, 20);
            this.txtApellidoM.TabIndex = 12;
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Location = new System.Drawing.Point(116, 111);
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(119, 20);
            this.txtApellidoP.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(116, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(119, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // txtMatriculaUsuario
            // 
            this.txtMatriculaUsuario.Location = new System.Drawing.Point(116, 31);
            this.txtMatriculaUsuario.Name = "txtMatriculaUsuario";
            this.txtMatriculaUsuario.Size = new System.Drawing.Size(119, 20);
            this.txtMatriculaUsuario.TabIndex = 9;
            // 
            // grbDatosC
            // 
            this.grbDatosC.Controls.Add(this.txtApellidoMC);
            this.grbDatosC.Controls.Add(this.txtApellidoPC);
            this.grbDatosC.Controls.Add(this.txtNombreC);
            this.grbDatosC.Controls.Add(this.txtMatriculaUsuarioC);
            this.grbDatosC.Controls.Add(this.lblMatriculaUsC);
            this.grbDatosC.Controls.Add(this.lblApellidoMC);
            this.grbDatosC.Controls.Add(this.lblNombreC);
            this.grbDatosC.Controls.Add(this.lblApellidoPC);
            this.grbDatosC.Location = new System.Drawing.Point(26, 374);
            this.grbDatosC.Name = "grbDatosC";
            this.grbDatosC.Size = new System.Drawing.Size(260, 200);
            this.grbDatosC.TabIndex = 13;
            this.grbDatosC.TabStop = false;
            this.grbDatosC.Text = "Datos";
            // 
            // txtApellidoMC
            // 
            this.txtApellidoMC.Enabled = false;
            this.txtApellidoMC.Location = new System.Drawing.Point(116, 157);
            this.txtApellidoMC.Name = "txtApellidoMC";
            this.txtApellidoMC.Size = new System.Drawing.Size(119, 20);
            this.txtApellidoMC.TabIndex = 12;
            // 
            // txtApellidoPC
            // 
            this.txtApellidoPC.Enabled = false;
            this.txtApellidoPC.Location = new System.Drawing.Point(116, 111);
            this.txtApellidoPC.Name = "txtApellidoPC";
            this.txtApellidoPC.Size = new System.Drawing.Size(119, 20);
            this.txtApellidoPC.TabIndex = 11;
            // 
            // txtNombreC
            // 
            this.txtNombreC.Enabled = false;
            this.txtNombreC.Location = new System.Drawing.Point(116, 71);
            this.txtNombreC.Name = "txtNombreC";
            this.txtNombreC.Size = new System.Drawing.Size(119, 20);
            this.txtNombreC.TabIndex = 10;
            // 
            // txtMatriculaUsuarioC
            // 
            this.txtMatriculaUsuarioC.Enabled = false;
            this.txtMatriculaUsuarioC.Location = new System.Drawing.Point(116, 31);
            this.txtMatriculaUsuarioC.Name = "txtMatriculaUsuarioC";
            this.txtMatriculaUsuarioC.Size = new System.Drawing.Size(119, 20);
            this.txtMatriculaUsuarioC.TabIndex = 9;
            // 
            // lblMatriculaUsC
            // 
            this.lblMatriculaUsC.AutoSize = true;
            this.lblMatriculaUsC.Location = new System.Drawing.Point(17, 31);
            this.lblMatriculaUsC.Name = "lblMatriculaUsC";
            this.lblMatriculaUsC.Size = new System.Drawing.Size(92, 13);
            this.lblMatriculaUsC.TabIndex = 8;
            this.lblMatriculaUsC.Text = "Matricula Usuario:";
            // 
            // lblApellidoMC
            // 
            this.lblApellidoMC.AutoSize = true;
            this.lblApellidoMC.Location = new System.Drawing.Point(17, 160);
            this.lblApellidoMC.Name = "lblApellidoMC";
            this.lblApellidoMC.Size = new System.Drawing.Size(89, 13);
            this.lblApellidoMC.TabIndex = 5;
            this.lblApellidoMC.Text = "Apellido Materno:";
            // 
            // lblNombreC
            // 
            this.lblNombreC.AutoSize = true;
            this.lblNombreC.Location = new System.Drawing.Point(17, 71);
            this.lblNombreC.Name = "lblNombreC";
            this.lblNombreC.Size = new System.Drawing.Size(47, 13);
            this.lblNombreC.TabIndex = 6;
            this.lblNombreC.Text = "Nombre:";
            // 
            // lblApellidoPC
            // 
            this.lblApellidoPC.AutoSize = true;
            this.lblApellidoPC.Location = new System.Drawing.Point(17, 114);
            this.lblApellidoPC.Name = "lblApellidoPC";
            this.lblApellidoPC.Size = new System.Drawing.Size(87, 13);
            this.lblApellidoPC.TabIndex = 7;
            this.lblApellidoPC.Text = "Apellido Paterno:";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMatricula,
            this.clmNombre,
            this.clmApellidoP,
            this.clmApellidoM,
            this.clmEntrada,
            this.clmSalida});
            this.dgvUsuarios.Location = new System.Drawing.Point(335, 137);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(645, 150);
            this.dgvUsuarios.TabIndex = 14;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            this.dgvUsuarios.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dgvUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellDoubleClick);
            // 
            // clmMatricula
            // 
            this.clmMatricula.HeaderText = "Matricula";
            this.clmMatricula.Name = "clmMatricula";
            // 
            // clmNombre
            // 
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            // 
            // clmApellidoP
            // 
            this.clmApellidoP.HeaderText = "Apellido Paterno";
            this.clmApellidoP.Name = "clmApellidoP";
            // 
            // clmApellidoM
            // 
            this.clmApellidoM.HeaderText = "Apellido Materno";
            this.clmApellidoM.Name = "clmApellidoM";
            // 
            // clmEntrada
            // 
            this.clmEntrada.HeaderText = "Entrada";
            this.clmEntrada.Name = "clmEntrada";
            // 
            // clmSalida
            // 
            this.clmSalida.HeaderText = "Salida";
            this.clmSalida.Name = "clmSalida";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(26, 310);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(120, 310);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 16;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(211, 310);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizarTabla
            // 
            this.btnActualizarTabla.Location = new System.Drawing.Point(884, 87);
            this.btnActualizarTabla.Name = "btnActualizarTabla";
            this.btnActualizarTabla.Size = new System.Drawing.Size(96, 32);
            this.btnActualizarTabla.TabIndex = 18;
            this.btnActualizarTabla.Text = "Actualizar Tabla";
            this.btnActualizarTabla.UseVisualStyleBackColor = true;
            this.btnActualizarTabla.Click += new System.EventHandler(this.btnActualizarTabla_Click);
            // 
            // grbPermisos
            // 
            this.grbPermisos.Controls.Add(this.btnEntrada);
            this.grbPermisos.Controls.Add(this.btnSalida);
            this.grbPermisos.Controls.Add(this.btnAgregarPermiso);
            this.grbPermisos.Controls.Add(this.btnEliminarPermiso);
            this.grbPermisos.Controls.Add(this.txtPermisos);
            this.grbPermisos.Controls.Add(this.lblPermisos);
            this.grbPermisos.Location = new System.Drawing.Point(335, 374);
            this.grbPermisos.Name = "grbPermisos";
            this.grbPermisos.Size = new System.Drawing.Size(288, 200);
            this.grbPermisos.TabIndex = 19;
            this.grbPermisos.TabStop = false;
            this.grbPermisos.Text = "Permisos";
            // 
            // btnEntrada
            // 
            this.btnEntrada.Location = new System.Drawing.Point(36, 145);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(75, 42);
            this.btnEntrada.TabIndex = 20;
            this.btnEntrada.Text = "Registrar Entrada";
            this.btnEntrada.UseVisualStyleBackColor = true;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.Location = new System.Drawing.Point(185, 145);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(75, 42);
            this.btnSalida.TabIndex = 21;
            this.btnSalida.Text = "Registrar Salida";
            this.btnSalida.UseVisualStyleBackColor = true;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // btnAgregarPermiso
            // 
            this.btnAgregarPermiso.Location = new System.Drawing.Point(36, 71);
            this.btnAgregarPermiso.Name = "btnAgregarPermiso";
            this.btnAgregarPermiso.Size = new System.Drawing.Size(75, 42);
            this.btnAgregarPermiso.TabIndex = 11;
            this.btnAgregarPermiso.Text = "Agregar Permiso";
            this.btnAgregarPermiso.UseVisualStyleBackColor = true;
            this.btnAgregarPermiso.Click += new System.EventHandler(this.btnAgregarPermiso_Click_1);
            // 
            // btnEliminarPermiso
            // 
            this.btnEliminarPermiso.Location = new System.Drawing.Point(185, 71);
            this.btnEliminarPermiso.Name = "btnEliminarPermiso";
            this.btnEliminarPermiso.Size = new System.Drawing.Size(75, 42);
            this.btnEliminarPermiso.TabIndex = 11;
            this.btnEliminarPermiso.Text = "Eliminar Permiso";
            this.btnEliminarPermiso.UseVisualStyleBackColor = true;
            this.btnEliminarPermiso.Click += new System.EventHandler(this.btnEliminarPermiso_Click_1);
            // 
            // txtPermisos
            // 
            this.txtPermisos.Location = new System.Drawing.Point(91, 28);
            this.txtPermisos.Name = "txtPermisos";
            this.txtPermisos.Size = new System.Drawing.Size(169, 20);
            this.txtPermisos.TabIndex = 12;
            // 
            // lblPermisos
            // 
            this.lblPermisos.AutoSize = true;
            this.lblPermisos.Location = new System.Drawing.Point(33, 31);
            this.lblPermisos.Name = "lblPermisos";
            this.lblPermisos.Size = new System.Drawing.Size(52, 13);
            this.lblPermisos.TabIndex = 11;
            this.lblPermisos.Text = "Permisos:";
            // 
            // dgvPermisos
            // 
            this.dgvPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPermisos});
            this.dgvPermisos.Location = new System.Drawing.Point(750, 388);
            this.dgvPermisos.Name = "dgvPermisos";
            this.dgvPermisos.Size = new System.Drawing.Size(177, 186);
            this.dgvPermisos.TabIndex = 20;
            // 
            // clmPermisos
            // 
            this.clmPermisos.HeaderText = "Permisos";
            this.clmPermisos.Name = "clmPermisos";
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 607);
            this.Controls.Add(this.dgvPermisos);
            this.Controls.Add(this.grbPermisos);
            this.Controls.Add(this.btnActualizarTabla);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.grbDatosC);
            this.Controls.Add(this.grbDatos);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmUsuarios";
            this.Text = "Form1";
            this.TopMost = true;
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.grbDatosC.ResumeLayout(false);
            this.grbDatosC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.grbPermisos.ResumeLayout(false);
            this.grbPermisos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblApellidoM;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidoP;
        private System.Windows.Forms.Label lblMatriculaUs;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.TextBox txtApellidoM;
        private System.Windows.Forms.TextBox txtApellidoP;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtMatriculaUsuario;
        private System.Windows.Forms.GroupBox grbDatosC;
        private System.Windows.Forms.TextBox txtApellidoMC;
        private System.Windows.Forms.TextBox txtApellidoPC;
        private System.Windows.Forms.TextBox txtNombreC;
        private System.Windows.Forms.TextBox txtMatriculaUsuarioC;
        private System.Windows.Forms.Label lblMatriculaUsC;
        private System.Windows.Forms.Label lblApellidoMC;
        private System.Windows.Forms.Label lblNombreC;
        private System.Windows.Forms.Label lblApellidoPC;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmApellidoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmApellidoM;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalida;
        private System.Windows.Forms.Button btnActualizarTabla;
        private System.Windows.Forms.GroupBox grbPermisos;
        private System.Windows.Forms.Button btnAgregarPermiso;
        private System.Windows.Forms.Button btnEliminarPermiso;
        private System.Windows.Forms.TextBox txtPermisos;
        private System.Windows.Forms.Label lblPermisos;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.DataGridView dgvPermisos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPermisos;
    }
}