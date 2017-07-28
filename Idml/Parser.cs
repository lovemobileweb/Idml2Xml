

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
public class Parser
{
	public static double? ParseDouble(string number)
	{
		if (string.IsNullOrEmpty(number))
			return null;

		return double.Parse(number, System.Globalization.CultureInfo.InvariantCulture);
	}

	public static object ParseEnum<T>(string value)
	{
		if (string.IsNullOrEmpty(value))
			return null;

		return Enum.Parse(typeof(T), value);
	}

	public static Nullable<bool> ParseBoolean(string value)
	{
		if (string.IsNullOrEmpty(value))
			return null;

		return Convert.ToBoolean(value);
	}

	public static System.DateTime? ParseDate(string value)
	{
		if (string.IsNullOrEmpty(value))
			return null;

		return DateTime.Parse(value, System.Globalization.CultureInfo.InvariantCulture);
	}

    public static UInt64 ParseHexNumber(string value)
    {
        if (string.IsNullOrEmpty(value))
            return 0;
        if (value[0] == 'u')
            value = value.Substring(1);
        return UInt64.Parse(value, System.Globalization.NumberStyles.HexNumber);
    }
}
