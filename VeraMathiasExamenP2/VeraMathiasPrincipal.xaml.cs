using VeraMathiasExamenP2.Repositories;

namespace VeraMathiasExamenP2;

public partial class VeraMathiasPrincipal : ContentPage
{
    RecargasRepositorio recargasRepositorio = new RecargasRepositorio();
    public VeraMathiasPrincipal()
	{
		InitializeComponent();
		var infoRecarga = recargasRepositorio.DevuelveInfoRecarga();

		BindingContext=infoRecarga;
	}
}