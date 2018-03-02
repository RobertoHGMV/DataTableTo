﻿using System.Text;
using DataTableTo.Domain.Services;

namespace DataTableTo.Domain.Model.FromToCreation.CustomPatern
{
    public class FromToCustomInt : IFromToCustom
    {
        public void CreateFromTo(IFromToService fromToService, StringBuilder sb, UserData userData, TableData data)
        {
            if (!SameType(data.ColumnType)) return;

            sb.Append(data.ColumnName);
            sb.Append(" = ");
            fromToService.FillDataRow(sb, userData, data);
            sb.Append("?.");
            sb.Append(userData.MethodExtension);
            sb.Append("<int>() ?? 0;");
        }

        public bool SameType(string type) => "int".Equals(type);
    }
}