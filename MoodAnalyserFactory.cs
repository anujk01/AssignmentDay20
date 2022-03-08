using System;
using System.Reflection;
using System.Text.RegularExpressions;

namespace AssignmentDay20
{
    public class MoodAnalyserFactory
    {

        public object CreateMoodAnalyserParameterizedObject(string className, string constructor)
        {
            string name = constructor;
            bool result = Regex.IsMatch(className, name);
            if (result)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch (ArgumentNullException)
                {
                    throw new CustomException(CustomException.ExceptionType.Empty_Exception, "Mood should not be empty");
                }
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.Null_Exception, "Mood should not be empty");
            }
        }

        public string InvokeAnalyserMethod(string v1, string v2)
        {
            throw new NotImplementedException();
        }

        public object CreateParameterizedConstructor(string className, string constructor, string message = "")
        {
            Type type = typeof(UC5_ParameterConstructor);
            if (type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructor))
                {
                    ConstructorInfo info = type.GetConstructor(new[] { typeof(string) });
                    object instance = info.Invoke(new object[] { (message) });
                    return instance;
                }
                else
                    throw new CustomException(CustomException.ExceptionType.Empty_Exception, "Mood should not be empty");
            }
            else
                throw new CustomException(CustomException.ExceptionType.Null_Exception, "Mood should not be empty");
        }

        public object Constructor(string className, string constructor, string message = "")
        {
                Type type = typeof(UC6_InvokedMethod);
                if (type.FullName.Equals(className))
                {
                    if (type.Name.Equals(constructor))
                    {
                        ConstructorInfo info = type.GetConstructor(new[] { typeof(string) });
                        object instance = info.Invoke(new object[] { (message) });
                        return instance;
                    }
                    else
                        throw new CustomException(CustomException.ExceptionType.Empty_Exception, "Mood should not be empty");
                }
                else
                    throw new CustomException(CustomException.ExceptionType.Null_Exception, "Mood should not be empty");
        }
    }
}