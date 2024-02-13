using CI.BRE.REPOSITERY.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CI.BRE.SERVICE.IServices
{
    public interface IServices<T> where T : class
    {
       
        Task<int> AddAsync(InsertData post);
    }
}
