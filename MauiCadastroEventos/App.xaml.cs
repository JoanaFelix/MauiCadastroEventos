
using MauiCadastroEventos.Models;

namespace MauiCadastroEventos
{
    public partial class App : Application
    {
        public List<Evento> lista_evento = new List<Evento>
        {
            new Evento()
            {
                Descricao = "Casamento",
                CustoParticipante = 300.0,
            },
             new Evento()
            {
                Descricao = "Formatura",
                CustoParticipante = 250.0,
            },
              new Evento()
            {
                Descricao = "Aniversário",
                CustoParticipante = 200.0,
            },
               new Evento()
            {
                Descricao = "Workshop",
                CustoParticipante = 150.0,
            },
                new Evento()
            {
                Descricao = "Treinamento",
                CustoParticipante = 100.0,
            }
        };

        public List<Local> lista_local = new List<Local>
        {
           new Local()
           {
               Descricao2 = "Salão de Festa"
           },
            new Local()
           {
               Descricao2 = "Salão de Workshop"
           },
             new Local()
           {
               Descricao2 = "Área Externa"
           },
        };
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.CadastroEventos());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}
