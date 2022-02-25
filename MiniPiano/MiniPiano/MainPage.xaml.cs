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
            Queue<string> whiteKeys = new Queue<string>(new string[]{
                "A0", "B0",
                "C1", "D1", "E1", "F1", "G1", "A1", "B1",
                "C2", "D2", "E2", "F2", "G2", "A2", "B2",
                "C3", "D3", "E3", "F3", "G3", "A3", "B3",
                "C4", "D4", "E4", "F4", "G4", "A4", "B4",
                "C5", "D5", "E5", "F5", "G5", "A5", "B5",
                "C6", "D6", "E6", "F6", "G6", "A6", "B6",
                "C7", "D7", "E7", "F7", "G7", "A7", "B7",
                "C8"
            });

            for (int i = 1; i <= whiteKeys.Count; i++)
            {

                BoxView whiteKey = new BoxView();
                whiteKey.BackgroundColor = Color.White;
                whiteKey.Margin = 2;
                AbsoluteLayout.SetLayoutFlags(whiteKey, AbsoluteLayoutFlags.WidthProportional);
                AbsoluteLayout.SetLayoutBounds(whiteKey, new Rectangle(0, yPosition, 1, 100));
                yPosition += 100;

                TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
                tapGestureRecognizer.Tapped += KeyTapped;
                tapGestureRecognizer.CommandParameter = whiteKeys.Dequeue();
                whiteKey.GestureRecognizers.Add(tapGestureRecognizer);

                pianoLayout.Children.Add(whiteKey);

            }

            // Black keys
            //yPosition = 75;
            //int[] steps = new int[] { 3, 7, 10, 14, 17, 21, 24, 28, 31, 35, 38, 42, 45, 49, 52, 56 };
            //Queue<string> blackKeys = new Queue<string>(new string[]{
            //    "Db1", "Eb1", "Gb1", "Ab1", "Bb1",
            //    "Db2", "Eb2", "Gb2", "Ab2", "Bb2",
            //    "Db3", "Eb3", "Gb3", "Ab3", "Bb3",
            //    "Db4", "Eb4", "Gb4", "Ab4", "Bb4",
            //    "Db5", "Eb5", "Gb5", "Ab5", "Bb5",
            //    "Db6", "Eb6", "Gb6", "Ab6", "Bb6",
            //    "Db7", "Eb7", "Gb7", "Ab7", "Bb7"
            //});

            //for (int i = 1; i <= 56; i++)
            //{

            //    if (i > 1)
            //    {
            //        yPosition += 100;
            //    }

            //    if (steps.Contains(i))
            //    {
            //        continue;
            //    }

            //    BoxView blackKey = new BoxView();
            //    blackKey.BackgroundColor = Color.Black;
            //    blackKey.Margin = 2;
            //    AbsoluteLayout.SetLayoutFlags(blackKey, AbsoluteLayoutFlags.WidthProportional | AbsoluteLayoutFlags.XProportional);
            //    AbsoluteLayout.SetLayoutBounds(blackKey, new Rectangle(1, yPosition, 0.6, 50));

            //    TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
            //    tapGestureRecognizer.Tapped += KeyTapped;
            //    tapGestureRecognizer.CommandParameter = blackKeys.Dequeue();
            //    blackKey.GestureRecognizers.Add(tapGestureRecognizer);

            //    pianoLayout.Children.Add(blackKey);

            //}

        }

        private void KeyTapped(object sender, EventArgs e)
        {
            TappedEventArgs tappedEventArgs = e as TappedEventArgs;
            string note = tappedEventArgs.Parameter as string;
            piano.Play(note);
        }
    }
}
