

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

public class UnitPointType
{
	public double X { get; set; }
	public double Y { get; set; }

	public UnitPointType(double x, double y)
	{
		X = x;
		Y = y;
	}

	public UnitPointType(string coordinates)
	{
		if (!string.IsNullOrEmpty(coordinates)) {
			string[] stringcoordinates = null;

			stringcoordinates = coordinates.Split(' ');
			X = (double)Parser.ParseDouble(stringcoordinates[0]);
			Y = (double)Parser.ParseDouble(stringcoordinates[1]);
		}
	}

	public override string ToString()
	{
		return "x: " + X + " - " + "y: " + Y;
	}
}

