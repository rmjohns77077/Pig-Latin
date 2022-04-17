
Console.WriteLine("Enter your sentence to translate from English to Pig Latin");
String EnglishSentence = Console.ReadLine();
String[] Words = EnglishSentence.Split(new char[] { ' ' });
String PigLatinSentence = "";

foreach (string word in Words)
{
    String CurrentWord = word;
    char FirstLetter = CurrentWord.ToUpper()[0];

    CurrentWord = CurrentWord.Remove(0, 1);
    CurrentWord = CurrentWord.Insert(CurrentWord.Length, FirstLetter.ToString());

    if (IsConsonant(FirstLetter))
    {
        CurrentWord = CurrentWord.Insert(CurrentWord.Length, "ay");
    }
    else { CurrentWord = CurrentWord.Insert(CurrentWord.Length, "y"); }
    PigLatinSentence = PigLatinSentence.Insert(PigLatinSentence.Length, CurrentWord + " ");
}

Console.WriteLine(PigLatinSentence.Remove(PigLatinSentence.Length - 1));
Console.Read();


 static bool IsConsonant(char letter)
{

    char[] Vowels = new char[] { 'A', 'E', 'I', 'O', 'U', 'Y' };

    if (Vowels.Contains(letter))
    { return false; }
    else
    {
        return true;
    }

}
