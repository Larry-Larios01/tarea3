using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class BinaryEmpleadoRepository : IActivoModel
    {
        private RAFContext<Activo> context;
        private const int SIZE = 800;
        public BinaryEmpleadoRepository()
        {
            context = new RAFContext<Activo>("Empleado", SIZE);
        }
        public void Add(Activo t)
        {
            try
            {
                context.Create<Activo>(t);
            }
            catch (IOException)
            {
                throw;
            }
        }

        public Activo GetById(int id)
        {
            try
            {
                return context.Get<Activo>(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Activo> Read()
        {
            try
            {
                return context.GetAll<Activo>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(Activo t)
        {

            try
            {
                return context.Delete<Activo>(t);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int Update(Activo t)
        {
            try
            {

                return context.Update<Activo>(t);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
