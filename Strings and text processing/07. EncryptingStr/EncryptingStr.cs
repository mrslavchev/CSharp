//Write a program that encodes and decodes a string using given encryption key (cipher). 
//The key consists of a sequence of characters. The encoding/decoding is done by performing XOR
//(exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc.
//When the last key character is reached, the next is the first.

using System;
using System.Text;

class EncryptingStr
{
    /// <summary>
    /// Encrypts a string by applying XOR operation to each of it's chars and 
    /// another string (key)
    /// </summary>
    /// <param name="message">Accepts string message as first parameter</param>
    /// <param name="key">Accepts string key as a second parameter</param>
    /// <returns>Encrypted string</returns>
    static string Encrypt(string message, string key)
    {
        StringBuilder encryptedMessage = new StringBuilder(message.Length);
        int len = key.Length;
        for (int i = 0; i < message.Length; i++)
        {
            encryptedMessage.Append((char)(message[i] ^ key[i % len])); //making sure the key char position moves from 0 to length -1
        }

        return encryptedMessage.ToString();
    }

    /// <summary>
    /// Calls the encrypt method internally.
    /// </summary>
    /// <param name="message">Message to be decrypted</param>
    /// <param name="key">Decryption key</param>
    /// <returns>Decrypted text</returns>
    static string Decrypt(string message, string key)
    {
        return Encrypt(message, key);
    }

    static void Main()
    {
        string text = "Software testing is an investigation conducted to provide stakeholders with information about the quality of the productor service under test.[1] Software testing can also provide an objective,";
        string key = "test";

        string encrypted = Encrypt(text, key);
        Console.WriteLine("Encrypted:\n{0}", encrypted);
        Console.WriteLine("Decrypted\n" + Decrypt(encrypted, key));
    }
}
