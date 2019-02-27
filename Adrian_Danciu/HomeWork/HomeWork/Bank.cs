using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Bank : IBank
    {
        public ArrayList GenerateFinancialTransactions()
        {

            ArrayList myList = new ArrayList();
            int iterator = 0;
            while (iterator < 20)
            {
        

                for (int i = 0; i < 20; i++)
                {
                    Random random = new Random(i);
                              
                    DateTime dateofBirth1 = new DateTime(2000, 05, 05);
                    DateTime dateofBirth2 = new DateTime(2010, 10, 01);

                    Person p1 = new Person(10, "Mihai", dateofBirth1);
                    Person p2 = new Person(20, "Alina", dateofBirth2);
                    Person p3 = new Person(30, "Vasile", dateofBirth1);
                    Person p4 = new Person(40, "George", dateofBirth2);
                    Person p5 = new Person(50, "Radu", dateofBirth1);

                    Person[] array = new Person[5] { p1, p2, p3, p4, p5 };
                    switch(i%3)
                    {
                        case 0:
                            p1 = array[0];
                            break;
                        case 1:
                            p1 = array[1];
                            break;

                        case 2:
                            p1 = array[2];
                            break;
                    }

                    switch (i % 5)
                    {
                        case 0:
                            p2 = array[4];
                            break;
                        case 1:
                            p2 = array[3];
                            break;
                        case 2:
                            p2 = array[4];
                            break;
                        case 3:
                            p2 = array[3];
                            break;
                        case 4:
                            p2 = array[4];
                            break;
                        case 5:
                            p2 = array[2];
                            break;
                    }
                    FinancialTransaction obj = new FinancialTransaction(p1, p2, random.Next(10, 100));
                    myList.Add(obj);
                    iterator++;
                }
            }

            return myList;
        }

    }
}
