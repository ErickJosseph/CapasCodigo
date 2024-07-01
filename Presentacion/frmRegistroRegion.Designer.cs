namespace Presentacion
{
    partial class frmRegistroRegion
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
            TextNombreRegion = new TextBox();
            btnAgregar = new Button();
            label2 = new Label();
            txtTitulo = new Label();
            panel1 = new Panel();
            btnCancelar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            dgListaRegion = new DataGridView();
            RegionId = new DataGridViewTextBoxColumn();
            NombreRegion = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgListaRegion).BeginInit();
            SuspendLayout();
            // 
            // TextNombreRegion
            // 
            TextNombreRegion.Location = new Point(332, 103);
            TextNombreRegion.Name = "TextNombreRegion";
            TextNombreRegion.Size = new Size(338, 23);
            TextNombreRegion.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ActiveCaption;
            btnAgregar.Location = new Point(562, 147);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(108, 39);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(332, 85);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 4;
            label2.Text = "Region";
            // 
            // txtTitulo
            // 
            txtTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTitulo.AutoSize = true;
            txtTitulo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtTitulo.Location = new Point(243, 9);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(210, 20);
            txtTitulo.TabIndex = 2;
            txtTitulo.Text = "Mantenimiento de Regiones ";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtTitulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 53);
            panel1.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ActiveCaption;
            btnCancelar.Location = new Point(562, 147);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 39);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.ActiveCaption;
            btnEditar.Location = new Point(448, 147);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(108, 39);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ActiveCaption;
            btnEliminar.Location = new Point(334, 147);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(108, 39);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ActiveCaption;
            btnActualizar.Location = new Point(448, 147);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(108, 39);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Visible = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dgListaRegion
            // 
            dgListaRegion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgListaRegion.Columns.AddRange(new DataGridViewColumn[] { RegionId, NombreRegion });
            dgListaRegion.Location = new Point(23, 92);
            dgListaRegion.Name = "dgListaRegion";
            dgListaRegion.RowTemplate.Height = 25;
            dgListaRegion.Size = new Size(303, 241);
            dgListaRegion.TabIndex = 10;
            dgListaRegion.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // RegionId
            // 
            RegionId.DataPropertyName = "RegionId";
            RegionId.HeaderText = "ID";
            RegionId.Name = "RegionId";
            RegionId.ReadOnly = true;
            // 
            // NombreRegion
            // 
            NombreRegion.DataPropertyName = "NombreRegion";
            NombreRegion.HeaderText = "Nombre region";
            NombreRegion.Name = "NombreRegion";
            NombreRegion.ReadOnly = true;
            NombreRegion.Width = 160;
            // 
            // frmRegistroRegion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 401);
            Controls.Add(dgListaRegion);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnCancelar);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btnAgregar);
            Controls.Add(TextNombreRegion);
            Name = "frmRegistroRegion";
            Text = "frmRegistroRegion";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgListaRegion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextNombreRegion;
        private Button btnAgregar;
        private Label label2;
        private Label txtTitulo;
        private Panel panel1;
        private Button btnCancelar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnActualizar;
        private DataGridView dgListaRegion;
        private DataGridViewTextBoxColumn RegionId;
        private DataGridViewTextBoxColumn NombreRegion;
    }
}