using SwaggerAppLists.Models;
using System.Collections.Generic;

namespace SwaggerAppLists.Services
{
    public interface IDataService
    {
        IEnumerable<KeyValuePair<int, string>> GetAllData();
        KeyValuePair<int, string> GetDataById(int id);
        double CalculateFinalResult(FormData formData);
    }
}
