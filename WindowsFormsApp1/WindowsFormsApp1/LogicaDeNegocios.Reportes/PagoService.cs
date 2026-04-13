using System;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp1.AccesoDatosReportes;
using System.Data.Entity;

namespace WindowsFormsApp1.LogicaDeNegocios.Reportes
{
    public class PagoService
    {
        private ReportesEntities1 db = new ReportesEntities1();

        public void RegistrarPago(int prestamoID, int mesPagado, decimal montoAbonado)
        {
            try
            {

                var prestamo = db.Prestamos.Find(prestamoID);
                if (prestamo == null) throw new Exception("Préstamo no encontrado.");

                decimal saldoAnterior = prestamo.MontoTotal;


                if (montoAbonado > 0)
                {

                    int mesesRestantes = prestamo.PlazoMeses - mesPagado;

                    if (mesesRestantes > 0)
                    {

                        decimal nuevoCapital = saldoAnterior - montoAbonado;

                        decimal nuevaTasa = ObtenerTasaPorTiempoRestante(mesesRestantes);

                        decimal nuevoInteres = nuevoCapital * (nuevaTasa / 100);
                        prestamo.MontoTotal = nuevoCapital + nuevoInteres;
                        prestamo.TasaInteres = nuevaTasa; 
                        prestamo.InteresGenerado = nuevoInteres;
                    }
                    else
                    {

                        prestamo.MontoTotal -= montoAbonado;
                    }
                }


                Pago nuevoPago = new Pago
                {
                    PrestamoID = prestamoID,
                    Mes = mesPagado,
                    MontoAnterior = saldoAnterior,
                    MontoAbonado = montoAbonado,
                    InteresPagado = 0, 
                    NuevoSaldo = prestamo.MontoTotal,
                    FechaPago = DateTime.Now
                };

                db.Pagos.Add(nuevoPago);
                db.Entry(prestamo).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al procesar pago: " + ex.Message);
            }
        }


        private decimal ObtenerTasaPorTiempoRestante(int meses)
        {
            if (meses <= 3) return 10;
            if (meses <= 6) return 8;
            if (meses <= 12) return 7;
            return 5;
        }


        public decimal ObtenerTotalRecaudado()
        {
            return db.Pagos.Sum(p => (decimal?)p.MontoAbonado) ?? 0;
        }
    }
}