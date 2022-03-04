using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Solucinar o maiusculo
//solucionar o problema da resposta inválida

namespace TemperatureConversor.Services
{
    class TemperaturaServices
    {
       public double ConversorTemperatura(string de, string para, double valorAconverter)
        {
            //Solucinar o maiusculo
            double resultadoConvertido = 0;

            if (de == "celcius" && para == "fahrenheit")
            {
                resultadoConvertido = valorAconverter * 1.8 + 32;
            }
            if (de == "celcius" && para == "kelvin")
            {
                resultadoConvertido = valorAconverter + 273.15;
            }
            if (de == "celcius" && para == "celcius")
            {
                resultadoConvertido = valorAconverter;
            }
            if (de == "fahrenheit" && para == "celcius")
            {
                resultadoConvertido = (valorAconverter - 32) * 5 / 9;
            }
            if (de == "fahrenheit" && para == "kelvin")
            {
                resultadoConvertido = (valorAconverter - 32) * 5 / 9 + 273.15;
            }
            if (de == "fahrenheit" && para == "fahrenheit")
            {
                resultadoConvertido = valorAconverter;
            }
            if (de == "kelvin" && para == "celcius")
            {
                resultadoConvertido = valorAconverter - 273.15;
            }
            if (de == "kelvin" && para == "fahrenheit")
            {
                resultadoConvertido = (valorAconverter - 273.15) * 9 / 5 + 32;
            }
            if (de == "kelvin" && para == "kelvin")
            {
                resultadoConvertido = valorAconverter;
            }

            return resultadoConvertido;
        }
    }
}