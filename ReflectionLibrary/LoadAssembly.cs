using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionLibrary
{
    public class LoadAssembly
    {

        #region Load Assembly

        public static Assembly LoadReflectionOnly(string assemblyPath)
        {
            // Reflection-only context
            return Assembly.ReflectionOnlyLoadFrom(assemblyPath);
        }

        #endregion
    }
}
