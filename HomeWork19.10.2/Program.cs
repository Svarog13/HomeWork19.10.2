using System;

class CaesarCipher
{
    static string Encrypt(string text, int shift)
    {
        char[] charArray = text.ToCharArray();

        for (int i = 0; i < charArray.Length; i++)
        {
            if (char.IsLetter(charArray[i]))
            {
                char offset = char.IsUpper(charArray[i]) ? 'A' : 'a';
                charArray[i] = (char)(((charArray[i] + shift - offset) % 26) + offset);
            }
        }
        return new string(charArray);
    }

    static string Decrypt(string text, int shift)
    {
        return Encrypt(text, 26 - shift); 
    }

    static void Main()
    {
        Console.WriteLine("Enter the text for coding:");
        string inputText = Console.ReadLine();

        Console.WriteLine("enter the shift number (Intenger):");
        int shift = int.Parse(Console.ReadLine());

        string encryptedText = Encrypt(inputText, shift);
        Console.WriteLine("Coding text: " + encryptedText);

        string decryptedText = Decrypt(encryptedText, shift);
        Console.WriteLine("Uncoding text: " + decryptedText);
    }
}