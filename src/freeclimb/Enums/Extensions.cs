using System;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace freeclimb.Enums
{

    public static partial class Extensions
    {
        public static string GetMemberValue(this Enum @this)
        {
            FieldInfo fieldInfo = @this.GetType().GetField(@this.ToString());
            if (fieldInfo == null) return null;
            var attribute = (EnumMemberAttribute)fieldInfo.GetCustomAttribute(typeof(EnumMemberAttribute));
            return attribute.Value;
        }
    }
}