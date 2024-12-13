
using System;
using System.Text;
// Гра "Вгадай слово"
Console.WriteLine("Try to guess hidden word!");
string wordToGuess = "computer";
char[] stateOfWord = new string('_', wordToGuess.Length).ToCharArray();
int attempts = wordToGuess.Length;
Console.WriteLine("Amount of letters in the word: {0}", wordToGuess.Length);
Console.WriteLine("Amount of possible tries: {0}", attempts);

while (attempts > 0 && new string(stateOfWord) != wordToGuess)
{
    Console.Write("Enter your letter: ");
    char letter = Console.ReadKey().KeyChar;
    bool letterFound = false;
    for (int i = 0; i < wordToGuess.Length; i++)
    {
        if (wordToGuess[i] == letter)
        {
            stateOfWord[i] = letter;
            letterFound = true;
        }
    }
    Console.WriteLine(letterFound ? "\nThere is such letter in the word" : $"\nThere is no such letter in the word! Remaining attempts: {--attempts}"); 
    Console.Write("Current state of the word: ");

    /* Виведення поточного стану слова у форматі |вгадана літера|, при такому виведенні не потрібно виводити позицію літери окремо
     * так як видно вгадано літеру в слові відносно ще не вгаданих
     */
    for (int i = 0; i < stateOfWord.Length; i++)
    {
        Console.Write('|');
        Console.Write(stateOfWord[i]);
    }
    Console.WriteLine('|');
    Console.WriteLine();
}
Console.WriteLine((new string(stateOfWord) == wordToGuess)
? $"You win! Guessed word: {wordToGuess}"
: $"You lost! Word to guess: {wordToGuess}");

