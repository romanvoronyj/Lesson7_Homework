using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_HW_Task2
{
    class Program
    {
        static void PaymentValue(double payment, double loan)
        {
            if(payment < 100)
            {
                Console.WriteLine("Мінімальний платіж повинен складати не менше 100 грн");
            }
            loan -= payment;
            if (loan > 0)
            {
                Console.WriteLine("Залишок по кредиту {0} гривень (-ні)", loan);
            }
            else
            {
                Console.WriteLine("Заборгованість відсутня!");
            }
        }
        static void Main(string[] args)
        {
            //Припустимо, що клієнт взяв кредит на сумму 1000 грн
            //терміном на 10 місяців, з можливістю закрити кредит швидше. Мінімальний щомісячний платіж 100 грн.
            Console.OutputEncoding = Encoding.UTF8;
            double loan=1000;

            label1://яким чином не перезаписувати в методі значення loan кожного разу?
                   //ідея з goto правильна?
            Console.Write("Введіть сумму платежу, яку клієнт вніс у касі: ");
            double x = Double.Parse(Console.ReadLine());
            PaymentValue(x, loan);
            if (loan<=0)
            {
                Console.WriteLine("Заборгованість відсутня.Ваш кредит оплачено.");
            }
            else
            {
                goto label1;
            }
            Console.ReadKey();


        }
    }
}
