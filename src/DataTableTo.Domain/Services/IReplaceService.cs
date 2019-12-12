using System.Collections.Generic;

namespace DataTableTo.Domain.Services
{
    public interface IReplaceService
    {
        IEnumerable<string> GetReplaceResult(string fullWords, string method);
    }
}
