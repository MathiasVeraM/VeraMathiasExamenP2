using VeraMathiasExamenP2.Models;
using VeraMathiasExamenP2.Repositories;

namespace VeraMathiasExamenP2;

public partial class VeraMathiasPrincipal : ContentPage
{
    VeraMathiasRecarga mathiasRecarga = new VeraMathiasRecarga();
    RecargasRepositorio recargasRepositorio = new RecargasRepositorio();
    public VeraMathiasPrincipal()
	{
		InitializeComponent();
		var infoRecarga = recargasRepositorio.DevuelveInfoRecarga();

		BindingContext=infoRecarga;
	}

    private void BotonRecargar_Clicked(object sender, EventArgs e)
    {
        VeraMathiasRecarga veraMathiasRecarga=new VeraMathiasRecarga
        {
            Numero = Int32.Parse(mveraEditor1Principal.Text),
            Nombre = mveraEditor2Principal.Text
        };
    }
}