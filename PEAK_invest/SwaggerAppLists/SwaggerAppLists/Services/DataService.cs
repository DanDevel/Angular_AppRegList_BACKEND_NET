using SwaggerAppLists.Models;
using System;
using System.Collections.Generic;

namespace SwaggerAppLists.Services
{
    public class DataService : Services.IDataService
    {
        public IEnumerable<KeyValuePair<int, string>> GetAllData()
        {
            var data = new List<KeyValuePair<int, string>>
            {
                new KeyValuePair<int, string>(1, "João"),
                new KeyValuePair<int, string>(2, "Maria"),
                new KeyValuePair<int, string>(3, "Ana")
            };

            return data;
        }

        public KeyValuePair<int, string> GetDataById(int id)
        {
            var data = GetAllData();
            var pair = data.FirstOrDefault(pair => pair.Key == id);
            return pair;
        }
        
        public double CalculateFinalResult(FormData formData)
        {
            try
            {
                int integerValue = formData.IntegerField;
                decimal decimalValue = formData.DecimalField;

                double valorTotal = CalculateValorTotal(integerValue, decimalValue);
                double valorPorcentagem = 5;
                double resultadoDoCalculoPorcentagem = CalculatePorcentagem(valorTotal, valorPorcentagem);
                double resultadoFinal = CalculateResultadoFinal(valorTotal, resultadoDoCalculoPorcentagem);

                return resultadoFinal;
            }
            catch (Exception ex)
            {
                // Log the error or perform any necessary error handling
                throw new Exception("An error occurred during calculation.", ex);
            }
        }

        private double CalculateValorTotal(int integerValue, decimal decimalValue)
        {
            return (double)(integerValue * decimalValue);
        }

        private double CalculatePorcentagem(double valorTotal, double valorPorcentagem)
        {
            return (valorTotal / 100) * valorPorcentagem;
        }

        private double CalculateResultadoFinal(double valorTotal, double resultadoDoCalculoPorcentagem)
        {
            return valorTotal + resultadoDoCalculoPorcentagem;
        }

    }
}
