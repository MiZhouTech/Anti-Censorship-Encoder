using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    static public class EncoderV1
    {
        // Should be this format: one-two-three-four-five-six-seven-eight-night-ten-eleven-twelve-thirteen-fourteen-fifthteen-sixteen
        // Chinese version key string: 一-二-三-四-五-六-七-八-九-十-不可-重复-之前-已-使用-字符
        static public string KeyString { get; set; }

        // Keywords to be used later, separated from the raw key string.
        static public Dictionary<int, string> Keywords { get; set; }

        // 
        static string[] placeHoders = new string[] 
        { ",", ".", "?", "!", "'", ":", ";",
            "，", "。", "？", "！", "…", "、", "：","；",
            "“", "”", "‘", "’" };


        static public void Encode(string rawText)
        {

        }

        static public void Decode(string encryptedText)
        {

        }

        // Decode the text to an array of hex numbers.
        static public byte[] GetRawCodeFromText(string rawText)
        {
            byte[] bytesArray = Encoding.GetEncoding("UTF-8").GetBytes(rawText);
            byte[] hexArray = new byte[bytesArray.Length * 2];

            for (int i = 0; i < hexArray.Length; i += 2)
            {
                hexArray[i] = (byte)(bytesArray[i / 2] % 16);
            }
            for (int i = 1; i < hexArray.Length; i += 2)
            {
                hexArray[i] = (byte)(bytesArray[i / 2] / 16);
            }

            foreach (var item in bytesArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            foreach (var item in hexArray)
            {
                Console.WriteLine(item);
            }

            return hexArray;
        }

        static public void AssembleKeywords(string rawKeyString)
        {
            KeyString = rawKeyString;
            Keywords = new Dictionary<int, string>();


            string[] keys = rawKeyString.Split('-');

            if (!ValidateKeywords(keys)) return;

            if (keys.Length >= 16)
            {
                for (int i = 0; i < 16; i++)
                {
                    Keywords.Add(i, keys[i]);
                }
            }
            else
            {
                for (int i = 0; i < keys.Length; i++)
                {
                    Keywords.Add(i, keys[i]);
                }
            }

            if (Keywords.Count != 16)
            {
                int start = Keywords.Count;
                int i = 0;
                while (Keywords.Count < 16)
                {
                    Keywords.Add(i+ start, placeHoders[i]);
                    i++;
                }
            }

            foreach (var key in Keywords)
            {
                Console.WriteLine(key.Key + " " + key.Value);
            }
        }


        // Ensure no invalid keys provided.
        static public bool ValidateKeywords(string[] rawKeys)
        {
            List<string> charactersSeen = new List<string>();

            // Store keys in hash able to check duplication.
            foreach (string key in rawKeys)
            {
                if (key == "" && rawKeys.Length > 0)
                {
                    return false;
                }
                if (charactersSeen.Contains(key)) return false;
                charactersSeen.Add(key);
                if (charactersSeen.Count == 16) break;
            }

            // Avoid duplicate set of characters.
            for (int i = 0; i < charactersSeen.Count; i++)
            {
                for (int j = 0; j < charactersSeen.Count; j++)
                {
                    if (i == j) continue;
                    if (charactersSeen[j].Contains(charactersSeen[i])) return false;
                }
                for (int j = 0; j < (16 - charactersSeen.Count); j++)
                {
                    if (charactersSeen[i].Contains(placeHoders[j])) return false;
                }
            }

            return true;
        }



        static public string ReplaceHexWithKeyText(byte[] hexArray)
        {
            if (Keywords.Count != 16) return null;
            StringBuilder temp = new StringBuilder();

            foreach (byte hex in hexArray)
            {
                temp.Append(Keywords[(int)hex]);
            }

            Console.WriteLine(temp.ToString());
            return temp.ToString();
        }



        static public string DecodeEncyptedTextToHexArray(string encryptedText)
        {
            if (Keywords.Count != 16) return null;

            StringBuilder temp = new StringBuilder();
            List<byte> hexCode = new List<byte>();

            int i = 0;
            bool keyFound = false;
            byte keyNow = 0;
            while (i<encryptedText.Length)
            {
                keyFound = false;
                foreach (var key in Keywords)
                {
                    if(encryptedText.IndexOf(key.Value, i) == i)
                    {
                        keyFound = true;
                        keyNow = (byte)key.Key;
                        break;
                    }
                }

                if (!keyFound) return null;
                hexCode.Add(keyNow);
                i += Keywords[keyNow].Length;
            }
            

            return GetRawTextFromHex(hexCode.ToArray());
        }

        static public string GetRawTextFromHex(byte[] hexCode)
        {
            byte[] bytesArray = new byte[hexCode.Length / 2];

            byte byteNow = 0;
            for (int i = 1; i < hexCode.Length; i += 2)
            {
                byteNow= (byte)((hexCode[i]<<4) + hexCode[i - 1]);
                bytesArray[i / 2] = byteNow;
            }

            return Encoding.GetEncoding("UTF-8").GetString(bytesArray);
            
        }
    }
}
