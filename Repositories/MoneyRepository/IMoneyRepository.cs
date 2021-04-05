using System.Collections.Generic;
using System.Data.Entity;

namespace TestTaskFromNikita.Repositories.MoneyRepository
{
    public interface IMoneyRepository
    {
        IEnumerable<money> GetMoney();
    }
}