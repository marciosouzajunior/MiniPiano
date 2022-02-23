using Plugin.SimpleAudioPlayer;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using Xamarin.Forms;

namespace MiniPiano
{
    public partial class MainPage : ContentPage
    {

        ISimpleAudioPlayer player;

        public MainPage()
        {
            InitializeComponent();

            var assembly = typeof(App).GetTypeInfo().Assembly;
            Stream audioStream = assembly.GetManifestResourceStream("MiniPiano.Sounds.G3.mp3");


            player = CrossSimpleAudioPlayer.Current;
            player.Load(audioStream);


        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            DrawLayout();
        }

        private void DrawLayout()
        {

            // White keys
            int yPosition = 0;

            for (int i = 1; i <= 56; i++)
            {

                BoxView whiteKey = new BoxView();
                whiteKey.BackgroundColor = Color.White;
                whiteKey.Margin = 2;
                AbsoluteLayout.SetLayoutFlags(whiteKey, AbsoluteLayoutFlags.WidthProportional);
                AbsoluteLayout.SetLayoutBounds(whiteKey, new Rectangle(0, yPosition, 1, 100));
                yPosition += 100;

                TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
                tapGestureRecognizer.Tapped += WhiteKeyTapped;
                tapGestureRecognizer.CommandParameter = i;
                whiteKey.GestureRecognizers.Add(tapGestureRecognizer);

                pianoLayout.Children.Add(whiteKey);

            }

            // Black keys
            yPosition = 75;
            int[] steps = new int[] { 3, 7, 10, 14, 17, 21, 24, 28, 31, 35, 38, 42, 45, 49, 52, 56 };

            for (int i = 1; i <= 56; i++)
            {

                if (i > 1)
                {
                    yPosition += 100;
                }

                if (steps.Contains(i))
                {
                    continue;
                }

                BoxView blackKey = new BoxView();
                blackKey.BackgroundColor = Color.Black;
                blackKey.Margin = 2;
                AbsoluteLayout.SetLayoutFlags(blackKey, AbsoluteLayoutFlags.WidthProportional | AbsoluteLayoutFlags.XProportional);
                AbsoluteLayout.SetLayoutBounds(blackKey, new Rectangle(1, yPosition, 0.6, 50));

                TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
                tapGestureRecognizer.Tapped += WhiteKeyTapped;
                tapGestureRecognizer.CommandParameter = i;
                blackKey.GestureRecognizers.Add(tapGestureRecognizer);

                pianoLayout.Children.Add(blackKey);

            }

        }

        private void WhiteKeyTapped(object sender, EventArgs e)
        {
            TappedEventArgs tappedEventArgs = e as TappedEventArgs;
            Debug.WriteLine("parameter: " + tappedEventArgs.Parameter);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            player.Play();
            // Frame f = sender as Frame;
            //Console.WriteLine(f.Width);
        }
    }
}
