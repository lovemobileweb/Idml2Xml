

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Xml;

namespace Stories
{
    public class Table : Child
    {
        public Table()
        {
            Rows = new List<Row>();
            Columns = new List<Column>();
            Cells = new List<Cell>();
        }

        public string Self { get; set; }

        public double? HeaderRowCount { get; set; }

        public double? FooterRowCount { get; set; }

        public double? TextTopInset { get; set; }

        public double? TextLeftInset { get; set; }

        public double? TextBottomInset { get; set; }

        public double? TextRightInset { get; set; }

        public bool? ClipContentToTextCell { get; set; }

        public double? BodyRowCount { get; set; }

        public double? ColumnCount { get; set; }

        public string AppliedTableStyle { get; set; }

        public CharacterDirectionOptions? TableDirection { get; set; }

        public double? LeftBorderStrokeWeight { get; set; }

        public string LeftBorderStrokeType { get; set; }

        public double? RightBorderStrokeWeight { get; set; }

        public string RightBorderStrokeType { get; set; }

        public double? TopBorderStrokeWeight { get; set; }

        public string TopBorderStrokeType { get; set; }

        public double? BottomBorderStrokeWeight { get; set; }

        public string BottomBorderStrokeType { get; set; }

        public string StartRowStrokeColor { get; set; }

        public double? StartRowStrokeCount { get; set; }

        public double? EndRowStrokeCount { get; set; }

        public string StartRowStrokeType { get; set; }

        public string EndRowStrokeType { get; set; }

        public string StartColumnStrokeColor { get; set; }

        public double? StartColumnStrokeCount { get; set; }

        public double? EndColumnStrokeCount { get; set; }

        public string StartColumnStrokeType { get; set; }

        public string EndColumnLineStyle { get; set; }

        public double? StartRowStrokeWeight { get; set; }

        public double? EndRowStrokeWeight { get; set; }

        public double? StartColumnStrokeWeight { get; set; }

        public double? EndColumnStrokeWeight { get; set; }

        public double? GraphicLeftInset { get; set; }

        public double? GraphicTopInset { get; set; }

        public double? GraphicRightInset { get; set; }

        public double? GraphicBottomInset { get; set; }

        public bool? ClipContentToGraphicCell { get; set; }

        public List<Row> Rows { get; set; }

        public List<Column> Columns { get; set; }

        public List<Cell> Cells { get; set; }
        
