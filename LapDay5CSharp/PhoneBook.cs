using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LapDay5CSharp
{
    internal class PhoneBook
    {
        public Dictionary<int, string> PhoneToName =  new Dictionary<int, string>();
        public Dictionary<string, int> NameToPhone = new Dictionary<string, int>();

        public int this[string name]
        {
            get
            {
                if(NameToPhone.TryGetValue(name, out int phoneNumber))
                {
                    return phoneNumber;
                }
                throw new KeyNotFoundException($"The name '{name}' was not found in the phone book.");
            }
            set 
            {
                if(IsDuplicate(name , value)) return;
               

                NameToPhone[name] = value;
                PhoneToName[value] = name;
            }
        }


        public string this[int phoneNumber]
        {
            get
            {
                if(PhoneToName.TryGetValue(phoneNumber , out string? name))
                {
                    return name;
                }
                throw new KeyNotFoundException($"The phone number '{phoneNumber}' was not found in the phone book.");
            }
            set
            {
                if (IsDuplicate(value, phoneNumber)) return;

                PhoneToName[phoneNumber] = value;
                NameToPhone[value] = phoneNumber;
            }
        }

        private bool IsDuplicate(string name, int phoneNumber)
        {
            if (NameToPhone.ContainsKey(name))
            {
                Console.WriteLine($"The name '{name}' is already in the phone book.");
                return true;
            }

            if (PhoneToName.ContainsKey(phoneNumber))
            {
                Console.WriteLine($"The phone number '{phoneNumber}' is already in the phone book.");
                return true;
            }

            return false;
        }

        public void RemoveEntryByName(string name)
        {
            if(NameToPhone.TryGetValue(name , out int phoneNumber))
            {
                NameToPhone.Remove(name);
                PhoneToName.Remove(phoneNumber);
                Console.WriteLine($"Removed '{name}' from the phone book.");
            }
            else
            {
                Console.WriteLine($"The name '{name}' was not found in the phone book.");
            }
        }

        public void RemoveEntryByPhoneNumber(int phoneNumber)
        {
            if(PhoneToName.TryGetValue(phoneNumber , out string? name))
            {
                PhoneToName.Remove(phoneNumber);
                NameToPhone.Remove(name);
                Console.WriteLine($"Removed phone number '{phoneNumber}' from the phone book.");
            }
            else
            {
                Console.WriteLine($"The phone number '{phoneNumber}' was not found in the phone book.");
            }
        }
    }
}
