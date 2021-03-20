using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiXamarin.Services
{
    public interface IIngredientsApi
    {
        [Get("/user.{user}")]
        Task<IngredientAnalysisApiService> GetUser(string key);
    }
}
