using System;
using System.Net.Http;
using System.Windows.Forms;

namespace CloudLauncher {
    static class Program
    {
        public static string dll = "Rain.dll";
        public static string launcher = "FortniteLauncher.exe";
        public static string client = "FortniteClient-Win64-Shipping";
        public static string server = "http://localhost:6954";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Launcher());
        }

        public static string HTTPGet(string url) {
            
            using (HttpClient httpClient = new HttpClient()) {
                try {
                    HttpResponseMessage response = httpClient.GetAsync(url).Result;
                    if (response.IsSuccessStatusCode) {
                        return response.Content.ReadAsStringAsync().Result;
                    } else {
                        throw new HttpRequestException($"HTTP Error: {response.StatusCode}");
                    }
                } catch (Exception ex) {
                    throw new HttpRequestException($"Request Error: {ex.Message} at request {url}");
                }
            }
        }
    }
}
