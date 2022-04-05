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
    public class BinaryEmpleadoRepository : IEmpleadoModel
    {
        private RAFContext context;
        private const int SIZE = 800;
        public BinaryEmpleadoRepository()
        {
            context = new RAFContext("Empleado", SIZE);
        }
        public void Add(Empleado t)
        {
            try
            {
                context.Create<Empleado>(t);
            }
            catch (IOException)
            {
                throw;
            }
        }

        public Empleado GetById(int id)
        {
            try
            {
                return context.Get<Empleado>(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Empleado> Read()
        {
            try
            {
                return context.GetAll<Empleado>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(Empleado t)
        {

            try
            {
                return context.Delete<Empleado>(t);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int Update(Empleado t)
        {
            try
            {

                return context.Update<Empleado>(t);
            }
            catch (Exception)
            {

                throw;
            }
        }

        
    }
}
