using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Input string / Eingabe-String
            string input = "abcabcbb";

            // Length of the longest substring / L�nge des l�ngsten Substrings
            int maxLength = 0;

            // Length of the current substring / L�nge des aktuellen Substrings
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

                // If the character has not occurred before or the last occurrence is outside the current substring / Wenn das Zeichen noch nicht vorgekommen ist oder das letzte Vorkommen au�erhalb des aktuellen Substrings liegt
                if (lastSeen[currentChar] == -1 || i - currentLength > lastSeen[currentChar])
                {
                    currentLength++;
                }
                else
                { //gleichsetzen
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

            // Assert that the length of the longest substring is correct / �berpr�fen, ob die L�nge des l�ngsten Substrings korrekt ist
            Assert.AreEqual(3, maxLength);
        }
    }
}