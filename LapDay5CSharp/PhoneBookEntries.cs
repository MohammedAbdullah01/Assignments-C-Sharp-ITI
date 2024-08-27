using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LapDay5CSharp
{
    internal class PhoneBookEntries
    {
        private Dictionary<string, int> entries;

        // Read-only property to expose the dictionary
        public IReadOnlyDictionary<string, int> Entries => entries;

        public PhoneBookEntries()
        {
            entries = new Dictionary<string, int>();
        }

        public void AddEntry(string Name , int phone)
        {
            if(!entries.ContainsKey(Name))
            {
                entries.Add(Name, phone);
            }
            return;
        }

        public void RemoveEntry(string Name)
        {
            if (entries.ContainsKey(Name))
            {
                entries.Remove(Name);
            }
            return;
        }

        public int? SearchEntry(string Name)
        {
            if(entries.TryGetValue(Name , out int value))
            {
                return value;
            }
            return null;
        }


    }
}
