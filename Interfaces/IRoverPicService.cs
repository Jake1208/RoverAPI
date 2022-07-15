using RoverAPI.Models;

namespace RoverAPI.Interfaces
{
    public interface IRoverPicService
    {
        Content GetPicsBySolDate(int solDate);
    }
}