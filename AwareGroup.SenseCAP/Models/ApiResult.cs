using System;
using System.Collections.Generic;
using System.Text;

namespace AwareGroup.SenseCAP.Models
{
    public class ApiResult<T>
    {
        public int Code { get; set; }
        public double Time { get; set; }

        public T Data { get; set; }
    }
}
