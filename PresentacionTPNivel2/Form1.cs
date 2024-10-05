using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Controller;
using System.Runtime.InteropServices.WindowsRuntime;

namespace PresentacionTPNivel2
{
    public partial class frmArticulos : Form
    {
        private List<Articulos> ListaArticulos;
        public frmArticulos()
        {
            InitializeComponent();
        }
        private void frmArticulos_Load(object sender, EventArgs e)
        {
            Cargar();
            cboxCampo.Items.Add("Nombre");
            cboxCampo.Items.Add("Categoria");
            cboxCampo.Items.Add("Marca");
            cboxCampo.Items.Add("Precio");
        }

        private void Cargar()
        {
            ArticulosBusiness business = new ArticulosBusiness();
            try
            {
                ListaArticulos = business.Listar();
                dgvArticulos.DataSource = ListaArticulos;
                CargarImagen(ListaArticulos[0].ImagenUrl);
                OcultarColumnas();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "F2";

            if (dgvArticulos.CurrentRow != null)
            {
                Articulos seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
                CargarImagen(seleccionado.ImagenUrl);
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else 
            {
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
            }
        }

        private void CargarImagen(string imagen)
        {
            try
            {
                pictBoxArticulos.Load(imagen);
            }
            catch (Exception)
            {
                pictBoxArticulos.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");

            }
        }

        private void OcultarColumnas()
        {
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
        }

        private void tbxBuscarSimple_TextChanged(object sender, EventArgs e)
        {
            List<Articulos> listaBuscarSimple;
            string buscar = tbxBuscarSimple.Text;

            if (buscar.Length < 4)
            {
                listaBuscarSimple = ListaArticulos.FindAll(x => x.Codigo.ToUpper().Contains(buscar.ToUpper()));
            }
            else
            {
                listaBuscarSimple = ListaArticulos;
            }
            
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaBuscarSimple;
            OcultarColumnas();
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaArticulo alta = new FrmAltaArticulo();
            alta.ShowDialog();
            Cargar();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
                Articulos seleccionado;
                seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;

                FrmAltaArticulo modificar = new FrmAltaArticulo(seleccionado);
                modificar.ShowDialog();
                Cargar();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticulosBusiness business = new ArticulosBusiness();
            Articulos seleccionado;
            try
            {
                DialogResult answer = MessageBox.Show("Seguro desea Eliminar?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if(answer == DialogResult.Yes)
                {
                    seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
                    business.Eliminar(seleccionado.Id);
                    Cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private bool ValidacionFiltro()
        {
            if(cboxCampo.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccionar un campo");
                return true;
            }
            if(cboxCriterio.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccionar un criterio");
                return true;
            }
            if(cboxCampo.SelectedItem.ToString() == "Precio")
            {
                if(string.IsNullOrEmpty(tbxComentario.Text))
                {
                    MessageBox.Show("Debes seleccionar campo: Precio");
                    return true;
                }
                if (!(ColocarNumeros(tbxComentario.Text)))
                {
                    MessageBox.Show("Colocar solo numeros");
                    return true;
                }
            }
            
            return false;
        }
        private bool ColocarNumeros(string cadena)
        {
            bool decimalSeparador = false;
            foreach (char caracter in cadena)
            {
                if (char.IsDigit(caracter))
                {
                    continue;
                }
                else if ((caracter == '.' || caracter == ',') && !decimalSeparador)
                {
                    decimalSeparador = true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            
            ArticulosBusiness business = new ArticulosBusiness();
            try
            {
                
                if (ValidacionFiltro())
                    return;
                
                string campo = cboxCampo.SelectedItem.ToString();
                string criterio = cboxCriterio.SelectedItem.ToString();
                string comentario = tbxComentario.Text;
                dgvArticulos.DataSource = business.Filtrar(campo, criterio, comentario);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            if (dgvArticulos.CurrentRow != null)
            {
                Articulos seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
                CargarImagen(seleccionado.ImagenUrl);
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
            }
            
        }
        private void cboxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboxCampo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                cboxCriterio.Items.Clear();
                cboxCriterio.Items.Add("Mayor a");
                cboxCriterio.Items.Add("Menor a");
                cboxCriterio.Items.Add("Igual a");
            }
            else
            {
                cboxCriterio.Items.Clear();
                cboxCriterio.Items.Add("Comienza con");
                cboxCriterio.Items.Add("Termina con");
                cboxCriterio.Items.Add("Contiene");
            }
        }
    }
}
