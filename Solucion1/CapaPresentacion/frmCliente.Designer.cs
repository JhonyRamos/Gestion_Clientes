

namespace CapaPresentacion
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            lblId = new Label();
            lblNombres = new Label();
            lblApellidos = new Label();
            lblFoto = new Label();
            linkLabel1 = new LinkLabel();
            picFoto = new PictureBox();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            txtId = new NumericUpDown();
            txtNombres = new TextBox();
            txtApellidos = new TextBox();
            gridDatos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridDatos).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.ForeColor = SystemColors.HotTrack;
            lblId.Location = new Point(41, 34);
            lblId.Name = "lblId";
            lblId.Size = new Size(25, 23);
            lblId.TabIndex = 0;
            lblId.Text = "Id";
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombres.ForeColor = SystemColors.HotTrack;
            lblNombres.Location = new Point(41, 87);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(80, 23);
            lblNombres.TabIndex = 1;
            lblNombres.Text = "Nombres";
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellidos.ForeColor = SystemColors.HotTrack;
            lblApellidos.Location = new Point(41, 135);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(79, 23);
            lblApellidos.TabIndex = 2;
            lblApellidos.Text = "Apellidos";
            // 
            // lblFoto
            // 
            lblFoto.AutoSize = true;
            lblFoto.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFoto.ForeColor = SystemColors.HotTrack;
            lblFoto.Location = new Point(41, 188);
            lblFoto.Name = "lblFoto";
            lblFoto.Size = new Size(52, 23);
            lblFoto.TabIndex = 3;
            lblFoto.Text = "Fotos";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(41, 233);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(81, 23);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Seleccion";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // picFoto
            // 
            picFoto.BackColor = SystemColors.ScrollBar;
            picFoto.Image = (Image)resources.GetObject("picFoto.Image");
            picFoto.Location = new Point(146, 188);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(194, 206);
            picFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            picFoto.TabIndex = 5;
            picFoto.TabStop = false;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.HotTrack;
            btnNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.ForeColor = SystemColors.ControlLightLight;
            btnNuevo.Location = new Point(41, 409);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(94, 29);
            btnNuevo.TabIndex = 6;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.HotTrack;
            btnGuardar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ButtonHighlight;
            btnGuardar.Location = new Point(146, 409);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.HotTrack;
            btnEliminar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnEliminar.Location = new Point(246, 409);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(146, 27);
            txtId.Name = "txtId";
            txtId.Size = new Size(194, 27);
            txtId.TabIndex = 9;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(146, 80);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(194, 27);
            txtNombres.TabIndex = 10;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(146, 128);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(194, 27);
            txtApellidos.TabIndex = 11;
            // 
            // gridDatos
            // 
            gridDatos.BackgroundColor = SystemColors.HotTrack;
            gridDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDatos.Location = new Point(371, 27);
            gridDatos.Name = "gridDatos";
            gridDatos.RowHeadersWidth = 51;
            gridDatos.Size = new Size(397, 367);
            gridDatos.TabIndex = 12;
            // 
            // frmCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gridDatos);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombres);
            Controls.Add(txtId);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(picFoto);
            Controls.Add(linkLabel1);
            Controls.Add(lblFoto);
            Controls.Add(lblApellidos);
            Controls.Add(lblNombres);
            Controls.Add(lblId);
            Name = "frmCliente";
            Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtId).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblNombres;
        private Label lblApellidos;
        private Label lblFoto;
        private LinkLabel linkLabel1;
        private PictureBox picFoto;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEliminar;
        private NumericUpDown txtId;
        private TextBox txtNombres;
        private TextBox txtApellidos;
        private DataGridView gridDatos;
    }
}
