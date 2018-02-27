using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTableTo.Domain.Model
{
    public interface IUserDataRepository
    {
        UserData GetFields(UserData dataTable);
    }
}
