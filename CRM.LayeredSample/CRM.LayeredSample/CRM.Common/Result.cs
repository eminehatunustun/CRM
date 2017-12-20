using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Common
{
    public class Result
    {
        public bool IsSucceeded { get; set; }
        public Result()
        {
            IsSucceeded = false; //defaultta false çektik
        }
    }
    public class Result<T> :Result
    {
        public T TransactionResult { get; set; }
    }
}
