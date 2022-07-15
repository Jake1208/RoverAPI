using RoverAPI.Interfaces;
using RoverAPI.Models;

namespace RoverAPI.Models
{
    public class ItemResponse<T> : SuccessResponse, IItemResponse
    {
        public T Item { get; set; }

        object IItemResponse.Item { get { return this.Item; } }
    }
}
