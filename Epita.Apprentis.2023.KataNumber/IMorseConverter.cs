namespace Epita.Apprentis._2023.KataNumber
{
    public interface IMorseConverter
    {
        string ToMorse(int number);
        int FromMorse(string morse);
    }
}