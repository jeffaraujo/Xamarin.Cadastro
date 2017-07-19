using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite.Net.Interop;
using SQLite.Net.Platform.XamarinAndroid;
using Xamarin.Forms;
using Environment = System.Environment;

[assembly: Dependency(typeof(Cadastro.Droid.Config))]

namespace Cadastro.Droid
{
    public class Config: IConfig
    {
        private string _diretorioSQLite;
        private SQLite.Net.Interop.ISQLitePlatform _platforma;
        public string DiretorioSQLite
        {
            get
            {
                if (string.IsNullOrEmpty(_diretorioSQLite))
                {
                    _diretorioSQLite = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                }   
                return _diretorioSQLite;
            }
        }

        public ISQLitePlatform Plataforma
        {
            get
            {

                if (_platforma == null)
                {
                    _platforma = new SQLitePlatformAndroid();
                }

                return _platforma;
            }


        }
    }
}