        public static Table ReadXml(XmlReader reader)
		{
            Table result = new Table();

            if (reader.HasAttributes)
            {
                result.Self = System.Convert.ToString(reader.GetAttribute("Self"));
                result.HeaderRowCount = Parser.ParseDouble(reader.GetAttribute("HeaderRowCount"));
                result.FooterRowCount = Parser.ParseDouble(reader.GetAttribute("FooterRowCount"));
                result.TextTopInset = Parser.ParseDouble(reader.GetAttribute("TextTopInset"));
                result.TextLeftInset = Parser.ParseDouble(reader.GetAttribute("TextLeftInset"));
                result.TextBottomInset = Parser.ParseDouble(reader.GetAttribute("TextBottomInset"));
                result.TextRightInset = Parser.ParseDouble(reader.GetAttribute("TextRightInset"));
                result.ClipContentToTextCell = Parser.ParseBoolean(reader.GetAttribute("ClipContentToTextCell"));
                result.BodyRowCount = Parser.ParseDouble(reader.GetAttribute("BodyRowCount"));
                result.ColumnCount = Parser.ParseDouble(reader.GetAttribute("ColumnCount"));
                result.AppliedTableStyle = System.Convert.ToString(reader.GetAttribute("AppliedTableStyle"));
                result.TableDirection = (CharacterDirectionOptions?)Parser.ParseEnum<CharacterDirectionOptions>(reader.GetAttribute("TableDirection"));
                result.LeftBorderStrokeWeight = Parser.ParseDouble(reader.GetAttribute("LeftBorderStrokeWeight"));
                result.LeftBorderStrokeType = System.Convert.ToString(reader.GetAttribute("LeftBorderStrokeType"));
                result.RightBorderStrokeWeight = Parser.ParseDouble(reader.GetAttribute("RightBorderStrokeWeight"));
                result.RightBorderStrokeType = System.Convert.ToString(reader.GetAttribute("RightBorderStrokeType"));
                result.TopBorderStrokeWeight = Parser.ParseDouble(reader.GetAttribute("TopBorderStrokeWeight"));
                result.TopBorderStrokeType = System.Convert.ToString(reader.GetAttribute("TopBorderStrokeType"));
                result.BottomBorderStrokeWeight = Parser.ParseDouble(reader.GetAttribute("BottomBorderStrokeWeight"));
                result.BottomBorderStrokeType = System.Convert.ToString(reader.GetAttribute("BottomBorderStrokeType"));
                result.StartRowStrokeColor = System.Convert.ToString(reader.GetAttribute("StartRowStrokeColor"));
                result.StartRowStrokeCount = Parser.ParseDouble(reader.GetAttribute("StartRowStrokeCount"));
                result.EndRowStrokeCount = Parser.ParseDouble(reader.GetAttribute("EndRowStrokeCount"));
                result.StartRowStrokeType = System.Convert.ToString(reader.GetAttribute("StartRowStrokeType"));
                result.EndRowStrokeType = System.Convert.ToString(reader.GetAttribute("EndRowStrokeType"));
                result.StartColumnStrokeColor = System.Convert.ToString(reader.GetAttribute("StartColumnStrokeColor"));
                result.StartColumnStrokeCount = Parser.ParseDouble(reader.GetAttribute("StartColumnStrokeCount"));
                result.EndColumnStrokeCount = Parser.ParseDouble(reader.GetAttribute("EndColumnStrokeCount"));
                result.StartColumnStrokeType = System.Convert.ToString(reader.GetAttribute("StartColumnStrokeType"));
                result.EndColumnLineStyle = System.Convert.ToString(reader.GetAttribute("EndColumnLineStyle"));
                result.StartRowStrokeWeight = Parser.ParseDouble(reader.GetAttribute("StartRowStrokeWeight"));
                result.EndRowStrokeWeight = Parser.ParseDouble(reader.GetAttribute("EndRowStrokeWeight"));
                result.StartColumnStrokeWeight = Parser.ParseDouble(reader.GetAttribute("StartColumnStrokeWeight"));
                result.EndColumnStrokeWeight = Parser.ParseDouble(reader.GetAttribute("EndColumnStrokeWeight"));
                result.GraphicLeftInset = Parser.ParseDouble(reader.GetAttribute("GraphicLeftInset"));
                result.GraphicTopInset = Parser.ParseDouble(reader.GetAttribute("GraphicTopInset"));
                result.GraphicRightInset = Parser.ParseDouble(reader.GetAttribute("GraphicRightInset"));
                result.GraphicBottomInset = Parser.ParseDouble(reader.GetAttribute("GraphicBottomInset"));
                result.ClipContentToGraphicCell = Parser.ParseBoolean(reader.GetAttribute("ClipContentToGraphicCell"));
            }

            if (reader.IsEmptyElement)
                return result;

            while (reader.Read())
            {
                switch (reader.Name)
                {
                    case "Row":
                        result.Rows.Add(Row.ReadXml(reader));
                        break;
                    case "Column":
                        result.Columns.Add(Column.ReadXml(reader));
                        break;
                    case "Cell":
                        result.Cells.Add(Cell.ReadXml(reader));
                        break;
                    case "Table":
                        if (reader.NodeType == XmlNodeType.EndElement)
                            goto exit1;
                        break;
                    default:
                        Debug.WriteLine("Unrecognized element: {0} in element: {1}", reader.Name, "Note");
                        break;
                }
            }

            exit1:
            return result;
        }
    }

    public class Row : Child
    {
        public string Self { get; set; }

        public string Name { get; set; }

        public double? TextTopInset { get; set; }

        public double? TextLeftInset { get; set; }

        public double? TextBottomInset { get; set; }

        public double? TextRightInset { get; set; }

        public bool? ClipContentToTextCell { get; set; }

        public double? SingleRowHeight { get; set; }

        public double? MinimumHeight { get; set; }

        public bool? AutoGrow { get; set; }

