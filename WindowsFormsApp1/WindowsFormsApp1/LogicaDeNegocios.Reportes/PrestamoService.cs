using System;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp1.AccesoDatosReportes;
using System.Data.Entity;

namespace WindowsFormsApp1.LogicaDeNegocios.Reportes
{
    public class PrestamoService
    {
        private ReportesEntities1 db = new ReportesEntities1();

        private const decimal FONDO_MAXIMO = 5000000;

        public void RegistrarPrestamo(int clienteID, decimal monto, int meses)
        {
            try
            {

                var cliente = db.Clientes.Find(clienteID);
                if (cliente == null) throw new Exception("Cliente no encontrado.");


                if (string.IsNullOrEmpty(cliente.Garantia))
                    throw new Exception("No se puede otorgar el préstamo: El cliente no posee una garantía registrada.");

            
                if (monto > (cliente.Sueldo * 4))
                    throw new Exception($"Monto excedido. El límite para este cliente es {cliente.Sueldo * 4} (4 veces su sueldo).");


                decimal dineroPrestadoActualmente = db.Prestamos.Sum(p => (decimal?)p.Monto) ?? 0;
                if ((dineroPrestadoActualmente + monto) > FONDO_MAXIMO)
                    throw new Exception("Fondos insuficientes en la entidad para realizar este préstamo.");


                decimal tasaAnual = CalcularTasaPorMeses(meses);

                decimal interesGenerado = monto * (tasaAnual / 100);
                decimal montoTotal = monto + interesGenerado;


                Prestamo nuevo = new Prestamo
                {
                    ClienteID = clienteID,
                    Monto = monto,
                    PlazoMeses = meses,
                    TasaInteres = tasaAnual,
                    InteresGenerado = Math.Round(interesGenerado, 2),
                    MontoTotal = Math.Round(montoTotal, 2),
                    FechaInicio = DateTime.Now
                };

                db.Prestamos.Add(nuevo);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private decimal CalcularTasaPorMeses(int meses)
        {
            if (meses >= 1 && meses <= 3) return 10;
            if (meses >= 4 && meses <= 6) return 8;
            if (meses >= 7 && meses <= 12) return 7;
            if (meses > 12) return 5;
            return 10; // Default
        }


        public dynamic ObtenerResumenFinanciero()
        {
            var totalPrestado = db.Prestamos.Sum(p => (decimal?)p.Monto) ?? 0;
            var totalGananciaEsperada = db.Prestamos.Sum(p => (decimal?)p.InteresGenerado) ?? 0;

            return new
            {
                TotalPrestado = totalPrestado,
                GananciaTotal = totalGananciaEsperada
            };
        }

        public List<Prestamo> ListarPorCliente(int clienteID)
        {
            return db.Prestamos.Where(p => p.ClienteID == clienteID).ToList();
        }
    }
}