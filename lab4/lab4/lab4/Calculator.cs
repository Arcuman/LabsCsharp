using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace lab4
{
    class Calculator
    {
        public string EnterString { get; set; }
        public string EmptyString { get; set; }
        public string WhatReplace { get; set; }
        public string ToReplace   { get; set; }
        public bool   isReplace   { get; set; }
        public bool   isOperation   { get; set; }
        public Calculator()
        {
            EmptyString = EnterString = "";
        }

        public void DeleteOne()
        {
            try
            {
                if (isOperation)
                {
                    throw new Exception("Possible only 1 operation");
                }
                if (EnterString != EmptyString)
                {
                    int lenght = EnterString.Length - 1;
                    string text = EnterString;
                    EnterString = EmptyString;
                    for (int i = 0; i < lenght; i++)
                    {
                        EnterString += text[i];
                    }
                }
                else
                {
                    throw new Exception("Nothing to Delete");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error: " + exp.Message);
            }
        }

        public bool Replace_Step1(string sub)
        {
            try
            {
                if (isOperation)
                {
                    throw new Exception("Possible only 1 operation");
                }

                if (EnterString != EmptyString && sub != "")
                {
                    WhatReplace = sub;
                    sub = EmptyString;
                    isReplace = true;
                    isOperation = true;
                }
                else
                {
                    throw new Exception("Nothing replace");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error: " + exp.Message);
                return false;
            }
            return true;
        }
        public void Replace_Step2(string sub)
        {
            ToReplace = sub;
            EnterString = EnterString.Replace(WhatReplace, ToReplace);
            isReplace = false;
            isOperation = false;
            WhatReplace = ToReplace = EmptyString;
        }

        public void DelteSubString(string str)
        {
            try
            {
                if (isOperation)
                {
                    throw new Exception("Possible only 1 operation");
                }

                if (EnterString != null && str != "")
                {
                    EnterString = EnterString.Replace(str, "");
                }
                else
                {
                    throw new Exception("Nothing delete");
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show("Error: " + exp.Message);
            }
        }
        public void GetLength()
        {
            try
            {
                if (isOperation)
                {
                    throw new Exception("Possible only 1 operation");
                }
                if (EnterString != EmptyString)
                {
                    MessageBox.Show("The length is: " +
                        EnterString.Length.ToString());
                }
                else
                {
                    throw new Exception("Null string");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error: " + exp.Message);
            }
        }

        public void GetElemByIndex(int index)
        {
            try
            {
                if (isOperation)
                {
                    throw new Exception("Possible only 1 operation");
                }

                if (EnterString != EmptyString)
                {
                    if ( index > EnterString.Length || index <=0)
                    {
                        throw new Exception("Incorrect index");
                    }
                    MessageBox.Show($"Symbol in position {index} is: " +
                                    EnterString[index - 1].ToString());
                   
                }
                else
                {
                    throw new Exception("Nothing to show");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error: " + exp.Message);
            }
        }
        public void GetSentece()
        {
            try
            {
                if (isOperation)
                {
                    throw new Exception("Possible only 1 operation");
                }

                if (EnterString != EmptyString)
                {
                    string punctuation = ".!?";
                    string countSentence = (EnterString.Where(x => punctuation.Contains(x)).Count() + 1).ToString();
                    MessageBox.Show("Number of sentence " + countSentence
                        );
                }
                else
                {
                    throw new Exception("Nothing to count");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error: " + exp.Message);
            }
        }

        public void GetVowelsAndConsonants()
        {
            try
            {
                if (isOperation)
                {
                    throw new Exception("Possible only 1 operation");
                }

                if (EnterString != EmptyString)
                {
                    string vowels = "уеыаоэяиёюaeiouy";
                    string consonants = "цкнгшщзхфвпрлджчсмтбbcdfghjklmnpqrstvwxz";
                    string countVowels = EnterString.Where(x => vowels.Contains(x)).Count().ToString();
                    string countConsonants = EnterString.Where(x => consonants.Contains(x)).Count().ToString();
                    MessageBox.Show("Number of vowels " + countVowels +
                                    "\nNumber of consonants " + countConsonants
                        );
                }
                else
                {
                    throw new Exception("Nothing to count");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error: " + exp.Message);
            }

        }

        public void GetWords()
        {
            try
            {
                if (isOperation)
                {
                    throw new Exception("Possible only 1 operation");
                }
                if (EnterString != EmptyString)
                {
                    string temp = Regex.Replace(EnterString, "[-.?!)(,:]", " ");
                    temp = Regex.Replace(temp, "[ ]+", " ");
                    string countSentence;
                    if (temp[temp.Length - 1] == ' ')
                    {
                        countSentence = (temp.Where(x => x == ' ').Count()).ToString();
                    }
                    else
                    {
                        countSentence = (temp.Where(x => x == ' ').Count() + 1).ToString();
                    }
                    MessageBox.Show("Number of word " + countSentence
                        );
                }
                else
                {
                    throw new Exception("Nothing to count");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error: " + exp.Message);
            }
        }
            

    }
}
