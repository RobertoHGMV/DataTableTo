using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataTableTo.Domain.Services
{
    public class ReplaceService : IReplaceService
    {
        public IEnumerable<string> GetReplaceResult(string fullWords, string method)
        {
            var newWords = new List<string>();
            var words = fullWords.Split(',');

            foreach (var word in words)
            {
                var methodRep = method.Replace("@field", word.Trim());
                newWords.Add(methodRep);
            }

            return newWords;
        }
    }
}
