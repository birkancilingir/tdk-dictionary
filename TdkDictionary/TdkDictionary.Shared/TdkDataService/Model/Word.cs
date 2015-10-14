using System;
using System.Collections.Generic;
using System.Text;

namespace TdkDictionary.TdkDataService.Model
{
    public class Word
    {
        public Nullable<int> Id { get; set; }

        public String Name { get; set; }

        public String Origin { get; set; }

        public String Description { get; set; }

        public String DictionaryName { get; set; }

        public Nullable<int> Year { get; set; }
    }
}
