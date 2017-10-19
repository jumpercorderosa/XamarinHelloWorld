using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataBindingPage : ContentPage
    {
        public DataBindingPage()
        {
            Aluno aluno = InitAluno("Anderson Silva", "anderson@fiap.com");

            //faz o link do xml com essa classe
            BindingContext = aluno;

            //populo o conteudo antes de inicializar a página
            InitializeComponent();
        }

        private Aluno InitAluno(string nome, string email)
        {
            return new Aluno()
            {
                Id = Guid.NewGuid(),
                Nome = nome,
                Email = email
            };
        }
    }
}