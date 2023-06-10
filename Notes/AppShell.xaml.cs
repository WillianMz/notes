namespace Notes;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        //registra a rota de navegacao
        //O primeiro parâmetro é o nome da cadeia de caracteres do URI que você deseja registrar, nesse caso, o nome resolvido é "NotePage".
        //O segundo parâmetro é o tipo de página a ser carregada quando "NotePage" é navegada.
        Routing.RegisterRoute(nameof(Views.NotePage), typeof(Views.NotePage));
    }
}
