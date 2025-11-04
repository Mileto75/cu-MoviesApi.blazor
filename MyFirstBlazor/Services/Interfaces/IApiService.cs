using MyFirstBlazor.Services.Models;

namespace MyFirstBlazor.Services.Interfaces
{
    public interface IApiService
    {
        Task<ResultModel<IEnumerable<MovieModel>>> GetAllAsync();
    }
}
