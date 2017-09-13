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
        #region Constants

        static BindingFlags flags =
            BindingFlags.Instance | BindingFlags.NonPublic |
            BindingFlags.Public | BindingFlags.DeclaredOnly;

        #endregion

        #region Type Methods

        public static List<string> GetTypeNames(Assembly assembly)
        {
            return assembly.GetTypes().Select(t =>
                t.FullName).ToList();
        }

        public static Type GetType(Assembly assembly, string typeName)
        {
            return assembly.GetType(typeName);
        }

        #endregion

        #region Fetch Type Members

        public static List<string> GetConstructors(Type type)
        {
            //Iterate over the constructors
            var constructors = new List<string>();

            foreach (var constructor in type.GetConstructors())
            {
                var ctr = new StringBuilder(String.Format("{0}(", type.Name));
                var parameters = new StringBuilder();

                foreach (var parameter in constructor.GetParameters())
                    parameters.Append(String.Format("{0} {1}, ",
                        parameter.ParameterType.Name, parameter.Name));

                if (parameters.Length.Equals(0))
                    ctr.Append(")");
                else
                    ctr.Append(String.Format("{0})",
                        parameters.ToString().Substring(0,
                        parameters.Length - 2)));
                constructors.Add(ctr.ToString());
            }
            return constructors;
        } // end GetConstructors method

        public static List<string> GetFields(Type type)
        {
            return (
                from t in type.GetFields(flags)
                where !t.Name.Contains("<")
                select String.Format("{0} {1} {2}", t.IsPrivate ?
                    "private" : "public", t.FieldType.Name, t.Name)
                ).ToList();
        }

        #endregion

    }
}
