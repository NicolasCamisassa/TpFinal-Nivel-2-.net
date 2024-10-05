namespace PresentacionTPNivel2
{
    partial class FrmAltaArticulo
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.tbxPrecio = new System.Windows.Forms.TextBox();
            this.picBoxArticulo = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cBoxCategoria = new System.Windows.Forms.ComboBox();
            this.cBoxMarca = new System.Windows.Forms.ComboBox();
            this.lblImagenUrl = new System.Windows.Forms.Label();
            this.tbxImgUrl = new System.Windows.Forms.TextBox();
            this.lblImagenLocal = new System.Windows.Forms.Label();
            this.btnImgLocal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(74, 52);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(86, 25);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(67, 105);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(93, 25);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(29, 158);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(131, 25);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.Location = new System.Drawing.Point(170, 153);
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.Size = new System.Drawing.Size(192, 31);
            this.tbxDescripcion.TabIndex = 2;
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(170, 102);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(192, 31);
            this.tbxNombre.TabIndex = 1;
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Location = new System.Drawing.Point(170, 51);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.Size = new System.Drawing.Size(192, 31);
            this.tbxCodigo.TabIndex = 0;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(74, 211);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(79, 25);
            this.lblPrecio.TabIndex = 12;
            this.lblPrecio.Text = "Precio:";
            // 
            // tbxPrecio
            // 
            this.tbxPrecio.Location = new System.Drawing.Point(170, 204);
            this.tbxPrecio.Name = "tbxPrecio";
            this.tbxPrecio.Size = new System.Drawing.Size(192, 31);
            this.tbxPrecio.TabIndex = 3;
            // 
            // picBoxArticulo
            // 
            this.picBoxArticulo.Location = new System.Drawing.Point(398, 52);
            this.picBoxArticulo.Name = "picBoxArticulo";
            this.picBoxArticulo.Size = new System.Drawing.Size(593, 585);
            this.picBoxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxArticulo.TabIndex = 15;
            this.picBoxArticulo.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(19, 554);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(156, 83);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(199, 554);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(163, 83);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(49, 264);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(111, 25);
            this.lblCategoria.TabIndex = 16;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(83, 317);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(84, 25);
            this.lblMarca.TabIndex = 17;
            this.lblMarca.Text = "Marca: ";
            // 
            // cBoxCategoria
            // 
            this.cBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCategoria.FormattingEnabled = true;
            this.cBoxCategoria.Location = new System.Drawing.Point(170, 255);
            this.cBoxCategoria.Name = "cBoxCategoria";
            this.cBoxCategoria.Size = new System.Drawing.Size(192, 33);
            this.cBoxCategoria.TabIndex = 4;
            // 
            // cBoxMarca
            // 
            this.cBoxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxMarca.FormattingEnabled = true;
            this.cBoxMarca.Location = new System.Drawing.Point(170, 308);
            this.cBoxMarca.Name = "cBoxMarca";
            this.cBoxMarca.Size = new System.Drawing.Size(192, 33);
            this.cBoxMarca.TabIndex = 5;
            // 
            // lblImagenUrl
            // 
            this.lblImagenUrl.AutoSize = true;
            this.lblImagenUrl.Location = new System.Drawing.Point(37, 370);
            this.lblImagenUrl.Name = "lblImagenUrl";
            this.lblImagenUrl.Size = new System.Drawing.Size(127, 25);
            this.lblImagenUrl.TabIndex = 20;
            this.lblImagenUrl.Text = "Imagen Url: ";
            // 
            // tbxImgUrl
            // 
            this.tbxImgUrl.Location = new System.Drawing.Point(170, 361);
            this.tbxImgUrl.Name = "tbxImgUrl";
            this.tbxImgUrl.Size = new System.Drawing.Size(192, 31);
            this.tbxImgUrl.TabIndex = 6;
            this.tbxImgUrl.Leave += new System.EventHandler(this.tbxImgUrl_Leave);
            // 
            // lblImagenLocal
            // 
            this.lblImagenLocal.AutoSize = true;
            this.lblImagenLocal.Location = new System.Drawing.Point(12, 425);
            this.lblImagenLocal.Name = "lblImagenLocal";
            this.lblImagenLocal.Size = new System.Drawing.Size(146, 25);
            this.lblImagenLocal.TabIndex = 22;
            this.lblImagenLocal.Text = "Imagen Local:";
            // 
            // btnImgLocal
            // 
            this.btnImgLocal.Location = new System.Drawing.Point(170, 412);
            this.btnImgLocal.Name = "btnImgLocal";
            this.btnImgLocal.Size = new System.Drawing.Size(192, 51);
            this.btnImgLocal.TabIndex = 7;
            this.btnImgLocal.Text = "Agregar";
            this.btnImgLocal.UseVisualStyleBackColor = true;
            this.btnImgLocal.Click += new System.EventHandler(this.btnImgLocal_Click);
            // 
            // FrmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 810);
            this.Controls.Add(this.btnImgLocal);
            this.Controls.Add(this.lblImagenLocal);
            this.Controls.Add(this.tbxImgUrl);
            this.Controls.Add(this.lblImagenUrl);
            this.Controls.Add(this.cBoxMarca);
            this.Controls.Add(this.cBoxCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.picBoxArticulo);
            this.Controls.Add(this.tbxPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.tbxCodigo);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.tbxDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Name = "FrmAltaArticulo";
            this.Text = "Alta Articulo";
            this.Load += new System.EventHandler(this.FrmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox tbxDescripcion;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox tbxPrecio;
        private System.Windows.Forms.PictureBox picBoxArticulo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cBoxCategoria;
        private System.Windows.Forms.ComboBox cBoxMarca;
        private System.Windows.Forms.Label lblImagenUrl;
        private System.Windows.Forms.TextBox tbxImgUrl;
        private System.Windows.Forms.Label lblImagenLocal;
        private System.Windows.Forms.Button btnImgLocal;
    }
}