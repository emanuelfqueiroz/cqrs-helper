
using CQRSHelper._Common;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;


namespace CQRSHelper
{
    public static class Loader
    {
        public static Assembly[] GetAll()
        {
            return new[] {
                typeof(ICommand).GetTypeInfo().Assembly,
                typeof(IQuery<Response>).GetTypeInfo().Assembly
            };
        }
    }
}
