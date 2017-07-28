using System.Diagnostics;
using System.Xml;


namespace Spreads
{
    public class GridDataInformation
    {
        public string FontStyle { get; set; }

        public double? PointSize { get; set; }

        public double? CharacterAki { get; set; }

        public double? LineAki { get; set; }

        public double? HorizontalScale { get; set; }

        public double? VerticalScale { get; set; }

        public LineAlignment? LineAlignment { get; set; }

        public GridAlignment? GridAlignment { get; set; }

        public CharacterAlignment? CharacterAlignment { get; set; }

        public GridViewSettings? GridView { get; set; }

        public CharacterCountLocation? CharacterCountLocation { get; set; }

        public double? CharacterCountSize { get; set; }

        private AppliedFont AppliedFont { get; set; }

        public static GridDataInformation ReadXml(XmlReader reader)
        {
            GridDataInformation gdi = new GridDataInformation();

            if (reader.HasAttributes)
            {
                gdi.FontStyle = System.Convert.ToString(reader.GetAttribute("FontStyle"));
                gdi.PointSize = Parser.ParseDouble(reader.GetAttribute("PointSize"));
                gdi.CharacterAki = Parser.ParseDouble(reader.GetAttribute("CharacterAki"));
                gdi.LineAki = Parser.ParseDouble(reader.GetAttribute("LineAki"));
                gdi.HorizontalScale = Parser.ParseDouble(reader.GetAttribute("HorizontalScale"));
                gdi.VerticalScale = Parser.ParseDouble(reader.GetAttribute("VerticalScale"));
                gdi.LineAlignment = (LineAlignment?)Parser.ParseEnum<LineAlignment>(reader.GetAttribute("LineAlignment"));
                gdi.GridAlignment = (GridAlignment?)Parser.ParseEnum<GridAlignment>(reader.GetAttribute("GridAlignment"));
                gdi.CharacterAlignment = (CharacterAlignment?)Parser.ParseEnum<CharacterAlignment>(reader.GetAttribute("CharacterAlignment"));
                gdi.GridView = (GridViewSettings?)Parser.ParseEnum<GridViewSettings>(reader.GetAttribute("GridView"));
                gdi.CharacterCountLocation = (CharacterCountLocation?)Parser.ParseEnum<CharacterCountLocation>(reader.GetAttribute("CharacterCountLocation"));
                gdi.CharacterCountSize = Parser.ParseDouble(reader.GetAttribute("CharacterCountSize"));
            }

            if (reader.IsEmptyElement)
                return gdi;

            while (reader.Read())
            {
                if ((string)reader.Name == "Properties")
                {
                    while (reader.Read())
                    {
                        if ((string)reader.Name == "AppliedFont")
                        {
                            gdi.AppliedFont = AppliedFont.ReadXml(reader);
                        }
                        else
                        {
                            if (reader.NodeType == XmlNodeType.Element)
                            {
                                Debug.WriteLine("Unrecognized element: {0} in element: {1}", reader.Name, "GridDataInformation - Properties");
                            }
                        }
                        if (reader.Name == "Properties" && reader.NodeType == XmlNodeType.EndElement)
                        {
                            break;
                        }
                    }
                }
                else if ((string)reader.Name == "GridDataInformation")
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
                        Debug.WriteLine("Unrecognized element: {0} in element: {1}", reader.Name, "GridDataInformation");
                    }
                }
            }

            return gdi;
        }
    }
}