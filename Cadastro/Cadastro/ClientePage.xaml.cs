using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Cadastro
{
    public partial class ClientePage : ContentPage
    {
        public ClientePage()
        {
            InitializeComponent();

            using (var context = new AcessoDB())
            {
                this.ListaCliente.ItemsSource = context.GetClientes();
            }

        }

        private void Salvar_OnClicked(object sender, EventArgs e)
        {
            var cliente = new Cliente()
            {
                Nome = NomeCliente.Text,
                Email = EmailCliente.Text
            };

            using (var context = new AcessoDB())
            {   
                context.Insert(cliente);
                this.ListaCliente.ItemsSource = context.GetClientes();
            }


        }
    }
}
