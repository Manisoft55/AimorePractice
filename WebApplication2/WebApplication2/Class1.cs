using System;
using System.Collections.Generic;
using System.Data;
using System.Web;

namespace WebApplication2
{
    public class Class1
    {
        public void TestMethod()
        {
            DataSet ds = new DataSet();
            var data = ds.Tables[0].AsEnumerable();
        }
    }
}