using System;
using System.Collections.Generic;
using System.Text;

namespace AwareGroup.SenseCAP.Models
{
    public class PagedData<T>
    {
        public Page Page { get; set; }

        public List<T> List { get; set; }
    }
}
