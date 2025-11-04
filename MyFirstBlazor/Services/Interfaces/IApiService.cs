using MyFirstBlazor.Services.Models;

namespace MyFirstBlazor.Services.Interfaces
{
    public interface IApiService
    {
        Task<ResultModel<IEnumerable<MovieModel>>> GetAllAsync();
        Task<ResultModel<IEnumerable<MovieModel>>> SearchAsync(string toSearch);
    }
}
