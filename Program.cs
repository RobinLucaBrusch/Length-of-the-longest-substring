using System;

class Program
{
    static void Main(string[] args)
    {
        // Input string / Eingabe-String
        string input = "abcabcbb";
        // Length of the longest substring / Länge des längsten Substrings
        int maxLength = 0;
        // Length of the current substring / Länge des aktuellen Substrings
        int currentLength = 0;
        // Last occurrence of each character in the string / Letztes Vorkommen jedes Zeichens im String
        int[] lastSeen = new int[256];
        for (int i = 0; i < lastSeen.Length; i++)
        {
            lastSeen[i] = -1;
        }
        for (int i = 0; i < input.Length; i++)
        {
            char currentChar = input[i];
            // If the character has not occurred before or the last occurrence is outside the current substring / Wenn das Zeichen noch nicht vorgekommen ist oder das letzte Vorkommen außerhalb des aktuellen Substrings liegt
            if (lastSeen[currentChar] == -1 || i - currentLength > lastSeen[currentChar])
            {
                currentLength++;
            }
            else
            {
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                }
                currentLength = i - lastSeen[currentChar];
            }
            lastSeen[currentChar] = i;
        }
        if (currentLength > maxLength)
        {
            maxLength = currentLength;
        }
        // Output the length of the longest substring / Ausgabe der Länge des längsten Substrings
        Console.WriteLine("Length of the longest substring: " + maxLength);
    }
}
