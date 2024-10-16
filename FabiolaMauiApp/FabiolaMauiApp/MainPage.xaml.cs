using FabiolaMauiApp.Models;
using System.Text.Json;

namespace FabiolaMauiApp
{

    public partial class MainPage : ContentPage
    {
		Pessoa pessoa;
        public MainPage()
        {
            InitializeComponent();
        }

		public class Pessoa
		{
			public string Nome { get; set; }
			public string Sobrenome { get; set; }
			public int Idade { get; set; }
			public string Foto { get; set; }
		}

		protected override async void OnAppearing()
		{
			base.OnAppearing();
			await LoadMauiAsset();
		}

		async Task LoadMauiAsset()
		{
			using var stream = await FileSystem.OpenAppPackageFileAsync("demo.json");
			using var reader = new StreamReader(stream);

			var contents = reader.ReadToEnd();

			var pessoa = JsonSerializer.Deserialize<Pessoa>(contents);

			BindingContext = pessoa;


		}


		//	private void CounterBtn_Clicked(object sender, EventArgs e)
		//	{
		//		{
		//			var produto = new Produto
		//			{
		//				Nome = "IPhone 5",
		//				Preco = 5000.00m,
		//				Estoque = 5
		//			};

		//			//Binding produtoBinding = new Binding();
		//			//produtoBinding.Source = produto;
		//			//produtoBinding.Path = "Nome";

		//			Binding nomeBinding = new Binding 
		//			{ Source = produto, 
		//			  Path = "Nome",
		//			  StringFormat = "Produto: {0}" };
		//			lblNome.SetBinding(Label.TextProperty, nomeBinding);
		//			//lblNome.SetBinding(Label.TextProperty, produtoBinding);

		//			Binding precoBinding = new Binding
		//			{
		//				Source = produto,
		//				Path = "Preco",
		//				StringFormat = "Preço: {0}"
		//			};
		//			lblPreco.SetBinding(Label.TextProperty, precoBinding);

		//			Binding estoqueBinding = new Binding
		//			{
		//				Source = produto,
		//				Path = "Estoque",
		//				StringFormat = "Estoque: {0}"
		//			};
		//			lblEstoque.SetBinding(Label.TextProperty, estoqueBinding);
		//		}
		//	}
	}

}
