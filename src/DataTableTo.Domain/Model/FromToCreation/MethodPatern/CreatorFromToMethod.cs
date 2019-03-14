using DataTableTo.Domain.Services;
using System.Collections.Generic;
using System.Text;

namespace DataTableTo.Domain.Model.FromToCreation.MethodPatern
{
    public class CreatorFromToMethod : IFromToType
    {
        public void CreateFromType(IFromToService fromToService, UserData userData)
        {
            if (!userData.CustomMethod) return;

            var fromToList = new List<string>();
            foreach (var data in userData.TableData)
            {
                var sb = new StringBuilder();

                new FromToMethodBool().CreateFromTo(fromToService, sb, userData, data);
                new FromToMethodDateTime().CreateFromTo(fromToService, sb, userData, data);
                new FromToMethodDecimal().CreateFromTo(fromToService, sb, userData, data);
                new FromToMethodInt().CreateFromTo(fromToService, sb, userData, data);
                new FromToMethodString().CreateFromTo(fromToService, sb, userData, data);
                fromToList.Add(sb.ToString());
            }
            userData.Results = fromToList;
        }
    }
}
