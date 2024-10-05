namespace PresentacionTPNivel2
{
    partial class frmArticulos
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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pictBoxArticulos = new System.Windows.Forms.PictureBox();
            this.lblBuscarArticulo = new System.Windows.Forms.Label();
            this.tbxBuscarSimple = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            this.cboxCriterio = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.tbxComentario = new System.Windows.Forms.TextBox();
            this.lblComentario = new System.Windows.Forms.Label();
            this.cboxCampo = new System.Windows.Forms.ComboBox();
            this.lblCampo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToOrderColumns = true;
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 246);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 82;
            this.dgvArticulos.RowTemplate.Height = 33;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(1452, 540);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pictBoxArticulos
            // 
            this.pictBoxArticulos.Location = new System.Drawing.Point(1558, 162);
            this.pictBoxArticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictBoxArticulos.Name = "pictBoxArticulos";
            this.pictBoxArticulos.Size = new System.Drawing.Size(688, 823);
            this.pictBoxArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBoxArticulos.TabIndex = 1;
            this.pictBoxArticulos.TabStop = false;
            // 
            // lblBuscarArticulo
            // 
            this.lblBuscarArticulo.AutoSize = true;
            this.lblBuscarArticulo.Location = new System.Drawing.Point(20, 796);
            this.lblBuscarArticulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBuscarArticulo.Name = "lblBuscarArticulo";
            this.lblBuscarArticulo.Size = new System.Drawing.Size(164, 25);
            this.lblBuscarArticulo.TabIndex = 2;
            this.lblBuscarArticulo.Text = "Codigo Articulo:";
            // 
            // tbxBuscarSimple
            // 
            this.tbxBuscarSimple.Location = new System.Drawing.Point(186, 796);
            this.tbxBuscarSimple.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbxBuscarSimple.Name = "tbxBuscarSimple";
            this.tbxBuscarSimple.Size = new System.Drawing.Size(476, 31);
            this.tbxBuscarSimple.TabIndex = 1;
            this.tbxBuscarSimple.TextChanged += new System.EventHandler(this.tbxBuscarSimple_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(22, 162);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(268, 65);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(312, 162);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(268, 65);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(602, 162);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(268, 65);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(16, 852);
            this.lblFiltroAvanzado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(168, 25);
            this.lblFiltroAvanzado.TabIndex = 7;
            this.lblFiltroAvanzado.Text = "Filtro Avanzado:";
            // 
            // cboxCriterio
            // 
            this.cboxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCriterio.FormattingEnabled = true;
            this.cboxCriterio.Location = new System.Drawing.Point(384, 892);
            this.cboxCriterio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxCriterio.Name = "cboxCriterio";
            this.cboxCriterio.Size = new System.Drawing.Size(244, 33);
            this.cboxCriterio.TabIndex = 3;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(1044, 888);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(244, 50);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(298, 902);
            this.lblCriterio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(81, 25);
            this.lblCriterio.TabIndex = 14;
            this.lblCriterio.Text = "Criterio";
            // 
            // tbxComentario
            // 
            this.tbxComentario.Location = new System.Drawing.Point(768, 894);
            this.tbxComentario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxComentario.Name = "tbxComentario";
            this.tbxComentario.Size = new System.Drawing.Size(244, 31);
            this.tbxComentario.TabIndex = 4;
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Location = new System.Drawing.Point(640, 902);
            this.lblComentario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(122, 25);
            this.lblComentario.TabIndex = 16;
            this.lblComentario.Text = "Comentario";
            // 
            // cboxCampo
            // 
            this.cboxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCampo.FormattingEnabled = true;
            this.cboxCampo.Location = new System.Drawing.Point(106, 892);
            this.cboxCampo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxCampo.Name = "cboxCampo";
            this.cboxCampo.Size = new System.Drawing.Size(180, 33);
            this.cboxCampo.TabIndex = 2;
            this.cboxCampo.SelectedIndexChanged += new System.EventHandler(this.cboxCampo_SelectedIndexChanged);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(22, 898);
            this.lblCampo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(80, 25);
            this.lblCampo.TabIndex = 18;
            this.lblCampo.Text = "Campo";
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2384, 1006);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.cboxCampo);
            this.Controls.Add(this.lblComentario);
            this.Controls.Add(this.tbxComentario);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.cboxCriterio);
            this.Controls.Add(this.lblFiltroAvanzado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbxBuscarSimple);
            this.Controls.Add(this.lblBuscarArticulo);
            this.Controls.Add(this.pictBoxArticulos);
            this.Controls.Add(this.dgvArticulos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmArticulos";
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.frmArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pictBoxArticulos;
        private System.Windows.Forms.Label lblBuscarArticulo;
        private System.Windows.Forms.TextBox tbxBuscarSimple;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblFiltroAvanzado;
        private System.Windows.Forms.ComboBox cboxCriterio;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.TextBox tbxComentario;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.ComboBox cboxCampo;
        private System.Windows.Forms.Label lblCampo;
    }
}

