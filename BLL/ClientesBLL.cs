using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Jordy_P2_AP2.Dal;
using Jordy_P2_AP2.Models;

namespace Jordy_P2_AP2.BLL
{
    public class ClientesBLL
    {
        public static List<Clientes> GetList(Expression<Func<Clientes, bool>> cliente)
        {
            List<Clientes> Lista = new List<Clientes>();
            Contexto contexto = new Contexto();

            try
            {
                Lista = contexto.Clientes.Where(cliente).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return Lista;
        }
    }
}
