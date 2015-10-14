using System;
using System.Collections.Generic;

namespace TdkDictionary.TdkDataService.Model
{
    public class SearchResult
    {
        public SearchResult(List<Word> words, Boolean isSuggestion)
        {
            this.Words = words;
            this.IsSuggestion = isSuggestion;
        }

        public List<Word> Words { get; private set; }
        public Boolean IsSuggestion { get; private set; }
    }
}