        public static Row ReadXml(XmlReader reader)
        {
            Row result = new Row();

            if (reader.HasAttributes)
            {
                result.Self = System.Convert.ToString(reader.GetAttribute("Self"));
                result.Name = System.Convert.ToString(reader.GetAttribute("Name"));
                result.TextTopInset = Parser.ParseDouble(reader.GetAttribute("TextTopInset"));
                result.TextLeftInset = Parser.ParseDouble(reader.GetAttribute("TextLeftInset"));
                result.TextBottomInset = Parser.ParseDouble(reader.GetAttribute("TextBottomInset"));
                result.TextRightInset = Parser.ParseDouble(reader.GetAttribute("TextRightInset"));
                result.ClipContentToTextCell = Parser.ParseBoolean(reader.GetAttribute("ClipContentToTextCell"));
                result.SingleRowHeight = Parser.ParseDouble(reader.GetAttribute("SingleRowHeight"));
                result.MinimumHeight = Parser.ParseDouble(reader.GetAttribute("MinimumHeight"));
                result.AutoGrow = Parser.ParseBoolean(reader.GetAttribute("AutoGrow"));
            }

            return result;
        }
    }

    public class Column : Child
    {
        public string Self { get; set; }

        public string Name { get; set; }

        public double? TextTopInset { get; set; }

        public double? TextLeftInset { get; set; }

        public double? TextBottomInset { get; set; }

        public double? TextRightInset { get; set; }

        public bool? ClipContentToTextCell { get; set; }

        public double? SingleColumnWidth { get; set; }

        public static Column ReadXml(XmlReader reader)
        {
            Column result = new Column();

            if (reader.HasAttributes)
            {
                result.Self = System.Convert.ToString(reader.GetAttribute("Self"));
                result.Name = System.Convert.ToString(reader.GetAttribute("Name"));
                result.TextTopInset = Parser.ParseDouble(reader.GetAttribute("TextTopInset"));
                result.TextLeftInset = Parser.ParseDouble(reader.GetAttribute("TextLeftInset"));
                result.TextBottomInset = Parser.ParseDouble(reader.GetAttribute("TextBottomInset"));
                result.TextRightInset = Parser.ParseDouble(reader.GetAttribute("TextRightInset"));
                result.ClipContentToTextCell = Parser.ParseBoolean(reader.GetAttribute("ClipContentToTextCell"));
                result.SingleColumnWidth = Parser.ParseDouble(reader.GetAttribute("SingleColumnWidth"));
            }

            return result;
        }
    }

    public class Cell : Child
    {
        public Cell()
        {
            Children = new List<Child>();
        }

        public string Self { get; set; }

        public string Name { get; set; }

        public int? RowSpan { get; set; }

        public int? ColumnSpan { get; set; }

        public string CellType { get; set; }

        public double? TextTopInset { get; set; }

        public double? TextLeftInset { get; set; }

        public double? TextBottomInset { get; set; }

        public double? TextRightInset { get; set; }

        public bool? ClipContentToTextCell { get; set; }

        public string AppliedCellStyle { get; set; }

        public int? AppliedCellStylePriority { get; set; }

        public double? TopInset { get; set; }

        public double? LeftInset { get; set; }

        public double? BottomInset { get; set; }

        public double? RightInset { get; set; }

        public string FillColor { get; set; }

        public int? FillTint { get; set; }

        public double? LeftEdgeStrokeWeight { get; set; }

        public double? RightEdgeStrokeWeight { get; set; }

        public double? TopEdgeStrokeWeight { get; set; }

        public double? BottomEdgeStrokeWeight { get; set; }

        public string LeftEdgeStrokeColor { get; set; }

        public string TopEdgeStrokeColor { get; set; }

        public string RightEdgeStrokeColor { get; set; }

        public string BottomEdgeStrokeColor { get; set; }

        public string LeftEdgeStrokeType { get; set; }

        public string RightEdgeStrokeType { get; set; }

        public string TopEdgeStrokeType { get; set; }

        public string BottomEdgeStrokeType { get; set; }

        public string FirstBaselineOffset { get; set; }

        public VerticalJustification? VerticalJustification { get; set; }

        public int? LeftEdgeStrokeTint { get; set; }

        public int? RightEdgeStrokeTint { get; set; }

        public int? TopEdgeStrokeTint { get; set; }

