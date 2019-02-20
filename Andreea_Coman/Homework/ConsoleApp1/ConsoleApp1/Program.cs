using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fibonacci 
            //Console.WriteLine("introduceti un numar pentru care sa afisam sirul fibonacci: ");
            //int n = Convert.ToInt16(Console.ReadLine()); 
            //FibonacciIterativ(n);
            //Console.ReadKey();

            // Sortarea unui array primit ca input de la user 
            //Console.WriteLine("Urmeaza sa sortam un sir de numere intregi. Introduceti dimensiunea sirului, un numar natural mai mare decat 2:  ");
            //byte dimens = Convert.ToByte(Console.ReadLine());
            //Console.WriteLine("Acum introduceti numerele din sir: ");
            //SortareNumere(dimens);

            // arrayList cu studenti 
            Console.WriteLine("Cream un numar de studenti si il afisam");

            Student myStudentArray = new CreateStudents2(12); // nu imi dau seama de ce nu apeleaza functia asta; nu o gaseste, dar nu stiu de ce 



            Console.ReadKey();
        }

        public static int FibonacciIterativ(int fib)
        {
            int suma = 0;
            int n1 = 0;
            int n2 = 1;
            suma = n1 + n2;
            Console.WriteLine("rezultate");
            Console.WriteLine($"0");
            Console.WriteLine($"1 ");

            for (int i = 2; i <= fib; i++)
            {
                suma = n1 + n2;
                Console.WriteLine($"{suma}", suma);
                n1 = n2;
                n2 = suma;
            }
            return suma;
        }

        public static void SortareNumere(byte d)
        {
            int[] terms = new int[d]; // setez dimensiunea array-ului 
            for (int i = 0; i < d; i++)
            {
                int n = Convert.ToInt16(Console.ReadLine());  // citesc de la tastatura numerele desi int16 ala mi se pare ciudat (si gresit) 
                terms[i] = n;  // le adaug in array 
            }
            // sortarea 
            int temp = 0;
            for (int a = 0; a < d; a++)
            {
                for (int b = a + 1; b < d; b++)
                {
                    if (terms[a] > terms[b])
                    {
                        temp = terms[b];
                        terms[b] = terms[a];
                        terms[a] = temp;
                    }
                }

            }

            Console.WriteLine("Numerele sortate crescator sunt: ");
            for (int j = 0; j < d; j++) // afisez array-ul (de verificare) 
            {
                Console.Write($"{terms[j]} ");
            }
            Console.ReadKey();
        }

        public class Student
        {
            // public int Id;
            // public double Average;
            public string Name;
            // public DateTime DateofBirth; 
        }

        // functie care returneaza lista de studenti 

        public static ArrayList CreateStudents2(int numberOfStudents)
        {
            // am creat lista de studenti 
            ArrayList ListaStudenti = new ArrayList();
            for (int i = 0; i < numberOfStudents; i++)
            {
                Student student = new Student();
                student.Name = "Andreea" + i;
                ListaStudenti.Add(student);
                Console.WriteLine("mno....");
            }
            return ListaStudenti;
        }
    }
}
