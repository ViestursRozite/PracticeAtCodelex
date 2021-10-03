using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        public SortedDictionary<string, string> _data;

        public PhoneDirectory() 
        {
            _data = new SortedDictionary<string, string>();
        }

        public bool Find(string name) 
        {
            return this._data.ContainsKey(name);
        }

        public SortedDictionary<string, string> GetDict()
        {
            return this._data;
        }

        public string GetNumber(string name) 
        {
            return this._data[name];
        }

        public void PutNumber(PhoneEntry entry) 
        {
            this._data.Add(entry.Name, entry.Number);
        }

        public void PutNumber(string name, string number)
        {
            this._data[name] = number;
        }
    }
}