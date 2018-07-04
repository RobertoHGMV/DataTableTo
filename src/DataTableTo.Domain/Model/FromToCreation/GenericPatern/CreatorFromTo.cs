using System.Collections.Generic;
using System.Text;
using DataTableTo.Domain.Services;

namespace DataTableTo.Domain.Model.FromToCreation.GenericPatern
{
    public class CreatorFromTo : IFromToType
    {
        public void CreateFromType(IFromToService fromToService, UserData userData)
        {
            if (!userData.WithoutValidation) return;

            var fromToList = new List<string>();
            foreach (var data in userData.TableData)
            {
                var sb = new StringBuilder();

                if (!string.IsNullOrEmpty(userData.ObjectName))
                    sb.Append($"{userData.ObjectName}.");

                new FromToGeneric().CreateFromTo(fromToService, sb, userData, data);
                fromToList.Add(sb.ToString());
            }
            userData.Results = fromToList;
        }
    }
}