        public int? BottomEdgeStrokeTint { get; set; }

        public bool? LeftEdgeStrokeOverprint { get; set; }

        public bool? RightEdgeStrokeOverprint { get; set; }

        public bool? TopEdgeStrokeOverprint { get; set; }

        public bool? BottomEdgeStrokeOverprint { get; set; }

        public bool? WritingDirection { get; set; }

        public double? LeftEdgeStrokePriority { get; set; }

        public double? RightEdgeStrokePriority { get; set; }

        public double? TopEdgeStrokePriority { get; set; }

        public double? BottomEdgeStrokePriority { get; set; }

        public int? LeftEdgeStrokeGapTint { get; set; }

        public int? RightEdgeStrokeGapTint { get; set; }

        public int? TopEdgeStrokeGapTint { get; set; }

        public int? BottomEdgeStrokeGapTint { get; set; }

        public bool? LeftEdgeStrokeGapOverprint { get; set; }

        public bool? RightEdgeStrokeGapOverprint { get; set; }

        public bool? TopEdgeStrokeGapOverprint { get; set; }

        public bool? BottomEdgeStrokeGapOverprint { get; set; }

        private List<Child> Children { get; set; }

        public static Cell ReadXml(XmlReader reader)
        {
            Cell result = new Cell();

            if (reader.HasAttributes)
            {
                result.Self = System.Convert.ToString(reader.GetAttribute("Self"));
                result.Name = System.Convert.ToString(reader.GetAttribute("Name"));
                result.RowSpan = System.Convert.ToInt32(reader.GetAttribute("RowSpan"));
                result.ColumnSpan = System.Convert.ToInt32(reader.GetAttribute("RowSpan"));
                result.CellType = System.Convert.ToString(reader.GetAttribute("CellType"));
                result.TextTopInset = Parser.ParseDouble(reader.GetAttribute("TextTopInset"));
                result.TextLeftInset = Parser.ParseDouble(reader.GetAttribute("TextLeftInset"));
                result.TextBottomInset = Parser.ParseDouble(reader.GetAttribute("TextBottomInset"));
                result.TextRightInset = Parser.ParseDouble(reader.GetAttribute("TextRightInset"));
                result.ClipContentToTextCell = Parser.ParseBoolean(reader.GetAttribute("ShowMasterItems"));
                result.AppliedCellStyle = System.Convert.ToString(reader.GetAttribute("CellType"));
                result.AppliedCellStylePriority = System.Convert.ToInt32(reader.GetAttribute("AppliedCellStylePriority"));
                result.TopInset = Parser.ParseDouble(reader.GetAttribute("TopInset"));
                result.LeftInset = Parser.ParseDouble(reader.GetAttribute("LeftInset"));
                result.BottomInset = Parser.ParseDouble(reader.GetAttribute("BottomInset"));
                result.RightInset = Parser.ParseDouble(reader.GetAttribute("RightInset"));
                result.FillColor = System.Convert.ToString(reader.GetAttribute("FillColor"));
                result.FillTint = System.Convert.ToInt32(reader.GetAttribute("FillTint"));
                result.LeftEdgeStrokeWeight = Parser.ParseDouble(reader.GetAttribute("LeftEdgeStrokeWeight"));
                result.RightEdgeStrokeWeight = Parser.ParseDouble(reader.GetAttribute("RightEdgeStrokeWeight"));
                result.TopEdgeStrokeWeight = Parser.ParseDouble(reader.GetAttribute("TopEdgeStrokeWeight"));
                result.BottomEdgeStrokeWeight = Parser.ParseDouble(reader.GetAttribute("BottomEdgeStrokeWeight"));
                result.LeftEdgeStrokeColor = System.Convert.ToString(reader.GetAttribute("LeftEdgeStrokeColor"));
                result.TopEdgeStrokeColor = System.Convert.ToString(reader.GetAttribute("TopEdgeStrokeColor"));
                result.RightEdgeStrokeColor = System.Convert.ToString(reader.GetAttribute("RightEdgeStrokeColor"));
                result.BottomEdgeStrokeColor = System.Convert.ToString(reader.GetAttribute("BottomEdgeStrokeColor"));
                result.LeftEdgeStrokeType = System.Convert.ToString(reader.GetAttribute("LeftEdgeStrokeType"));
                result.RightEdgeStrokeType = System.Convert.ToString(reader.GetAttribute("RightEdgeStrokeType"));
                result.TopEdgeStrokeType = System.Convert.ToString(reader.GetAttribute("TopEdgeStrokeType"));
                result.BottomEdgeStrokeType = System.Convert.ToString(reader.GetAttribute("BottomEdgeStrokeType"));
                result.FirstBaselineOffset = System.Convert.ToString(reader.GetAttribute("FirstBaselineOffset"));
                result.VerticalJustification = (VerticalJustification?)Parser.ParseEnum<VerticalJustification>(reader.GetAttribute("VerticalJustification"));
                result.LeftEdgeStrokeTint = System.Convert.ToInt32(reader.GetAttribute("LeftEdgeStrokeTint"));
                result.RightEdgeStrokeTint = System.Convert.ToInt32(reader.GetAttribute("RightEdgeStrokeTint"));
                result.TopEdgeStrokeTint = System.Convert.ToInt32(reader.GetAttribute("TopEdgeStrokeTint"));
                result.BottomEdgeStrokeTint = System.Convert.ToInt32(reader.GetAttribute("BottomEdgeStrokeTint"));
                result.LeftEdgeStrokeOverprint = Parser.ParseBoolean(reader.GetAttribute("LeftEdgeStrokeOverprint"));
                result.RightEdgeStrokeOverprint = Parser.ParseBoolean(reader.GetAttribute("RightEdgeStrokeOverprint"));
                result.TopEdgeStrokeOverprint = Parser.ParseBoolean(reader.GetAttribute("TopEdgeStrokeOverprint"));
                result.BottomEdgeStrokeOverprint = Parser.ParseBoolean(reader.GetAttribute("BottomEdgeStrokeOverprint"));
                result.WritingDirection = Parser.ParseBoolean(reader.GetAttribute("WritingDirection"));
                result.LeftEdgeStrokePriority = Parser.ParseDouble(reader.GetAttribute("LeftEdgeStrokePriority"));
                result.RightEdgeStrokePriority = Parser.ParseDouble(reader.GetAttribute("RightEdgeStrokePriority"));
                result.TopEdgeStrokePriority = Parser.ParseDouble(reader.GetAttribute("TopEdgeStrokePriority"));
                result.BottomEdgeStrokePriority = Parser.ParseDouble(reader.GetAttribute("BottomEdgeStrokePriority"));
                result.LeftEdgeStrokeGapTint = System.Convert.ToInt32(reader.GetAttribute("LeftEdgeStrokeGapTint"));
                result.RightEdgeStrokeGapTint = System.Convert.ToInt32(reader.GetAttribute("RightEdgeStrokeGapTint"));
                result.TopEdgeStrokeGapTint = System.Convert.ToInt32(reader.GetAttribute("TopEdgeStrokeGapTint"));
                result.BottomEdgeStrokeGapTint = System.Convert.ToInt32(reader.GetAttribute("BottomEdgeStrokeGapTint"));
                result.LeftEdgeStrokeGapOverprint = Parser.ParseBoolean(reader.GetAttribute("LeftEdgeStrokeGapOverprint"));
                result.RightEdgeStrokeGapOverprint = Parser.ParseBoolean(reader.GetAttribute("RightEdgeStrokeGapOverprint"));
                result.TopEdgeStrokeGapOverprint = Parser.ParseBoolean(reader.GetAttribute("TopEdgeStrokeGapOverprint"));
                result.BottomEdgeStrokeGapOverprint = Parser.ParseBoolean(reader.GetAttribute("BottomEdgeStrokeGapOverprint"));
            }

            if (reader.IsEmptyElement)
                return result;

            while (reader.Read())
            {
                switch (reader.Name)
                {
                    case "ParagraphStyleRange":
                        result.Children.Add(ParagraphStyleRange.ReadXml(reader));
                        break;
                    case "Cell":
                        if (reader.NodeType == XmlNodeType.EndElement)
                            goto exit1;
                        break;
                    default:
                        Debug.WriteLine("Unrecognized element: {0} in element: {1}", reader.Name, "Note");
                        break;
                }
            }
            exit1:
            return result;
        }
    }
}
