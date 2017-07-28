using System;
using System.Diagnostics;
using System.Xml;


public class TextFrame : Child
{

    public override string ToString()
    {
        return "TextFrame" + this.Self;
    }

    public PathGeometry PathGeometry { get; set; }

    public string Self { get; set; }

    public string Name { get; set; }

    public string ParentStory { get; set; }

    public string PreviousTextFrame { get; set; }

    public string NextTextFrame { get; set; }

    public ContentType ContentType { get; set; }

    public double? StrokeWeight { get; set; }

    public UnitPointType GradientFillStart { get; set; }

    public double? GradientFillLength { get; set; }

    public double? GradientFillAngle { get; set; }

    public UnitPointType GradientStrokeStart { get; set; }

    public double? GradientStrokeLength { get; set; }

    public double? GradientStrokeAngle { get; set; }

    public string ItemLayer { get; set; }

    public Nullable<bool> Locked { get; set; }

    public DisplaySettingOptions? LocalDisplaySetting { get; set; }

    public double? GradientFillHiliteLength { get; set; }

    public double? GradientFillHiliteAngle { get; set; }

    public double? GradientStrokeHiliteLength { get; set; }

    public double? GradientStrokeHiliteAngle { get; set; }

    public string AppliedObjectStyle { get; set; }

    public bool? Visible { get; set; }

    public string ItemTransform { get; set; }

    public TextFramePreference TextFramePreference { get; set; }

    public TextWrapPreference TextWrapPreference { get; set; }

    public static TextFrame ReadXml(XmlReader reader)
    {
        TextFrame tf = new TextFrame();

        if (reader.HasAttributes)
        {
            tf.Self = System.Convert.ToString(reader.GetAttribute("Self"));
            tf.ParentStory = System.Convert.ToString(reader.GetAttribute("ParentStory"));
            tf.PreviousTextFrame = System.Convert.ToString(reader.GetAttribute("PreviousTextFrame"));
            tf.NextTextFrame = System.Convert.ToString(reader.GetAttribute("NextTextFrame"));
            tf.ContentType = (ContentType)Enum.Parse(typeof(ContentType), reader.GetAttribute("ContentType"));
            tf.StrokeWeight = Parser.ParseDouble(reader.GetAttribute("StrokeWeight"));
            tf.GradientFillStart = new UnitPointType(reader.GetAttribute("GradientFillStart"));
            tf.GradientFillLength = Parser.ParseDouble(reader.GetAttribute("GradientFillLength"));
            tf.GradientFillAngle = Parser.ParseDouble(reader.GetAttribute("GradientFillAngle"));
            tf.GradientStrokeStart = new UnitPointType(reader.GetAttribute("GradientStrokeStart"));
            tf.GradientStrokeLength = Parser.ParseDouble(reader.GetAttribute("GradientStrokeLength"));
            tf.GradientStrokeAngle = Parser.ParseDouble(reader.GetAttribute("GradientStrokeAngle"));
            tf.ItemLayer = System.Convert.ToString(reader.GetAttribute("ItemLayer"));
            tf.Locked = Parser.ParseBoolean(reader.GetAttribute("Locked"));
            tf.LocalDisplaySetting = (DisplaySettingOptions?)Parser.ParseEnum<DisplaySettingOptions>(reader.GetAttribute("LocalDisplaySetting"));
            tf.GradientFillHiliteLength = Parser.ParseDouble(reader.GetAttribute("GradientFillHiliteLength"));
            tf.GradientFillHiliteAngle = Parser.ParseDouble(reader.GetAttribute("GradientFillHiliteAngle"));
            tf.GradientStrokeHiliteLength = Parser.ParseDouble(reader.GetAttribute("GradientStrokeHiliteLength"));
            tf.GradientStrokeHiliteAngle = Parser.ParseDouble(reader.GetAttribute("GradientStrokeHiliteAngle"));
            tf.AppliedObjectStyle = System.Convert.ToString(reader.GetAttribute("AppliedObjectStyle"));
            tf.Visible = Parser.ParseBoolean(reader.GetAttribute("Visible"));
            tf.Name = System.Convert.ToString(reader.GetAttribute("Name"));
            tf.ItemTransform = System.Convert.ToString(reader.GetAttribute("ItemTransform"));
        }

        if (reader.IsEmptyElement)
            return tf;

        while (reader.Read())
        {
            if ((string)reader.Name == "Properties")
            {
                while (reader.Read())
                {
                    if ((string)reader.Name == "PathGeometry")
                    {
                        tf.PathGeometry = PathGeometry.ReadXml(reader);
                    }
                    else if ((string)reader.Name == "Properties")
                    {
                        if (reader.NodeType == XmlNodeType.EndElement)
                        {
                            break;
                        }
                    }
                    else
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            Debug.WriteLine("Unrecognized element: {0} in element: {1}", reader.Name, "TextFrame - Properties");
                        }
                    }
                }
            }
            else if ((string)reader.Name == "TextFramePreference")
            {
                tf.TextFramePreference = TextFramePreference.ReadXml(reader);
            }
            else if ((string)reader.Name == "TextWrapPreference")
            {
                tf.TextWrapPreference = TextWrapPreference.ReadXml(reader);
            }
            else if ((string)reader.Name == "TextFrame")
            {
                if (reader.NodeType == XmlNodeType.EndElement)
                {
                    break;
                }
            }
            else
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    Debug.WriteLine("Unrecognized element: {0} in element: {1}", reader.Name, "TextFrame");
                }
            }
        }

        return tf;
    }
}