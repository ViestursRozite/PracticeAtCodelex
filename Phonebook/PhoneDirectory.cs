using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private SortedDictionary<string, string> _data;

        public PhoneDirectory() 
        {
            _data = new SortedDictionary<string, string>();
        }

        private bool Find(string name) 
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
            this._data[entry.name] = entry.number;
        }
        public void PutNumber(string name, string number)
        {
            this._data[name] = number;
        }
    }
}