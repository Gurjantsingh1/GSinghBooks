using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gsingh.DataAccess.Repository.IRepository
{
    public interface ISP_Call : IDisposable
    {
        T Single<T>(string procedurename, DynamicParameters param = null);
        void Execute(string procedurename, DynamicParameters param = null);
        T OneRecord<T>(string procedurename, DynamicParameters param = null);
        IEnumerable<T> List<T>(string procedurename, DynamicParameters param = null);
        Tuple<IEnumerable<T1>,IEnumerable<T2>> List<T1, T2>(string procedurename, DynamicParameters param = null);

    }
}
