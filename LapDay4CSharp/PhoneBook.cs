using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapDay4CSharp
{
    internal class PhoneBook
    {
        int[] PhoneNumbers = new int[100];
        string[] Names = new string[100];
        int count = 0;

        public string this[int phoneNumber]
        {
            get
            {
                for (int i = 0; i < count; i++)
                {
                    if (PhoneNumbers[i] == phoneNumber)
                    {
                        return Names[i];
                    }

                }
                throw new Exception("Phone Number Not Found");
            }
            set
            {
                for (int i = 0; i < count; i++)
                {
                    if (PhoneNumbers[i] == phoneNumber)
                    {
                        Names[i] = value;
                        return;
                    }
                }


                if (count < PhoneNumbers.Length)
                {
                    PhoneNumbers[count] = phoneNumber;
                    Names[count] = value;
                    count++;

                }
                else
                {
                    throw new Exception("Phone book is full.");
                }

            }

        }
        public int this[string name]
        {
            get
            {
                for (int i = 0; i < count; i++)
                {
                    if (Names[i] == name)
                    {
                        return PhoneNumbers[i];
                    }
                }
                throw new Exception("Name not found.");
            }
            set
            {
                for (int i = 0; i < count; i++)
                {
                    if (Names[i] == name)
                    {
                        PhoneNumbers[i] = value;
                        return;
                    }
                }
                if (count < PhoneNumbers.Length)
                {
                    Names[count] = name;
                    PhoneNumbers[count] = value;
                    count++;
                }
                else
                {
                    throw new Exception("Phone book is full.");
                }
            }
        }
    }
}
