using System;
using System.Threading.Tasks;
using TdkDictionary.TdkDataService.Model;

namespace TdkDictionary.TdkDataService
{
    public interface IDictionaryDataService
    {
        Task<SearchResult> SearchBigTurkishDictionary(BigTurkishDictionaryFilter filter, Action onLoadingStarts, Action onLoadingEnds);
    }
}
