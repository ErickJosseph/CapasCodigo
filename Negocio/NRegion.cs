using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NRegion
    {
        public void RegistrarRegion(string cRegion, bool bEstado)
        {
            try
            {

                string result = string.Empty;
                Procedimiento Datos = new Procedimiento();

                Datos.RegistrarRegion(cRegion, true);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<RegionDto> ListarRegion(int RegionId)
        {
            try
            {
                List<RegionDto> ListaRegion = new List<RegionDto>();
                Procedimiento Datos = new Procedimiento();

                ListaRegion = Datos.ListarRegion(RegionId);

                return ListaRegion;
            }
            catch (Exception ex) 
            {
                throw;
            }
        }

        public void ActualizarRegion(int nRegionId, string cRegion, bool bEstado)
        {
            try
            {

                string result = string.Empty;
                Procedimiento Datos = new Procedimiento();

                Datos.ActualizarRegion(nRegionId, cRegion, true);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void EliminarRegion(int nRegionId)
        {
            try
            {
                string result = string.Empty;
                Procedimiento Datos = new Procedimiento();

                Datos.EliminarRegion(nRegionId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
