using System;
using System.Diagnostics;
using System.Xml;


public class Rectangle : Child
{

    private double? _MiterLimit;

    public string Self { get; set; }

    public ContentType? ContentType { get; set; }

    public string StoryTitle { get; set; }

    public bool? AllowOverrides { get; set; }

    public string FillColor { get; set; }

    public double? FillTint { get; set; }

    public bool? OverprintFill { get; set; }

    public double? CornerRadius { get; set; }

    public double? StrokeWeight { get; set; }

    public double? MiterLimit
    {
        get
        {
            return _MiterLimit;
        }
        set
        {
            if (value.HasValue)
            {
                if (value >= 1 && value <= 500)
                {
                    _MiterLimit = value;
                }
                else
                {
                    throw (new ArgumentOutOfRangeException("value", value, "MiterLimit in Rectangle does not support allow value."));
                }
            }
        }
    }

    public EndCap? EndCap { get; set; }

    public EndJoin? EndJoin { get; set; }

    public string StrokeType { get; set; }

    public StrokeCornerAdjustment? StrokeCornerAdjustment { get; set; }

    public string StrokeDashAndGap { get; set; }

    public ArrowHead? LeftLineEnd { get; set; }

    public ArrowHead? RightLineEnd { get; set; }

    public string StrokeColor { get; set; }

    public double? StrokeTint { get; set; }

    public UnitPointType GradientFillStart { get; set; }

    public double? GradientFillLength { get; set; }

    public double? GradientFillAngle { get; set; }

    public UnitPointType GradientStrokeStart { get; set; }

    public double? GradientStrokeLength { get; set; }

    public double? GradientStrokeAngle { get; set; }

    public bool? OverprintStroke { get; set; }

    public string GapColor { get; set; }

    public double? GapTint { get; set; }

    public bool? OverprintGap { get; set; }

    public StrokeAlignment? StrokeAlignment { get; set; }

    public bool? Nonprinting { get; set; }

    public string ItemLayer { get; set; }

    public bool? Locked { get; set; }

    public DisplaySettingOptions? LocalDisplaySetting { get; set; }

    public double? GradientFillHiliteLength { get; set; }

    public double? GradientFillHiliteAngle { get; set; }

    public double? GradientStrokeHiliteLength { get; set; }

    public double? GradientStrokeHiliteAngle { get; set; }

    public string AppliedObjectStyle { get; set; }

    public CornerOptions? CornerOption { get; set; }

    public bool? Visible { get; set; }

    public string Name { get; set; }

    public CornerOptions? TopLeftCornerOption { get; set; }

    public CornerOptions? TopRightCornerOption { get; set; }

    public CornerOptions? BottomLeftCornerOption { get; set; }

    public CornerOptions? BottomRightCornerOption { get; set; }

    public double? TopLeftCornerRadius { get; set; }

    public double? TopRightCornerRadius { get; set; }

    public double? BottomLeftCornerRadius { get; set; }

    public double? BottomRightCornerRadius { get; set; }

    public TransformationMatrixType ItemTransform { get; set; }

    public PathGeometry PathGeometry { get; set; }

    public TextWrapPreference TextWrapPreference { get; set; }

    public InCopyExportOption InCopyExportOption { get; set; }

