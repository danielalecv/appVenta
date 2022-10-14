namespace AppVenta.Dominio.Interfaces
{
    public interface IAgregar<IEntidad>
    {
        IEntidad Agregar(IEntidad entidad);
    }
}
