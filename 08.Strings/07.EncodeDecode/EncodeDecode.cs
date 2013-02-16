﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.EncodeDecode
{
    class EncodeDecode
    {
        static int[] EncodingDecoding(int[] message, int[] cipher)
        {
            int[] result = new int[message.Length];
            for (int i = 0; i < result.Length; i++)
            {
                int temp = message[i] ^ cipher[i % cipher.Length];
                result[i] = temp;
            }
            return result;
        }

        static void Main(string[] args)
        {
            /*Write a program that encodes and decodes a string using given encryption key (cipher). 
             The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or) operation
             over the first letter of the string with the first of the key, the second – with the second, etc.
             When the last key character is reached, the next is the first.*/

            Console.Write("Enter the message: ");
            string inputMessage = Console.ReadLine();
            Console.Write("Enter the cipher: ");
            string inputCipher = Console.ReadLine();
            int[] message = new int[inputMessage.Length];
            for (int i = 0; i < message.Length; i++)
            {
                message[i] = (int)inputMessage[i];
            }
            int[] cipher = new int[inputCipher.Length];
            for (int i = 0; i < cipher.Length; i++)
            {
                cipher[i] = (int)inputCipher[i];
            }
            int[] encodeMessage = EncodingDecoding(message, cipher);
            StringBuilder encodeResult = new StringBuilder();
            foreach (int item in encodeMessage)
            {
                encodeResult.Append((char)item);
            }
            Console.WriteLine("After encoding: {0}", encodeResult.ToString());
            int[] decodeMessage = EncodingDecoding(encodeMessage, cipher);
            StringBuilder decodeResult = new StringBuilder();
            foreach (int item in decodeMessage)
            {
                decodeResult.Append((char)item);
            }
            Console.WriteLine("After decoding: {0}", decodeResult.ToString());

        }
    }
}
