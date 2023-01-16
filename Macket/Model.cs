using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Macket
{
    public static class Model
    {
        // блок с данными
        static double count = 0;
        public static List<string> datalist = new List<string> { "Сложение", "Вычитание", "Умножение", "Деление" };
        public static List<string> datalistsign = new List<string> { "+", "-", "*", "/" };


        // блок для обращения к текстовым полям
        public static TextBlock textResult;
        public static TextBlock textCombo;

        // блок с бизнес-логикой
        public static int Comdo
        {
            set
            {
                textCombo.Text = datalist[value];
            }
        }

        public static double Result
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
                textResult.Text = count.ToString();
            }
        }

    }
}
