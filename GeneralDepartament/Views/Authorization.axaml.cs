using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using GeneralDepartament.Models;
using GeneralDepartament.ViewModels;
using Newtonsoft.Json;

namespace GeneralDepartament.Views;

public partial class Authorization : Window
{
    public Authorization()
    {
        InitializeComponent();
    }

    private async void Login_Click(object? sender, RoutedEventArgs e)
    {
        HttpClient Client = new();
        var Responce = await Client.PostAsJsonAsync("https://localhost:44346/gplogin?code="+boxCode.Text,"");
        if (!Responce.IsSuccessStatusCode)
        {
            //Пиздец короче
            return;
        }

        var StringResponse = await Responce.Content.ReadAsStringAsync();
        var ObjectResponse = JsonConvert.DeserializeObject<ResponceApi.ResponseLogin>(StringResponse);
        MainWindow nexWin = new()
        {
            DataContext = new MainWindowViewModel()
            {
                User = ObjectResponse.data
            }
        };
        nexWin.Show();
        Close();
    }
}