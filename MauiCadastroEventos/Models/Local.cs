namespace MauiCadastroEventos.Models
{
    public class Local
    {
        public string Descricao2 { get; set; }
        public Evento EventoSelecionado { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int NumeroParticipantes { get; set; }
        public Local LocalSelecionado { get; set; }

        public int Duracao
        {
            get => DataTermino.Subtract(DataInicio).Days;
        }

        public double CustoTotal
        {
            get
            {
                double custo_participantes = NumeroParticipantes * EventoSelecionado.CustoParticipante;

                double total = (custo_participantes) * Duracao;

                return total;
            }
        }
    }
}
