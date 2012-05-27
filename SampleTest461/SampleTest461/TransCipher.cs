using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SampleTest461
{
    public delegate string MyEncode(string s);

    public class TransCipher : IEncryptable
    {
        private int key;

        public int Key
        {
            get { return key; }
            set { key = value; }
        }
        public TransCipher(String s)
        {

            Key = s.Select(ch => ch).Distinct().Count();

        }

        public String Encrypt(String plainText)
        {
            int index = 0;
            int n = (int)(Math.Ceiling((double)plainText.Length / key));
            char[,] cipherMatrix = new char[n, key];
            char[] ciphered = new char[n * key];

            for (int i = 0; i < n; ++i)
            {

                for (int y = 0; y < key; ++y)
                {

                    if (index < plainText.Length)
                    {
                        cipherMatrix[i, y] = plainText[index++];
                    }
                    else
                    {
                        cipherMatrix[i, y] = ' ';
                    }

                }
            }

            index = 0;
            for (int column = 0; column < cipherMatrix.GetLength(1); ++column)
            {
                for (int row = 0; row < cipherMatrix.GetLength(0); ++row)
                {

                    ciphered[index++] = cipherMatrix[row, column];
                }
            }
            return new String(ciphered);
        }

        public String Decrypt(String cipheredText)
        {
            int index1 = 0;
            int n = (int)(Math.Ceiling((double)cipheredText.Length / key));
            char[,] cipherMatrix = new char[n, key];
            char[] unciphered = new char[n * key];


            for (int y = 0; y < key; ++y)
            {

                for (int i = 0; i < n; ++i)
                {

                    cipherMatrix[i, y] = cipheredText[index1++];

                }

            }
            index1 = 0;
            foreach (var x in cipherMatrix)
                unciphered[index1++] = x;

            return new String(unciphered).TrimEnd();

        }


        public override string ToString()
        {
            return String.Format("Key:{0} ", key);
        }


        public MyEncode GetMyEncode
        {
            get { return new MyEncode(Encrypt); }
        }

        public MyEncode GetMyDecode
        {
            get { return new MyEncode(Decrypt); }
        }
    }
}
