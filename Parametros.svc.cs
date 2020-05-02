using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using PortalSaludWCF.Dominio;
using PortalSaludWCF.Persistencia;
namespace PortalSaludWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "WParametros" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione WParametros.svc o WParametros.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WParametros : IWParametros
    {
        private ParametrosDAO ParametrosDao = new ParametrosDAO();
        Parametros IWParametros.ModificarParametros(Parametros objParametros)
        {
            return ParametrosDao.Modificar(objParametros);
        }
        List<Parametros> IWParametros.ObtenerParametros()
        {
            return ParametrosDao.Listar();
        }
        public Parametros ObtenerParametro(string pac_dni)
        {
            return ParametrosDao.Obtener(pac_dni);
        }
    }
}
