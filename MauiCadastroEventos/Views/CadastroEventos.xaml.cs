using MauiCadastroEventos.Models;

namespace MauiCadastroEventos.Views;

public partial class CadastroEventos : ContentPage
{
	App PropriedadeApp;
	public CadastroEventos()
	{
		InitializeComponent();

		PropriedadeApp = (App)Application.Current;

		pck_nome.ItemsSource = PropriedadeApp.lista_evento;
		pck_local.ItemsSource = PropriedadeApp.lista_local;

		dtpck_inicio.MinimumDate = DateTime.Now;
		dtpck_inicio.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

		dtpck_termino.MinimumDate = dtpck_inicio.Date.AddDays(1);
		dtpck_termino.MaximumDate = dtpck_inicio.Date.AddMonths(3);
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		try
		{
			Local c = new Local
			{
				 EventoSelecionado = (Evento)pck_nome.SelectedItem,
				 LocalSelecionado = (Local)pck_local.SelectedItem,
				 NumeroParticipantes = Convert.ToInt32(num_part.Value),				 
				 DataInicio = dtpck_inicio.Date,
				 DataTermino = dtpck_termino.Date,
			};

			await Navigation.PushAsync(new ResumoEvento()
			{
				BindingContext = c
			});

		}catch (Exception ex)
		{
			await DisplayAlert("Ops", ex.Message, "OK");
		}
		}

    private void dtpck_inicio_DateSelected(object sender, DateChangedEventArgs e)
    {
		DatePicker elemento = sender as DatePicker;

		DateTime data_selecionada_inicio = elemento.Date;

		dtpck_termino.MinimumDate = data_selecionada_inicio.AddDays(1);
		dtpck_termino.MaximumDate = data_selecionada_inicio.AddMonths(3);
    }
}