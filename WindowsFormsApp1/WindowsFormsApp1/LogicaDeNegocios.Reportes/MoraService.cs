using System;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp1.AccesoDatosReportes;
using System.Data.Entity;

namespace WindowsFormsApp1.LogicaDeNegocios.Reportes
{
    public class MoraService
    {
        private ReportesEntities1 db = new ReportesEntities1();


        public void RegistrarMora(int prestamoID, int mes, decimal montoCuota)
        {
            try
            {
                var prestamo = db.Prestamos.Find(prestamoID);
                if (prestamo == null) throw new Exception("Préstamo no encontrado.");

                decimal montoMora = montoCuota * 0.10m;

                Mora nuevaMora = new Mora
                {
                    PrestamoID = prestamoID,
                    ClienteID = prestamo.ClienteID,
                    Mes = mes,
                    MontoMora = montoMora,
                    FechaMora = DateTime.Now
                };

                db.Moras.Add(nuevaMora);
                db.SaveChanges();

                VerificarYRegistrarClienteMoroso(prestamo.ClienteID);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar la mora: " + ex.Message);
            }
        }

        private void VerificarYRegistrarClienteMoroso(int clienteID)
        {

            int totalMoras = db.Moras.Count(m => m.ClienteID == clienteID);

            if (totalMoras >= 3)
            {

                var yaEsMoroso = db.ClientesMorosos.Any(cm => cm.ClienteID == clienteID);

                if (!yaEsMoroso)
                {
                    ClientesMoroso moroso = new ClientesMoroso
                    {
                        ClienteID = clienteID,
                        CantidadMoras = totalMoras,
                        FechaRegistro = DateTime.Now
                    };
                    db.ClientesMorosos.Add(moroso);
                }
                else
                {

                    var registro = db.ClientesMorosos.FirstOrDefault(cm => cm.ClienteID == clienteID);
                    registro.CantidadMoras = totalMoras;
                }

                db.SaveChanges();
            }
        }


        public dynamic ObtenerMorasPorCliente()
        {
            return db.Moras
                .GroupBy(m => m.Cliente.NombreCompleto)
                .Select(g => new
                {
                    Cliente = g.Key,
                    CantidadMoras = g.Count(),
                    TotalPenalizaciones = g.Sum(x => x.MontoMora)
                }).ToList();
        }


        public List<ClientesMoroso> ListarClientesMorosos()
        {

            return db.ClientesMorosos.Include(cm => cm.Cliente).ToList();
        }
    }
}