using CodeFirst.DataPartTwo.Models;

namespace CodeFirst.DataPartTwo.Interface
{
    public interface ICarRepository
    {
        List<Car> GetAllCars();
    }
}