using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFTutorial.Audio_and_Video
{
    /// <summary>
    /// Lógica de interacción para SpeechRecognitionApp.xaml
    /// </summary>
    public partial class SpeechRecognitionApp : Window
    {
        public SpeechRecognitionApp()
        {
            InitializeComponent();
        }

        private void btnHablar_Click(object sender, RoutedEventArgs e)
        {
            // Create an in-process speech recognizer for the en-US locale.
            using (
            SpeechRecognitionEngine recognizer =
              new SpeechRecognitionEngine(
                new System.Globalization.CultureInfo("ES-es")))
            {

                // Create and load a dictation grammar.
                recognizer.LoadGrammar(new DictationGrammar());

                // Add a handler for the speech recognized event.
                recognizer.SpeechRecognized +=
                  new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);

                // Configure input to the speech recognizer.
                recognizer.SetInputToDefaultAudioDevice();
                //recognizer.SetInputToWaveFile("C:\\Users\\bcgutierrez\\Desktop\\kalimba.wav");

                // Start asynchronous, continuous speech recognition.
                recognizer.RecognizeAsync(RecognizeMode.Multiple);

                // Keep the console window open.
                while (true)
                {
                    Console.ReadLine();
                }
            }
        }

        // Handle the SpeechRecognized event.
        void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            Console.WriteLine("Recognized text: " + e.Result.Text);
        }
    }
}
