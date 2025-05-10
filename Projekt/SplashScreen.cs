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
            timer.Interval = 100; 
            timer.Tick += Timer_Tick; 
            timer.Start(); 
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // ProgressBar
            progressBar1.Increment(5); 


            if (progressBar1.Value >= 100)
            {
                timer.Stop(); 
                this.Hide(); 

                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }
    }
}