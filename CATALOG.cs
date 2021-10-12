
// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
using System.Collections.Generic;
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class CATALOG
{

    private List<CATALOGCD> cdField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CD")]
    public List<CATALOGCD> CD
    {
        get
        {
            return this.cdField;
        }
        set
        {
            this.cdField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class CATALOGCD
{

    private string title;

    private string artist;

    private string country;

    private string company;

    private decimal price;

    private ushort year;

    /// <remarks/>
    public string TITLE
    {
        get
        {
            return this.title;
        }
        set
        {
            this.title = value;
        }
    }

    /// <remarks/>
    public string ARTIST
    {
        get
        {
            return this.artist;
        }
        set
        {
            this.artist = value;
        }
    }

    /// <remarks/>
    public string COUNTRY
    {
        get
        {
            return this.country;
        }
        set
        {
            this.country = value;
        }
    }

    /// <remarks/>
    public string COMPANY
    {
        get
        {
            return this.company;
        }
        set
        {
            this.company = value;
        }
    }

    /// <remarks/>
    public decimal PRICE
    {
        get
        {
            return this.price;
        }
        set
        {
            this.price = value;
        }
    }

    /// <remarks/>
    public ushort YEAR
    {
        get
        {
            return this.year;
        }
        set
        {
            this.year = value;
        }
    }
}
