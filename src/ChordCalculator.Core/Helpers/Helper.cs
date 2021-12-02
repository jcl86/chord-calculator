using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

public static class Helper
{
    public static string Description<T>(this T value) where T : Enum
    {
        FieldInfo fi = typeof(T).GetField(value.ToString());
        var attributes = fi.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];
        if (attributes != null && attributes.Any())
            return attributes.First().Description;
        return value.ToString();
    }
}
