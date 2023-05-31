using Business;
using DataAccess.Concrete.Reader;
using SortMethods;

namespace main;

class Program
{
    static void Main(string[] args)
    {
        do
        {
            var inputService = new UserInputService();
            var size = inputService.GetDataSizeChoice();
            var sorter = new SortingService(new JsonReader(size), new SortingManager());
            sorter.SortAndPrintData(inputService.GetPatternChoice(), size,
                inputService.GetOutputChoice());
        } while (Console.ReadKey().Key != ConsoleKey.Escape);
    }
}