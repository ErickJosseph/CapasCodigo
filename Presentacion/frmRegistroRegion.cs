using Entidad;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmRegistroRegion : Form
    {
        int nRegionId = 0;
        string cNombre = "";
        bool bEstado = true;

        public frmRegistroRegion()
        {
            InitializeComponent();

            dgListaRegion.AutoGenerateColumns = false;
            dgListaRegion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            Limpiar();

            btnActualizar.Visible = false;
            btnCancelar.Visible = false;
            btnEliminar.Visible = false;
            btnEditar.Visible = true;
            btnAgregar.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextNombreRegion.Text.Any())
                {
                    NRegion Negocio = new NRegion();
                    string mensaje = string.Empty;

                    Negocio.RegistrarRegion(TextNombreRegion.Text, true);
                    MessageBox.Show("Se agrego correctamente.");

                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Por favor completar el campo Región");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void ListarRegiones(int RegionId = 0)
        {
            try
            {

                RegionId = String.IsNullOrEmpty(RegionId.ToString()) ? 0 : RegionId;

                List<RegionDto> ListaRegion = new List<RegionDto>();

                NRegion Negocio = new NRegion();

                ListaRegion = Negocio.ListarRegion(RegionId);

                dgListaRegion.DataSource = ListaRegion;


            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Verificar si hay al menos una fila seleccionada
            if (dgListaRegion.SelectedRows.Count > 0 && btnEditar.Visible == false)
            {
                // Obtener la persona seleccionada
                RegionDto RegionSeleccionada = dgListaRegion.SelectedRows[0].DataBoundItem as RegionDto;

                if (RegionSeleccionada != null)
                {
                    // Aquí puedes realizar la acción que desees, por ejemplo, mostrar los detalles en un TextBox
                    nRegionId = RegionSeleccionada.RegionId;
                    cNombre = RegionSeleccionada.NombreRegion.ToString();
                    bEstado = RegionSeleccionada.EstadoRegion;

                    TextNombreRegion.Text = cNombre;
                    btnActualizar.Visible = true;
                    btnCancelar.Visible = true;
                    btnEliminar.Visible = true;
                    btnEditar.Visible = false;
                    btnAgregar.Visible = false;
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (nRegionId != 0)
                {
                    if (TextNombreRegion.Text.Any())
                    {
                        NRegion Negocio = new NRegion();
                        string mensaje = string.Empty;

                        Negocio.ActualizarRegion(nRegionId, TextNombreRegion.Text, true);

                        MessageBox.Show("Actualización completa.");
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Por favor completar el campo Región");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor seleccione una región");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnActualizar.Visible = true;
            btnCancelar.Visible = true;
            btnEliminar.Visible = true;
            btnEditar.Visible = false;
            btnAgregar.Visible = false;
            MessageBox.Show("Seleccione un registro");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (nRegionId != 0)
                {
                    NRegion Negocio = new NRegion();
                    string mensaje = string.Empty;

                    Negocio.EliminarRegion(nRegionId);

                    MessageBox.Show("Se elimino la región correctamente.");
                    
                    Limpiar();

                }
                else
                {
                    MessageBox.Show("Por favor seleccione una región");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            btnActualizar.Visible = false;
            btnCancelar.Visible = false;
            btnEliminar.Visible = false;
            btnEditar.Visible = true;
            btnAgregar.Visible = true;
            Limpiar();
            
        }
        public void Limpiar()
        {
            ListarRegiones();
            TextNombreRegion.Text = "";
            nRegionId = 0;
            cNombre = "";
            bEstado = true;
        }
    }
}
