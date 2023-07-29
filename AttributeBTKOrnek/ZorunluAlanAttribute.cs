using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace AttributeBTKOrnek
{
    [AttributeUsage(AttributeTargets.Field,AllowMultiple =true,Inherited =true)]
    public class ZorunluAlanAttribute:Attribute
    {
    }
}
