using System;
using System.Speech.Synthesis;
namespace textToaudio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize a new instance of the SpeechSynthesizer.  
            SpeechSynthesizer synth = new SpeechSynthesizer();
            
            // Configure the audio output.   
            synth.SetOutputToDefaultAudioDevice();
            
            // Speak a string.
            string value = "This example demonstrates a basic use of Speech Synthesizer";
            synth.Speak(value);

            Console.ReadKey();
        }
    }
}
