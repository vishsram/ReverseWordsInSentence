using System;

namespace ReverseWordsInString
{
    public static class ReverseWordsService
    {
        public static String ReverseWords(String sen) {
            if (String.IsNullOrEmpty(sen)) {
                return String.Empty;
            }

            char[] str = sen.ToCharArray();

            // Reverse the sentence first
            ReverseOne(str, 0, str.Length-1);
            int start = 0; int i = 0;
            while (i < str.Length) {
                if (str[i] == ' ') {
                    
                    // Reverse current work
                    ReverseOne(str, start, i-1);
                    // Update start to next word
                    start = i + 1;
                    i++;
                }
                else {
                    // Current word has not completed, increment index i
                    i++;
                }
            }

            // Reverse last word
            if (i == str.Length) {
                ReverseOne(str, start, i-1);
            }
            
            return new String(str);
        }

        public static void ReverseOne(char[] str, int start, int end) {
            for (int i=start, j = end; i < j; i++, j--) {
                char temp = str[i];
                str[i] = str[j];
                str[j] = temp;
            }
            
        }
        

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            String result = ReverseWords("The sky is blue");
            Console.WriteLine(result);
        }
    }
}
