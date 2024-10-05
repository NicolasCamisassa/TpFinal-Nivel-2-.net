using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace PresentacionTPNivel2
{
    public partial class FrmAltaArticulo : Form
    {
        private Articulos articulo = null;
        private OpenFileDialog archivoLocal = null;
        public FrmAltaArticulo()
        {
            InitializeComponent();
            Text = "Agregar Articulo";
        }
        public FrmAltaArticulo(Articulos articuloSeleccionado)
        {
            InitializeComponent();
            this.articulo = articuloSeleccionado;
            Text = "Modificar Articulo";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticulosBusiness business = new ArticulosBusiness();
            try
            {
                if (articulo == null)
                    articulo = new Articulos();

                
                articulo.Codigo = tbxCodigo.Text;
                articulo.Nombre = tbxNombre.Text;
                articulo.Descripcion = tbxDescripcion.Text;
                articulo.Precio = decimal.Parse(tbxPrecio.Text);
                string precioFormateado = articulo.Precio.ToString("F2");
                articulo.Categoria = (Categorias)cBoxCategoria.SelectedItem;
                articulo.Marcas = (Marcas)cBoxMarca.SelectedItem;
                articulo.ImagenUrl = tbxImgUrl.Text;

                if(articulo.Id != 0)
                {
                    business.Modificar(articulo);
                    MessageBox.Show("Modificado Exitosamente");
                    Close();
                }
                else
                {
                    business.Agregar(articulo);
                    MessageBox.Show("Agregado Exitosamente");
                    Close();
                }
                if (archivoLocal != null && !(tbxImgUrl.Text.ToUpper().Contains("HTTP")))
                    File.Copy(archivoLocal.FileName, ConfigurationManager.AppSettings["Articulos-app"] + archivoLocal.SafeFileName);

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmAltaArticulo_Load(object sender, EventArgs e)
        {
            CategoriasBusiness negocioCategorias = new CategoriasBusiness();
            MarcasBusiness negocioMarcas = new MarcasBusiness();

            try
            {
                cBoxCategoria.DataSource = negocioCategorias.Listar();
                cBoxCategoria.ValueMember = "Id";
                cBoxCategoria.DisplayMember = "Descripcion";
                cBoxMarca.DataSource = negocioMarcas.Listar();
                cBoxMarca.ValueMember = "Id";
                cBoxMarca.DisplayMember = "Descripcion";
                cBoxCategoria.SelectedIndex = -1;
                cBoxMarca.SelectedIndex = -1;
                
                if (articulo != null )
                {
                    tbxCodigo.Text = articulo.Codigo;
                    tbxNombre.Text = articulo.Nombre;
                    tbxDescripcion.Text = articulo.Descripcion;
                    tbxPrecio.Text = articulo.Precio.ToString("F2");
                    tbxImgUrl.Text = articulo.ImagenUrl;
                    CargarImagen(articulo.ImagenUrl);
                    cBoxCategoria.SelectedValue = articulo.Categoria.Id;
                    cBoxMarca.SelectedValue = articulo.Marcas.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tbxImgUrl_Leave(object sender, EventArgs e)
        {
            CargarImagen(tbxImgUrl.Text);
        }

        private void CargarImagen(string imagen)
        {
            try
            {
                picBoxArticulo.Load(imagen);
            }
            catch (Exception)
            {
                picBoxArticulo.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");

            }
        }

        private void btnImgLocal_Click(object sender, EventArgs e)
        {
            archivoLocal = new OpenFileDialog();
            archivoLocal.Filter = "jpg|*.jpg|png|*.png";
            if (archivoLocal.ShowDialog() == DialogResult.OK)
            {
                tbxImgUrl.Text = archivoLocal.FileName;
                CargarImagen(archivoLocal.FileName);
            }
        }
    }
}
