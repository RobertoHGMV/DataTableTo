using DataTableTo.Domain.Services;
using System.Collections.Generic;
using System.Text;

namespace DataTableTo.Domain.Model.FromToCreation.DotNetPatern
{
    public class CreatorFromToDotNet : IFromToType
    {
        public void CreateFromType(IFromToService fromToService, UserData userData)
        {
            if (userData.CustomMehtodExtension) return;

            var fromToList = new List<string>();
            foreach (var data in userData.TableData)
            {
                var sb = new StringBuilder();
                new FromToDotNetBool().CreateFromTo(fromToService, sb, userData, data);
                new FromToDotNetDateTime().CreateFromTo(fromToService, sb, userData, data);
                new FromToDotNetDecimal().CreateFromTo(fromToService, sb, userData, data);
                new FromToDotNetInt().CreateFromTo(fromToService, sb, userData, data);
                new FromToDotNetString().CreateFromTo(fromToService, sb, userData, data);
                fromToList.Add(sb.ToString());
            }
            userData.Results = fromToList;
        }
    }
}
