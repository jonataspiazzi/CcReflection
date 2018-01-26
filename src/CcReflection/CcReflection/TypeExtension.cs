using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CcReflection
{
    public static class TypeExtension
    {
        public static bool IsExtendedPrimitive(this Type type)
        {
            type = Nullable.GetUnderlyingType(type) ?? type;

            if (type.IsPrimitive) return true;
            if (type.IsEnum) return true;
            if (type == typeof(decimal)) return true;
            if (type == typeof(string)) return true;
            if (type == typeof(DateTime)) return true;
            if (type == typeof(TimeSpan)) return true;

            return false;
        }
    }
}
