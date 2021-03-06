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
        //
        // White keys
        //
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

        //
        // Black keys
        //
        ISimpleAudioPlayer Bb0 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

        ISimpleAudioPlayer Db1 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer Eb1 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer Gb1 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer Ab1 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer Bb1 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

        ISimpleAudioPlayer Db2 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer Eb2 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer Gb2 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer Ab2 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer Bb2 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

        ISimpleAudioPlayer Db3 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer Eb3 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer Gb3 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer Ab3 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer Bb3 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

        ISimpleAudioPlayer Db4 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer Eb4 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer Gb4 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer Ab4 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer Bb4 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

        ISimpleAudioPlayer Db5 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer Eb5 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer Gb5 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer Ab5 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer Bb5 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

        ISimpleAudioPlayer Db6 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer Eb6 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer Gb6 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer Ab6 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer Bb6 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

        ISimpleAudioPlayer Db7 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer Eb7 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer Gb7 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer Ab7 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer Bb7 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

        ISimpleAudioPlayer Db8 = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

        public Piano()
        {

            var assembly = typeof(App).GetTypeInfo().Assembly;

            //
            // White keys
            //
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

            //
            // Black keys
            //
            Bb0.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.Bb0.mp3"));

            Db1.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.Db1.mp3"));
            Eb1.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.Eb1.mp3"));
            Gb1.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.Gb1.mp3"));
            Ab1.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.Ab1.mp3"));
            Bb1.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.Bb1.mp3"));

            Db2.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.Db2.mp3"));
            Eb2.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.Eb2.mp3"));
            Gb2.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.Gb2.mp3"));
            Ab2.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.Ab2.mp3"));
            Bb2.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.Bb2.mp3"));

            Db3.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.Db3.mp3"));
            Eb3.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.Eb3.mp3"));
            Gb3.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.Gb3.mp3"));
            Ab3.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.Ab3.mp3"));
            Bb3.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.Bb3.mp3"));

            Db4.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.Db4.mp3"));
            Eb4.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.Eb4.mp3"));
            Gb4.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.Gb4.mp3"));
            Ab4.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.Ab4.mp3"));
            Bb4.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.Bb4.mp3"));

            Db5.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.Db5.mp3"));
            Eb5.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.Eb5.mp3"));
            Gb5.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.Gb5.mp3"));
            Ab5.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.Ab5.mp3"));
            Bb5.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.Bb5.mp3"));

            Db6.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.Db6.mp3"));
            Eb6.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.Eb6.mp3"));
            Gb6.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.Gb6.mp3"));
            Ab6.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.Ab6.mp3"));
            Bb6.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.Bb6.mp3"));

            Db7.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.Db7.mp3"));
            Eb7.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.Eb7.mp3"));
            Gb7.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.Gb7.mp3"));
            Ab7.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.Ab7.mp3"));
            Bb7.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.Bb7.mp3"));

            Db8.Load(assembly.GetManifestResourceStream("MiniPiano.Sounds.Db8.mp3"));

        }

        public string[] WhiteKeys => new string[]{
            "A0", "B0",
            "C1", "D1", "E1", "F1", "G1", "A1", "B1",
            "C2", "D2", "E2", "F2", "G2", "A2", "B2",
            "C3", "D3", "E3", "F3", "G3", "A3", "B3",
            "C4", "D4", "E4", "F4", "G4", "A4", "B4",
            "C5", "D5", "E5", "F5", "G5", "A5", "B5",
            "C6", "D6", "E6", "F6", "G6", "A6", "B6",
            "C7", "D7", "E7", "F7", "G7", "A7", "B7",
            "C8"
            };

        public string[] BlackKeys => new string[]{
            "Bb0",
            "", "Db1", "Eb1", "", "Gb1", "Ab1", "Bb1",
            "", "Db2", "Eb2", "", "Gb2", "Ab2", "Bb2",
            "", "Db3", "Eb3", "", "Gb3", "Ab3", "Bb3",
            "", "Db4", "Eb4", "", "Gb4", "Ab4", "Bb4",
            "", "Db5", "Eb5", "", "Gb5", "Ab5", "Bb5",
            "", "Db6", "Eb6", "", "Gb6", "Ab6", "Bb6",
            "", "Db7", "Eb7", "", "Gb7", "Ab7", "Bb7",
            "", "Db8"
            };

        public void Play(string note)
        {
            // Reflection
            ISimpleAudioPlayer player = (ISimpleAudioPlayer)GetType()
                .GetField(note, BindingFlags.NonPublic | BindingFlags.Instance)
                .GetValue(this);
            player.GetType().GetMethod("Play").Invoke(player, null);
        }
    }
}
