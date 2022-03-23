
namespace MiniPiano
{
    public interface IPiano
    {
        string[] WhiteKeys { get; }
        string[] BlackKeys { get; }
        void Play(string note);
    }
}
