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
    }
}
