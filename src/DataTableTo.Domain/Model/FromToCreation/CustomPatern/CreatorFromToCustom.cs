using System.Collections.Generic;
using System.Text;
using DataTableTo.Domain.Model.FromToCreation.CustomPatern;
using DataTableTo.Domain.Services;

namespace DataTableTo.Domain.Model.FromToCreation.DotNetPatern
{
    public class CreatorFromToCustom : IFromToType
    {
        public void CreateFromType(IFromToService fromToService, UserData userData)
        {
            if (!userData.CustomMehtodExtension) return;

            var fromToList = new List<string>();
            foreach (var data in userData.TableData)
            {
                var sb = new StringBuilder();
                new FromToCustomBool().CreateFromTo(fromToService, sb, userData, data);
                new FromToCustomDateTime().CreateFromTo(fromToService, sb, userData, data);
                new FromToCustomDecimal().CreateFromTo(fromToService, sb, userData, data);
                new FromToCustomInt().CreateFromTo(fromToService, sb, userData, data);
                new FromToCustomString().CreateFromTo(fromToService, sb, userData, data);
                fromToList.Add(sb.ToString());
            }
            userData.Results = fromToList;
        }
    }
}
