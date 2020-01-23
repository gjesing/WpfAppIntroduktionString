using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfAppIntroduktionString.IO;

namespace WpfAppIntroduktionString.BIZ
{
    public class ClassBIZ
    {
        public ClassBIZ()
        {

        }

        public void GetTextForTextBox(TextBox textBox)
        {
            ClassIO classIO = new ClassIO();
            classIO.GetTestString(textBox);
        }

        public int CountAllLines(TextBox textBox)
        {
            return textBox.LineCount;
        }

        public int CountAllChars(TextBox textBox)
        {
            return textBox.Text.Length;
        }

        public int CountAllVokals(TextBox textBox)
        {
            char[] allChars = textBox.Text.ToCharArray();
            int numberOfVokals = 0;
            foreach (char character in allChars)
            {
                switch (character)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'y':
                    case 'æ':
                    case 'ø':
                    case 'å':
                        numberOfVokals++;
                        break;
                    default:
                        break;
                }
            }
            return numberOfVokals;
        }

        public string RemoveAllVokals(TextBox textBox)
        {
            char[] allChars = textBox.Text.ToCharArray();
            string textWithoutVokals = "";
            foreach (char character in allChars)
            {
                switch (character)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'y':
                    case 'æ':
                    case 'ø':
                    case 'å':
                        break;
                    default:
                        textWithoutVokals += character;
                        break;
                }
            }
            return textWithoutVokals;
        }

        public string MarkAndCountWord(TextBox textBox, string word)
        {
            if (String.IsNullOrWhiteSpace(word.Trim()))
            {
                return "Søg efter et ord for at få det talt markeret.";
            }
            else
            {
                string newText = textBox.Text;
                int wordCount = 0;
                int index = newText.IndexOf(word.Trim(), StringComparison.CurrentCultureIgnoreCase);
                while (index != -1)
                {
                    newText = newText.Insert(index, "#>");
                    wordCount++;
                    index = newText.IndexOf(word.Trim(), index + 3, StringComparison.CurrentCultureIgnoreCase);
                }
                return $"Ordet {word.Trim()} blev fundet {wordCount} gange og er blevet markeret med #>\n\n{newText}";
            }
        }
    }
}
