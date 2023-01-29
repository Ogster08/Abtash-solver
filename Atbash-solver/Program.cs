using System;
using System.Collections.Generic;
using System.Text;

namespace Atbash
{
	class Program
	{
		public static void Main(string[] Args)
		{
			Console.Write("Enter cipher text: ");
			string encryption = new string(Console.ReadLine().Where(char.IsLetter).ToArray()).ToLower();

			//Atbash cipher reverses the letter, e.g. a -> z
			char[] key = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
			key = key.Reverse().ToArray();

			//loops through the encryption and adds the reversed letter to a stringBuilder object
			StringBuilder decryption = new StringBuilder();
			foreach (char letter in encryption)
			{
				decryption.Append(key[letter - 97]);
			}

			//outputs the decrypted text
			Console.Write(decryption.ToString());
		}
	}
}