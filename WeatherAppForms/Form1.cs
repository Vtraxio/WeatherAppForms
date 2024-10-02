using System.Net.Http.Json;

namespace WeatherAppForms {
    public partial class Form1 : Form
    {
        private HttpClient http;

		private Dictionary<int, string> wmoDictionary = new(){
			{ 0, "Bezchmurnie" },                          // Clear sky
			{ 1, "G³ównie bezchmurnie" },                  // Mainly clear
			{ 2, "Czêœciowo pochmurnie" },                 // Partly cloudy
			{ 3, "Pochmurnie" },                           // Overcast
			{ 45, "Mg³a" },                                // Fog
			{ 48, "Szronowa mg³a" },                       // Depositing rime fog
			{ 51, "Lekkie m¿awka" },                       // Light drizzle
			{ 53, "Umiarkowana m¿awka" },                  // Moderate drizzle
			{ 55, "Intensywna m¿awka" },                   // Dense drizzle
			{ 56, "Lekkie marzn¹ce opady" },               // Light freezing drizzle
			{ 57, "Gêste marzn¹ce opady" },                // Dense freezing drizzle
			{ 61, "Lekkie opady deszczu" },                // Slight rain
			{ 63, "Umiarkowane opady deszczu" },           // Moderate rain
			{ 65, "Intensywne opady deszczu" },            // Heavy rain
			{ 66, "Lekkie marzn¹ce opady deszczu" },       // Light freezing rain
			{ 67, "Silne marzn¹ce opady deszczu" },        // Heavy freezing rain
			{ 71, "Lekkie opady œniegu" },                 // Slight snow fall
			{ 73, "Umiarkowane opady œniegu" },            // Moderate snow fall
			{ 75, "Intensywne opady œniegu" },             // Heavy snow fall
			{ 77, "Œnie¿ne ziarna" },                      // Snow grains
			{ 80, "Lekkie przelotne opady deszczu" },      // Slight rain showers
			{ 81, "Umiarkowane przelotne opady deszczu" }, // Moderate rain showers
			{ 82, "Intensywne przelotne opady deszczu" },  // Violent rain showers
			{ 85, "Lekkie przelotne opady œniegu" },       // Slight snow showers
			{ 86, "Silne przelotne opady œniegu" },        // Heavy snow showers
			{ 95, "Burza" },                               // Thunderstorm
			{ 96, "Burza z lekkim gradem" },               // Thunderstorm with slight hail
			{ 99, "Burza z intensywnym gradem" }           // Thunderstorm with heavy hail
		};

        public Form1()
        {
            InitializeComponent();
            http = new HttpClient()
            {
                BaseAddress = new Uri("https://api.open-meteo.com/")
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update();
		}

        private void Form1_Load(object sender, EventArgs e)
        {
            Update();
        }

        private void ApiUpdate_Tick(object sender, EventArgs e)
        {
			Update();
        }

		private void Update() {
			var weather = http.GetFromJsonAsync<Weather>("/v1/forecast?latitude=54.36&longitude=18.64&current=temperature_2m,relative_humidity_2m,rain,weather_code").Result;
			listData.Items.Clear();

			var temperature = new ListViewItem("Temperatura");
			temperature.SubItems.Add($"{weather.current.temperature_2m}°C");
			listData.Items.Add(temperature);

			var humidity = new ListViewItem("Wilgotnoœæ");
			humidity.SubItems.Add($"{weather.current.relative_humidity_2m}%");
			listData.Items.Add(humidity);

			var rain = new ListViewItem("Deszcz");
			rain.SubItems.Add($"{weather.current.rain}mm");
			rain.SubItems.Add("Suma w ostani¹ godzinê.");
			listData.Items.Add(rain);

			var status = new ListViewItem("Ogólny stan");
			status.SubItems.Add($"{wmoDictionary[weather.current.weather_code]}");
			listData.Items.Add(status);

            update.Text = $"Ostatnia aktualizacja: {DateTime.Now}";
        }
    }
}