using System;
using System.Xml;

/// <summary>
/// Returns values of XML attributes
/// </summary>
public class AttributeFactory
{
    // Retrieves the value of a specific attribute
    protected static T GetAttributes<T>(string value, XmlAttributeCollection attributeCollection)
    {
        string attribute = attributeCollection[value].Value;
        return (T)Convert.ChangeType(attribute, typeof(T));
    }
}