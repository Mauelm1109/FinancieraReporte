using System;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp1.AccesoDatosReportes;

namespace WindowsFormsApp1.LogicaDeNegocios.Reportes
{
    public class AmortizacionService
    {
        private ReportesEntities1 db = new ReportesEntities1();


        public List<AmortizacionVista> CalcularTablaFrancesa(decimal capital, decimal tasaAnual, int meses)
        {
            List<AmortizacionVista> listaAmortizacion = new List<AmortizacionVista>();

            double tasaMensual = (double)(tasaAnual / 100) / 12;

            double factor = Math.Pow(1 + tasaMensual, meses);
            decimal cuotaMensual = capital * (decimal)((tasaMensual * factor) / (factor - 1));

            decimal saldoRestante = capital;

            for (int i = 1; i <= meses; i++)
            {

                decimal interesMes = saldoRestante * (decimal)tasaMensual;

                decimal abonoCapital = cuotaMensual - interesMes;


                saldoRestante -= abonoCapital;

                if (i == meses) saldoRestante = 0;

                listaAmortizacion.Add(new AmortizacionVista
                {
                    Mes = i,
                    Cuota = Math.Round(cuotaMensual, 2),
                    Interes = Math.Round(interesMes, 2),
                    Capital = Math.Round(abonoCapital, 2),
                    Saldo = Math.Round(saldoRestante, 2)
                });
            }

            return listaAmortizacion;
        }

        public class AmortizacionVista
        {
            public int Mes { get; set; }
            public decimal Cuota { get; set; }
            public decimal Interes { get; set; }
            public decimal Capital { get; set; }
            public decimal Saldo { get; set; }
        }
    }
}