namespace AppVenta.Dominio.Interfaces.Repositorios
{
    public interface IRepositorioDetalle<TEntidad, TMovimientoID> 
        : IAgregar<TEntidad>, ITransaccion
    {
    }
}
