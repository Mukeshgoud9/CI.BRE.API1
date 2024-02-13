using CI.BRE.REPOSITERY.ApplicationDbContext;
using CI.BRE.REPOSITERY.Entities;
using CI.BRE.SERVICE.IServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CI.BRE.SERVICE.Services
{
    public class Services<T> : IServices<T> where T : class
    {
        private readonly BREProjectContext _context;

        public Services(BREProjectContext context)
        {

            _context = context;
        }
        public async Task<int> AddAsync(InsertData entity)
        {
            var data = new SpsBrArgumentValue
            {
                ProvinceState = entity.ProvinceState,
                ArgumentType = entity.ArgumentType,
                RuleType = entity.RuleType,
                Operator = entity.Operator,
                TableName = entity.TableName,
                ColumnName = entity.ColumnName,
                ArgValue1 = entity.ArgValue1,
                ArgValue2 = entity.ArgValue2,
                UiRule = entity.UiRule,
                EtlRule = entity.EtlRule,
                ErrorDescription = entity.ErrorDescription,
                RowCreatedBy = entity.RowCreatedBy,
                RowCreatedDate = entity.RowCreatedDate,
                RowChangedBy = entity.RowChangedBy,
                RowChangedDate = entity.RowChangedDate,
                RunOrder = entity.RunOrder,
                Severity = entity.Severity,
                RuleVersion = "2.0.0",
                Expression = entity.Expression,
                InputArgV2 = entity.InputArgV2,
                ArgumentValue = entity.ArgumentValue,
                IsBre2 = entity.IsBre2,
                RuleRange = entity.RuleRange
            };
            await _context.AddAsync(data);
            await _context.SaveChangesAsync();
            return 1;
        }
    }
}

