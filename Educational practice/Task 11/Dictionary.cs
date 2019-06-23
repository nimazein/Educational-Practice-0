using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
    class Dictionary
    {
        private List<string> symbols = new List<string>();
        private List<string> codes = new List<string>();

        public List<string> Symbols
        {
            get
            {
                return symbols;
            }             
        }
        public List<string> Codes
        {
            get
            {
                return codes;
            }
        }
        public Dictionary() { }       
        public void FillDictionary()
        {
            // A-Z
            for (int i = 65; i <= 90; i++)
            {
                string code = ToBinary(i - 65);
                codes.Add(code);
                symbols.Add(Convert.ToString(Convert.ToChar(i)));
            }

            //a-z
            for (int i = 97; i <= 122; i++)
            {
                string code = ToBinary(i - 97 + 26);
                codes.Add(code);
                symbols.Add(Convert.ToString(Convert.ToChar(i)));
            }

            //numbers
            for (int i = 0; i <= 9; i++)
            {
                string code = ToBinary(i + 52);
                codes.Add(code);
                symbols.Add(i.ToString());
            }

            codes.Add(ToBinary(62));
            symbols.Add(".");

            codes.Add(ToBinary(63));
            symbols.Add(",");

            codes.Add(ToBinary(64));
            symbols.Add("!");

            codes.Add(ToBinary(65));
            symbols.Add(":");

            codes.Add(ToBinary(66));
            symbols.Add(";");

            codes.Add(ToBinary(67));
            symbols.Add("?");

            codes.Add(ToBinary(68));
            symbols.Add("\n");

            codes.Add(ToBinary(69));
            symbols.Add(" ");
        }
        public string ToBinary(int num)
        {
            string stumpOfCode = Convert.ToString(num, 2);

            StringBuilder fullCode = new StringBuilder(stumpOfCode);

            while (fullCode.Length != 7)
            {
                fullCode.Insert(0, "0");
            }

            return fullCode.ToString();
        }
    }
}
