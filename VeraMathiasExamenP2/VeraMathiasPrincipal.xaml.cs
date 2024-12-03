using VeraMathiasExamenP2.Repositories;

namespace VeraMathiasExamenP2;

public partial class VeraMathiasPrincipal : ContentPage
{
	public VeraMathiasPrincipal()
	{
		InitializeComponent();

		RecargasRepositorio recargasRepositorio = new RecargasRepositorio();
		var infoRecarga = recargasRepositorio.DevuelveInfoRecarga();

		BindingContext=infoRecarga;
	}
}