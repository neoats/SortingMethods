namespace DataAccess.Abstract.ReadAndWrite;

public interface ICsvReader
{

    IEnumerable<T[]> Read<T>();
}