using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace MiniPiano
{
    public partial class MainPage : ContentPage
    {
        IPiano piano = DependencyService.Get<IPiano>();

        public MainPage()
        {
            InitializeComponent();
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
            for (int key = 0; key < piano.WhiteKeys.Length; key++)
            {

                BoxView whiteKey = new BoxView();
                whiteKey.BackgroundColor = Color.White;
                whiteKey.Margin = 2;
                AbsoluteLayout.SetLayoutFlags(whiteKey, AbsoluteLayoutFlags.WidthProportional);
                AbsoluteLayout.SetLayoutBounds(whiteKey, new Rectangle(0, yPosition, 1, 100));
                yPosition += 100;

                TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
                tapGestureRecognizer.Tapped += KeyTapped;
                tapGestureRecognizer.CommandParameter = piano.WhiteKeys[key];
                whiteKey.GestureRecognizers.Add(tapGestureRecognizer);

                pianoLayout.Children.Add(whiteKey);

            }

            // Black keys
            yPosition = 75;
            for (int key = 0; key < piano.BlackKeys.Length; key++)
            {

                // Step
                if (piano.BlackKeys[key] == "")
                {
                    yPosition += 100;
                    continue;
                }

                BoxView blackKey = new BoxView();
                blackKey.BackgroundColor = Color.Black;
                blackKey.Margin = 2;
                AbsoluteLayout.SetLayoutFlags(blackKey, AbsoluteLayoutFlags.WidthProportional | AbsoluteLayoutFlags.XProportional);
                AbsoluteLayout.SetLayoutBounds(blackKey, new Rectangle(1, yPosition, 0.6, 50));
                yPosition += 100;

                TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
                tapGestureRecognizer.Tapped += KeyTapped;
                tapGestureRecognizer.CommandParameter = piano.BlackKeys[key];
                blackKey.GestureRecognizers.Add(tapGestureRecognizer);

                pianoLayout.Children.Add(blackKey);

            }

        }

        private void KeyTapped(object sender, EventArgs e)
        {
            TappedEventArgs tappedEventArgs = e as TappedEventArgs;
            string note = tappedEventArgs.Parameter as string;
            piano.Play(note);
        }
    }
}
