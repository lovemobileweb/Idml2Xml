

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Xml;

public class Descriptor
{
	public Descriptor()
	{
		ListItems = new List<ListItem>();
	}

	public List<ListItem> ListItems { get; set; }

	public static Descriptor ReadXml(XmlReader reader)
	{
		Descriptor result = new Descriptor();

        if (reader.IsEmptyElement)
            return result;

        while (reader.Read()) {
			if (reader.Name == "ListItem") {
				switch (reader.GetAttribute("type")) {
					case "string":
						result.ListItems.Add(new ListItemString(reader.ReadElementContentAsString()));
						break;
					case "enumeration":
						result.ListItems.Add(new ListItemEnum((PageNumberStyle)Parser.ParseEnum<PageNumberStyle>(reader.ReadElementContentAsString())));
						break;
					case "bool":
						result.ListItems.Add(new ListItemBool(reader.ReadElementContentAsBoolean()));
						break;
					case "long":
						result.ListItems.Add(new ListItemLong(reader.ReadElementContentAsInt()));
						break;
				}
			} else if (reader.Name == "Descriptor" & reader.NodeType == XmlNodeType.EndElement) {
				break;
			}
		}

		return result;
	}
}

public class ListItem
{
}

public class ListItemString : ListItem
{

	public ListItemString(string value)
	{
		this.Value = value;
	}

	public string Value { get; set; }
}

public class ListItemEnum : ListItem
{

	public ListItemEnum(PageNumberStyle value)
	{
		this.Value = value;
	}

	public PageNumberStyle Value { get; set; }
}

public class ListItemBool : ListItem
{

	public ListItemBool(bool value)
	{
		this.Value = value;
	}

	public bool Value { get; set; }
}

public class ListItemLong : ListItem
{


	private int _value;
	public ListItemLong(int value)
	{
		this.Value = value;
	}

	public int Value {
		get { return _value; }
		set {
			if (value >= 1 & value <= 999999) {
				_value = value;
			}
		}
	}
}

public class ListItemUnit : ListItem
{


	private double _value;
	public ListItemUnit(double value)
	{
		this.Value = value;
	}

	public double Value {
		get { return _value; }
		set {
			if (value >= 1 & value <= 8640) {
				_value = value;
			}
		}
	}
}

public class ListItemDouble : ListItem
{


	private double _value;
	public ListItemDouble(double value)
	{
		this.Value = value;
	}

	public double Value {
		get { return _value; }
		set {
			if (value >= 0 & value <= 255) {
				_value = value;
			}
		}
	}
}

//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================
