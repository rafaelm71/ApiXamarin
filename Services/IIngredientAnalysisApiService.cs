using ApiXamarin.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static ApiXamarin.Models.Name;

namespace ApiXamarin.Services
{
    public interface IIngredientAnalysisApiService
    {
        Task<IngredientAnalysis> GetIngredientAnalysisAsync();
        
    }
}
