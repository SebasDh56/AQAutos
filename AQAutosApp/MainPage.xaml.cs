using AQAutosApp.Models;
using Newtonsoft.Json;

namespace AQAutosApp
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

       

        private void Button_Clicked(object sender, EventArgs e)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7140/api/");
            var response=client.GetAsync("AQAuto").Result;

            if (response.IsSuccessStatusCode) {

                var AQAutos=response.Content.ReadAsStringAsync().Result;
                var AQAutosList = JsonConvert.DeserializeObject<List<AQAuto>>(AQAutos);
                listVIew.ItemsSource = AQAutosList;



            }
        }
    }

}
