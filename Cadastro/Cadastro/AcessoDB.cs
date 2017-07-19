using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net;
using Xamarin.Forms;

namespace Cadastro
{
    public class AcessoDB: IDisposable
    {
        private SQLiteConnection conn;

        public AcessoDB()
        {
            var config = DependencyService.Get<IConfig>();

            conn = new SQLiteConnection(config.Plataforma, Path.Combine(config.DiretorioSQLite, "Cadastro1.db3"));

            conn.CreateTable<Cliente>();
        }


        public void Insert(Cliente cliente)
        {
            conn.Insert(cliente);
        }

        public void Update(Cliente cliente)
        {
            conn.Update(cliente);
        }

        public void Delete(Cliente cliente)
        {
            conn.Delete(cliente);
        }

        public Cliente GetCliente(int codigo)
        {
            return conn.Table<Cliente>().FirstOrDefault(c => c.Id == codigo);
        }

        public List<Cliente> GetClientes()
        {
            return conn.Table<Cliente>().OrderBy(c => c.Nome).ToList();
        }
        
        public void Dispose()
        {
            conn.Dispose();
        }
    }
}
