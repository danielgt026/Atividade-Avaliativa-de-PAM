using Microsoft.Maui.Controls.PlatformConfiguration;
using MysticPartyTracker.ViewModels;
using System.Security.Cryptography.X509Certificates;

namespace MysticPartyTracker.Views;

public partial class DiceView : ContentPage
{
    int valor = 0;
    public DiceView()
    {
        InitializeComponent();
        Lados.SelectedIndex = 0;
        BindingContext = new DiceViewModel();
    }
    private void RollBtn_Clicked(object sender, EventArgs e)
    {
        if (Lados.SelectedItem == null || Dados.SelectedItem == null)
        {
            ResultLabel.Text = "SELECIONAR A QUANTIDADE DE DADOS E LADOS DOIDÃO";
            return;
        }

        int numLados = Convert.ToInt32(Lados.SelectedItem);
        int numDados = Convert.ToInt32(Lados.SelectedItem);

        List<int> Resultados = new List<int>();

        Random random = new Random();

        for (int i = 0; i < numDados; i++)
        {
            int valorsorteado = random.Next(1, numLados + 1);
            Resultados.Add(valorsorteado);
        }

        int Soma = Resultados.Sum();

        ResultLabel.Text = $"Você Rolou: {string.Join(",", Resultados)}";

        ResultadoSoma.Text = $"A soma dos Dados: {string.Join(",", Soma)}";

 
    }
}