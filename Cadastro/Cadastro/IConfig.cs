﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Interop;

namespace Cadastro
{
    public interface IConfig
    {
        string DiretorioSQLite { get; }

        ISQLitePlatform Plataforma { get; }
    }
}
