using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionLibrary
{
    public class Members
    {

        #region Type Methods

        public static List<string> GetTypeNames(Assembly assembly)
        {
            return assembly.GetTypes().Select(t =>
                t.FullName).ToList();
        }

        #endregion

    }
}
