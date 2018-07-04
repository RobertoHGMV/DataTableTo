﻿using DataTableTo.Domain.Model;
using DataTableTo.Domain.Model.FromToCreation;
using System.Text;

namespace DataTableTo.Domain.Services
{
    public class FromToService : IFromToService
    {
        public void CreateFromTo(IFromToType fromToType, UserData userData)
        {
            fromToType.CreateFromType(this, userData);
        }

        public void FillDataRow(StringBuilder sb, UserData userData, TableData data)
        {
            sb.Append(userData.RowName);
            sb.Append("[");
            FillRow(sb, userData, data);
            sb.Append("]");
        }

        public void FillRow(StringBuilder sb, UserData userData, TableData data)
        {
            sb.Append(userData.ColumnPrefix);
            sb.Append(data.ColumnName);
            sb.Append(userData.ColumnSufix);
        }
    }
}
