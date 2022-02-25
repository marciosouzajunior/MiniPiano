using MiniPiano;
using Plugin.SimpleAudioPlayer;
using System;
using System.IO;
using System.Reflection;
using Xamarin.Forms;

[assembly: Dependency(typeof(Piano))]
namespace MiniPiano
{
    public class Piano : IPiano
    {

        // White keys
        ISimpleAudioPlayer A0 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer B0 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        
        ISimpleAudioPlayer C1 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer D1 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer E1 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer F1 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer G1 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer A1 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer B1 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

        ISimpleAudioPlayer C2 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer D2 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer E2 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer F2 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer G2 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer A2 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer B2 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

        ISimpleAudioPlayer C3 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer D3 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer E3 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer F3 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer G3 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer A3 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer B3 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

        ISimpleAudioPlayer C4 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer D4 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer E4 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer F4 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer G4 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer A4 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer B4 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

        ISimpleAudioPlayer C5 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer D5 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer E5 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer F5 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer G5 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer A5 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer B5 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

        ISimpleAudioPlayer C6 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer D6 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer E6 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer F6 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer G6 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer A6 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer B6 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

        ISimpleAudioPlayer C7 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer D7 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer E7 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer F7 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer G7 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer A7 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer B7 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

        ISimpleAudioPlayer C8 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

        // Black keys

        public Piano()
        {

            var assembly = typeof(App).GetTypeInfo().Assembly;

            A0.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.A0.mp3"));
            B0.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.B0.mp3"));
        
            C1.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.C1.mp3"));
            D1.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.D1.mp3"));
            E1.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.E1.mp3"));
            F1.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.F1.mp3"));
            G1.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.G1.mp3"));
            A1.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.A1.mp3"));
            B1.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.B1.mp3"));

            C2.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.C2.mp3"));
            D2.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.D2.mp3"));
            E2.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.E2.mp3"));
            F2.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.F2.mp3"));
            G2.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.G2.mp3"));
            A2.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.A2.mp3"));
            B2.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.B2.mp3"));

            C3.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.C3.mp3"));
            D3.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.D3.mp3"));
            E3.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.E3.mp3"));
            F3.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.F3.mp3"));
            G3.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.G3.mp3"));
            A3.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.A3.mp3"));
            B3.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.B3.mp3"));

            C4.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.C4.mp3"));
            D4.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.D4.mp3"));
            E4.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.E4.mp3"));
            F4.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.F4.mp3"));
            G4.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.G4.mp3"));
            A4.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.A4.mp3"));
            B4.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.B4.mp3"));

            C5.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.C5.mp3"));
            D5.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.D5.mp3"));
            E5.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.E5.mp3"));
            F5.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.F5.mp3"));
            G5.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.G5.mp3"));
            A5.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.A5.mp3"));
            B5.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.B5.mp3"));

            C6.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.C6.mp3"));
            D6.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.D6.mp3"));
            E6.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.E6.mp3"));
            F6.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.F6.mp3"));
            G6.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.G6.mp3"));
            A6.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.A6.mp3"));
            B6.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.B6.mp3"));

            C7.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.C7.mp3"));
            D7.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.D7.mp3"));
            E7.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.E7.mp3"));
            F7.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.F7.mp3"));
            G7.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.G7.mp3"));
            A7.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.A7.mp3"));
            B7.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.B7.mp3"));

            C8.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.C8.mp3"));

        }


        public void Play(string note)
        {
            // Reflection
            ISimpleAudioPlayer player = (ISimpleAudioPlayer) GetType()
                .GetField(note, BindingFlags.NonPublic | BindingFlags.Instance)
                .GetValue(this);
            player.GetType().GetMethod("Play").Invoke(player, null);
        }
    }
}
