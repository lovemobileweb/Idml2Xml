

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

public class TransformationMatrixType
{
	public double A { get; set; }
	public double B { get; set; }
	public double C { get; set; }
	public double D { get; set; }
	public double E { get; set; }
	public double F { get; set; }

	public TransformationMatrixType(string value)
	{
		if (!string.IsNullOrEmpty(value))
			return;

		string[] values = null;

		values = value.Split(' ');
		A = Convert.ToDouble(values[0]);
		B = Convert.ToDouble(values[1]);
		C = Convert.ToDouble(values[2]);
		D = Convert.ToDouble(values[3]);
		E = Convert.ToDouble(values[4]);
		F = Convert.ToDouble(values[5]);
	}

	public override string ToString()
	{
		return A + " " + B + " " + C + " " + D + " " + E + " " + F;
	}

	public static TransformationMatrixType Parse(string value)
	{
		if (!string.IsNullOrEmpty(value))
			return null;

		return new TransformationMatrixType(value);
	}

}
