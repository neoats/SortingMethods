using DataAccess.Abstract.ReadAndWrite;

namespace DataAccess.Concrete.Reader;

public class CsvReader : ICsvReader
{
    private readonly string _filePath;
    private static readonly object _fileLock = new object();

    public CsvReader(string filePath)
    {
        _filePath = filePath;
    }


    public IEnumerable<T[]> Read<T>()
    {
        char separator = ',';
        List<T[]> file = new List<T[]>();
        using (StreamReader reader = new StreamReader(_filePath))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(separator);
                T[] row = values.Select(v => (T)Convert.ChangeType(v, typeof(T))).ToArray();
                file.Add(row);
            }
        }
        return file;
    }

  
}