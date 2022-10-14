using System.Collections.Generic;

namespace AppVenta.Dominio.Interfaces
{
    public interface IListar<TEntidad, TEntidadID>
    {
        List<TEntidad> Listar();
        TEntidad SeleccionarPorId(TEntidadID entidadID);
    }
}
