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

        #region Instance Members

        public static object CreateWithSpecificConstructor(Type type, 
            DateTime date)
        {
            try
            {
                var result = new List<string>();
                var constructor = type.GetConstructor(new Type[1] { typeof(DateTime) });
                return constructor.Invoke(new object[1] { date });
            }
            catch
            {

                throw;
            }
        }// end CreateWithSpecificConstructor method

        public static object ExecuteMethod(object instance, string methodName)
        {
            try
            {
                var method = instance.GetType().GetMethod(methodName, new Type[0]);
                return method.Invoke(instance, new object[0]);
            }
            catch
            {

                return null;
            }
        }

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

        public static List<string> GetProperties(Type type)
        {
            return (
                from t in type.GetProperties(flags)
                select String.Format(
                    "{0} {1} {2} {{ {3} get; {4} set; }}",
                    t.GetMethod.IsPrivate ? "private" : "public",
                    t.PropertyType.Name,
                    t.Name,
                    t.GetGetMethod(true).IsPrivate ? "private" : "public",
                    t.GetSetMethod(true).IsPrivate ? "private" : "public")
                ).ToList();
        }

        public static List<string> GetMethods(Type type)
        {
            var result = new List<string>();
            var methods =
                from method in type.GetMethods(flags)
                where !method.Name.Contains("get_") &&
                    !method.Name.Contains("set_")
                select method;

            foreach (var method in methods)
            {
                var parameters = new StringBuilder();
                foreach (var parameter in method.GetParameters())
                    parameters.Append(String.Format("{0} {1}, ",
                        parameter.ParameterType.Name, parameter.Name));

                if (parameters.Length > 0)
                    parameters.Remove(parameters.Length - 2, 2);

                result.Add(String.Format("{0} {1} {2}({3})",
                    method.IsPrivate ? "private" : "publice",
                    method.ReflectedType.Name,
                    method.Name,
                    parameters.ToString()));
            }
            return result;
        }

        #endregion

    }
}
