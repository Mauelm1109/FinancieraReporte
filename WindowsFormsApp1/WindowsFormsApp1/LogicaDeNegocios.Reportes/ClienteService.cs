using System;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp1.AccesoDatosReportes;
using System.Data.Entity;

namespace WindowsFormsApp1.LogicaDeNegocios.Reportes
{
    public class ClienteService
    {
        private ReportesEntities1 db = new ReportesEntities1();


        public Cliente ObtenerDetalleCliente(int id)
        {

            return db.Clientes.Find(id);
        }

        public void RegistrarCliente(string nombre, string correo, string tel, string dir, string garantia, decimal sueldo)
        {
            try
            {
                if (db.Clientes.Any(c => c.Correo == correo))
                    throw new Exception("Ya existe un cliente registrado con este correo electrónico.");

                Cliente nuevo = new Cliente
                {
                    NombreCompleto = nombre,
                    Correo = correo,
                    Telefono = tel,
                    Direccion = dir,
                    Garantia = garantia,
                    Sueldo = sueldo
                };

                db.Clientes.Add(nuevo);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar cliente: " + ex.Message);
            }
        }


        public void ActualizarDatosPersonales(int id, string nombre, string correo, string tel, string dir, string garantia, decimal sueldo)
        {
            try
            {
                var cliente = db.Clientes.Find(id);
                if (cliente != null)
                {
                    cliente.NombreCompleto = nombre;
                    cliente.Correo = correo;
                    cliente.Telefono = tel;
                    cliente.Direccion = dir;
                    cliente.Garantia = garantia;
                    cliente.Sueldo = sueldo;

                    db.Entry(cliente).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo actualizar la información: " + ex.Message);
            }
        }

        public dynamic ObtenerEstadoCrediticio(int clienteID)
        {
            var prestamos = db.Prestamos
                .Where(p => p.ClienteID == clienteID)
                .Select(p => new
                {
                    ID = p.PrestamoID,
                    MontoOriginal = p.Monto,
                    MontoActualADeber = p.MontoTotal,
                    Plazo = p.PlazoMeses + " meses",
                    Tasa = p.TasaInteres + "%",
                    Inicio = p.FechaInicio
                }).ToList();

            return prestamos;
        }


        public void EliminarCliente(int id)
        {
            try
            {
                var cliente = db.Clientes.Find(id);
                if (cliente != null)
                {

                    db.Clientes.Remove(cliente);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new Exception("Imposible eliminar: El cliente tiene préstamos o historial activo en la financiera.");
            }
        }
    }
}