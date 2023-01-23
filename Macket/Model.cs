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
        public static TextBox OneNumber;
        public static TextBox TwoNumber;

        // блок с бизнес-логикой
        public static int Comdo
        {
            set
            {
                textCombo.Text = datalistsign[value];
            }
        }

        public static double Result
        {
            set
            {
                try
                {
                    string numberone = OneNumber.Text;
                    string numbertwo = TwoNumber.Text;
                    double numbersone = Convert.ToDouble(numberone);
                    double numberstwo = Convert.ToDouble(numbertwo);
                    switch(value)
                    {
                        case 0:
                            textResult.Text =Convert.ToString(numbersone + numberstwo);
                            break;
                        case 1:
                            textResult.Text = Convert.ToString(numbersone - numberstwo);
                            break;
                        case 2:
                            textResult.Text = Convert.ToString(numbersone * numberstwo);
                            break;
                        case 3:
                            textResult.Text = Convert.ToString(numbersone / numberstwo);
                            break;
                    }

                }
                catch
                {
                    textResult.Text = "Возникла ошибка";
                }
            }
        }

    }
}
