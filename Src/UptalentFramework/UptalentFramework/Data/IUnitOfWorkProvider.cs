namespace UptalentFramework.Data
{
    public interface IUnitOfWorkProvider
    {
        object GetDBContext();
        object GetDBContext(string connectStringName);

    }
}