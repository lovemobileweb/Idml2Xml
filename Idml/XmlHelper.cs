using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Idml
{
    public static class XmlHelper
    {
        public static bool AddAttribute(XmlNode node, string name, string value)
        {
            XmlAttribute attr = node.OwnerDocument.CreateAttribute(name);
            attr.Value = value;
            node.Attributes.Append(attr);
            return true;
        }

        public static bool SetAttribute<T>(XmlNode node, string name, T value)
        {
            return SetAttribute(node, name, value.ToString(), false);
        }

        public static bool SetAttribute(XmlNode node, string name, string value)
        {
            return SetAttribute(node, name, value, false);
        }

        public static bool SetAttribute(XmlNode node, string name, string value, bool removeEmpty)
        {
            XmlAttribute attr = node.Attributes[name];

            if (attr == null)
            {
                if (removeEmpty && string.IsNullOrEmpty(value))
                    return false;

                return AddAttribute(node, name, value);
            }

            if (removeEmpty && string.IsNullOrEmpty(value))
            {
                node.Attributes.Remove(attr);
            }
            else
            {
                if (attr.Value == value)
                    return false;

                attr.Value = value;
            }

            return true;
        }

        public static bool RemoveAttribute(XmlNode node, string name)
        {
            XmlAttribute attr = node.Attributes[name];

            if (attr == null)
                return false;

            node.Attributes.Remove(attr);
            return true;
        }

        public static XmlNode AddLanguages(XmlNode node, int left, int top, int width, int height, string text)
        {
            bool changed;
            return AddLanguages(node, left, top, width, height, text, out changed);
        }

        public static XmlNode AddLanguages(XmlNode node, int left, int top, int width, int height, string text, out bool changed)
        {
            changed = false;

            XmlNode languages = node["languages"] ?? node.OwnerDocument.CreateElement("languages");

            XmlNode language = languages["language"] ?? node.OwnerDocument.CreateElement("language");

            /*if (top == 0 && left == 0 && width == 0 && height == 0)
            {
                RemoveAttribute(language, "top");
                RemoveAttribute(language, "height");
                RemoveAttribute(language, "left");
                RemoveAttribute(language, "width");
            }
            else*/
            {
                if (top != -1)
                {
                    if (SetAttribute(language, "top", top.ToString()))
                        changed = true;
                }

                if (left != -1)
                {
                    if (SetAttribute(language, "left", left.ToString()))
                        changed = true;
                }

                if (width != -1)
                {
                    if (SetAttribute(language, "width", width.ToString()))
                        changed = true;
                }

                if (height != -1)
                {
                    if (SetAttribute(language, "height", height.ToString()))
                        changed = true;
                }
            }

            if (SetAttribute(language, "text", text, true))
                changed = true;

            if (languages["language"] == null)
            {
                languages.AppendChild(language);
                changed = true;
            }

            if (node["languages"] != null)
                return language;

            node.AppendChild(languages);
            changed = true;

            return language;
        }

        public static XmlNode AddCollectionElement(XmlNode node, string collection, string element, string attributeName,
            string value)
        {
            bool changed;
            return AddCollectionElement(node, collection, element, attributeName, value, out changed);
        }

        public static XmlNode AddCollectionElement(XmlNode node, string collection, string element, string attributeName, string value, out bool changed)
        {
            changed = false;

            XmlNode targetControls = node[collection];

            if (targetControls == null)
            {
                targetControls = node.OwnerDocument.CreateElement(collection);
                node.AppendChild(targetControls);
                changed = true;
            }

            XmlNode targetControl = node.OwnerDocument.CreateElement(element);

            if (attributeName != null)
            {

                XmlAttribute attribute = node.OwnerDocument.CreateAttribute(attributeName);

                attribute.Value = value;

                targetControl.Attributes.Append(attribute);

                changed = true;
            }
            else
            {
                if (targetControl.InnerText != value)
                {
                    targetControl.InnerText = value;
                    changed = true;
                }
            }


            targetControls.AppendChild(targetControl);

            return targetControl;
        }

        public static XmlNode AddCollection(XmlNode node, string collection)
        {
            bool changed;
            return AddCollection(node, collection, out changed);
        }

        public static XmlNode AddCollection(XmlNode node, string collection, out bool changed)
        {
            changed = false;

            XmlNode targetControls = node[collection];

            if (targetControls == null)
            {
                targetControls = node.OwnerDocument.CreateElement(collection);
                node.AppendChild(targetControls);
                changed = true;
            }

            return targetControls;
        }

        public static string GetAttribute(XmlNode element, string name)
        {
            return element.Attributes[name].Value;
        }

        public static string GetAttribute(XmlNode element, string name, string defValue)
        {
            XmlAttribute attribute = element.Attributes[name];
            if (attribute == null)
                return defValue;

            return attribute.Value;
        }

        public static Guid GetAttribute(XmlNode element, string name, Guid defValue)
        {
            XmlAttribute attribute = element.Attributes[name];
            if (attribute == null)
                return defValue;

            string strValue = attribute.Value.Trim('{', '}');
            try
            {
                return new Guid(strValue);
            }
            catch
            {
                return defValue;
            }
        }

        public static int GetAttribute(XmlNode element, string name, int defValue)
        {
            XmlAttribute attribute = element.Attributes[name];
            if (attribute == null)
                return defValue;

            try
            {
                return int.Parse(attribute.Value);
            }
            catch
            {
                return defValue;
            }
        }

        public static float GetAttribute(XmlNode element, string name, float defValue)
        {
            XmlAttribute attribute = element.Attributes[name];
            if (attribute == null)
                return defValue;

            try
            {
                return float.Parse(attribute.Value);
            }
            catch
            {
                return defValue;
            }
        }

        public static bool GetAttribute(XmlNode element, string name, bool defValue)
        {
            XmlAttribute attribute = element.Attributes[name];
            if (attribute == null)
                return defValue;

            try
            {
                return bool.Parse(attribute.Value);
            }
            catch
            {
                return defValue;
            }
        }

        public static T ConvertTo<T>(object text, T def)
        {
            if (text == null)
                return def;

            if (text is DBNull)
                return def;

            if (text.GetType() == typeof(T))
                return (T)text;

            if (text is string)
            {
                if (((string)text).Trim().Length == 0)
                    return def;
                text = ((string)text).Trim();
            }

            if (typeof(T).IsEnum)
            {
                try
                {
                    return (T)Enum.Parse(typeof(T), text.ToString());
                }
                catch (Exception)
                {
                    return def;
                }
            }

            if (text is string && ((string)text).StartsWith("0x") && typeof(T).IsPrimitive)
                text = int.Parse(((string)text).Substring(2), NumberStyles.HexNumber);

            try
            {
                return (T)Convert.ChangeType(text, typeof(T));
            }
            catch
            {
                return def;
            }
        }

        public static T GetAttribute<T>(XmlNode node, string name, T def)
        {
            XmlAttribute attr = node.Attributes[name];

            if (attr == null)
                return def;

            if (typeof(T).IsEnum)
            {
                try
                {
                    return ConvertTo(attr.Value, def);
                }
                catch (ArgumentException)
                {
                    throw;
                }
            }
            else
            {
                try
                {
                    return ConvertTo(attr.Value, def);
                }
                catch (FormatException)
                {
                    throw new Exception("Invalid value for attribute " + name);
                }
                catch (OverflowException)
                {
                    throw new Exception("Invalid value for attribute " + name);
                }
            }
        }

        public static string DocumentToString(XmlDocument document)
        {
            MemoryStream stream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(stream, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;
            document.Save(writer);
            return Encoding.UTF8.GetString(stream.GetBuffer(), 0, (int)stream.Length);
        }
    }
}
