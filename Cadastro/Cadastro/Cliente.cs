using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;

namespace Cadastro
{
    public    class Cliente
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Nome { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", Nome, Email);
        }
    }
}