    public static Rectangle ReadXml(XmlReader reader)
    {
        Rectangle r = new Rectangle();

        if (reader.HasAttributes)
        {
            r.Self = System.Convert.ToString(reader.GetAttribute("Self"));
            r.ContentType = (ContentType)Parser.ParseEnum<ContentType>(reader.GetAttribute("ContentType"));
            r.StoryTitle = System.Convert.ToString(reader.GetAttribute("StoryTitle"));
            r.AllowOverrides = Parser.ParseBoolean(reader.GetAttribute("AllowOverrides"));
            r.FillColor = System.Convert.ToString(reader.GetAttribute("FillColor"));
            r.FillTint = Parser.ParseDouble(reader.GetAttribute("FillTint"));
            r.OverprintFill = Parser.ParseBoolean(reader.GetAttribute("OverprintFill"));
            r.CornerRadius = Parser.ParseDouble(reader.GetAttribute("CornerRadius"));
            r.StrokeWeight = Parser.ParseDouble(reader.GetAttribute("StrokeWeight"));
            r.MiterLimit = Parser.ParseDouble(reader.GetAttribute("MiterLimit"));
            r.EndCap = (EndCap?)Parser.ParseEnum<EndCap>(reader.GetAttribute("EndCap"));
            r.EndJoin = (EndJoin?)Parser.ParseEnum<EndJoin>(reader.GetAttribute("EndJoin"));
            r.StrokeType = System.Convert.ToString(reader.GetAttribute("StrokeType"));
            r.StrokeCornerAdjustment = (StrokeCornerAdjustment?)Parser.ParseEnum<StrokeCornerAdjustment>(reader.GetAttribute("StrokeCornerAdjustment"));
            r.StrokeDashAndGap = System.Convert.ToString(reader.GetAttribute("StrokeDashAndGap"));
            r.LeftLineEnd = (ArrowHead?)Parser.ParseEnum<ArrowHead>(reader.GetAttribute("LeftLineEnd"));
            r.RightLineEnd = (ArrowHead?)Parser.ParseEnum<ArrowHead>(reader.GetAttribute("RightLineEnd"));
            r.StrokeColor = System.Convert.ToString(reader.GetAttribute("StrokeColor"));
            r.StrokeTint = Parser.ParseDouble(reader.GetAttribute("StrokeTint"));
            r.GradientFillStart = new UnitPointType(reader.GetAttribute("GradientFillStart"));
            r.GradientFillLength = Parser.ParseDouble(reader.GetAttribute("GradientFillLength"));
            r.GradientFillAngle = Parser.ParseDouble(reader.GetAttribute("GradientFillAngle"));
            r.GradientStrokeStart = new UnitPointType(reader.GetAttribute("GradientStrokeStart"));
            r.GradientStrokeLength = Parser.ParseDouble(reader.GetAttribute("GradientStrokeLength"));
            r.GradientStrokeAngle = Parser.ParseDouble(reader.GetAttribute("GradientStrokeAngle"));
            r.OverprintStroke = Parser.ParseBoolean(reader.GetAttribute("OverprintStroke"));
            r.GapColor = System.Convert.ToString(reader.GetAttribute("GapColor"));
            r.GapTint = Parser.ParseDouble(reader.GetAttribute("GapTint"));
            r.OverprintGap = Parser.ParseBoolean(reader.GetAttribute("OverprintGap"));
            r.StrokeAlignment = (StrokeAlignment?)Parser.ParseEnum<StrokeAlignment>(reader.GetAttribute("StrokeAlignment"));
            r.Nonprinting = Parser.ParseBoolean(reader.GetAttribute("Nonprinting"));
            r.ItemLayer = System.Convert.ToString(reader.GetAttribute("ItemLayer"));
            r.Locked = Parser.ParseBoolean(reader.GetAttribute("Locked"));
            r.LocalDisplaySetting = (DisplaySettingOptions?)Parser.ParseEnum<DisplaySettingOptions>(reader.GetAttribute("LocalDisplaySetting"));
            r.GradientFillHiliteLength = Parser.ParseDouble(reader.GetAttribute("GradientFillHiliteLength"));
            r.GradientFillHiliteAngle = Parser.ParseDouble(reader.GetAttribute("GradientFillHiliteAngle"));
            r.GradientStrokeHiliteLength = Parser.ParseDouble(reader.GetAttribute("GradientStrokeHiliteLength"));
            r.GradientStrokeHiliteAngle = Parser.ParseDouble(reader.GetAttribute("GradientStrokeHiliteAngle"));
            r.AppliedObjectStyle = System.Convert.ToString(reader.GetAttribute("AppliedObjectStyle"));
            r.CornerOption = (CornerOptions?)Parser.ParseEnum<CornerOptions>(reader.GetAttribute("CornerOption"));
            r.Visible = Parser.ParseBoolean(reader.GetAttribute("Visible"));
            r.Name = System.Convert.ToString(reader.GetAttribute("Name"));
            r.TopLeftCornerOption = (CornerOptions?)Parser.ParseEnum<CornerOptions>(reader.GetAttribute("TopLeftCornerOption"));
            r.TopRightCornerOption = (CornerOptions?)Parser.ParseEnum<CornerOptions>(reader.GetAttribute("TopRightCornerOption"));
            r.BottomLeftCornerOption = (CornerOptions?)Parser.ParseEnum<CornerOptions>(reader.GetAttribute("BottomLeftCornerOption"));
            r.BottomRightCornerOption = (CornerOptions?)Parser.ParseEnum<CornerOptions>(reader.GetAttribute("BottomRightCornerOption"));
            r.TopLeftCornerRadius = Parser.ParseDouble(reader.GetAttribute("TopLeftCornerRadius"));
            r.TopRightCornerRadius = Parser.ParseDouble(reader.GetAttribute("TopRightCornerRadius"));
            r.BottomLeftCornerRadius = Parser.ParseDouble(reader.GetAttribute("BottomLeftCornerRadius"));
            r.BottomRightCornerRadius = Parser.ParseDouble(reader.GetAttribute("BottomRightCornerRadius"));
            r.ItemTransform = TransformationMatrixType.Parse(reader.GetAttribute("ItemTransform"));
        }

        if (reader.IsEmptyElement)
            return r;

        while (reader.Read())
        {
            if ((string)reader.Name == "Properties")
            {
                while (reader.Read())
                {
                    if ((string)reader.Name == "PathGeometry")
                    {
                        r.PathGeometry = PathGeometry.ReadXml(reader);
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
                            Debug.WriteLine("Unrecognized element: {0} in element: {1}", reader.Name, "Rectangle - Properties");
                        }
                    }
                }
            }
            else if ((string)reader.Name == "TextWrapPreference")
            {
                r.TextWrapPreference = TextWrapPreference.ReadXml(reader);
            }
            else if ((string)reader.Name == "InCopyExportOption")
            {
                r.InCopyExportOption = InCopyExportOption.ReadXml(reader);
            }
            else if ((string)reader.Name == "Rectangle")
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
                    Debug.WriteLine("Unrecognized element: {0} in element: {1}", reader.Name, "Rectangle");
                }
            }
        }

        return r;
    }

    public override string ToString()
    {
        return "Rectangle - " + this.Self;
    }
}