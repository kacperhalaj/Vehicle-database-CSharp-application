using System;
using System.Windows.Forms;

namespace Projekt
{
    public partial class SplashScreen : Form
    {
        // Timer do obsługi ładowania
        private System.Windows.Forms.Timer timer;

        public SplashScreen()
        {
            InitializeComponent();

            // Inicjalizacja timera
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 100; // Co 100 ms
            timer.Tick += Timer_Tick; // Obsługa zdarzenia Tick
            timer.Start(); // Uruchom timer
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Zwiększanie wartości ProgressBar
            progressBar1.Increment(5); // Dodanie 5% do paska przy każdym Tick

            // Sprawdzenie, czy ProgressBar osiągnął maksimum
            if (progressBar1.Value >= 100)
            {
                timer.Stop(); // Zatrzymanie timera
                this.Hide(); // Ukrycie SplashScreen

                // Otwórz okno LoginForm
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }
    }
}