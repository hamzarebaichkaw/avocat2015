//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace avocat2015.DATA.baavocat
{

    public partial class Resources : XPLiteObject
    {
        int fUniqueID;
        [Key(true)]
        public int UniqueID
        {
            get { return fUniqueID; }
            set { SetPropertyValue<int>("UniqueID", ref fUniqueID, value); }
        }
        int fResourceID;
        public int ResourceID
        {
            get { return fResourceID; }
            set { SetPropertyValue<int>("ResourceID", ref fResourceID, value); }
        }
        string fResourceName;
        [Size(50)]
        public string ResourceName
        {
            get { return fResourceName; }
            set { SetPropertyValue<string>("ResourceName", ref fResourceName, value); }
        }
        int fColor;
        public int Color
        {
            get { return fColor; }
            set { SetPropertyValue<int>("Color", ref fColor, value); }
        }
        byte[] fImage;
        [Size(SizeAttribute.Unlimited)]
        public byte[] Image
        {
            get { return fImage; }
            set { SetPropertyValue<byte[]>("Image", ref fImage, value); }
        }
        string fCustomField1;
        [Size(SizeAttribute.Unlimited)]
        public string CustomField1
        {
            get { return fCustomField1; }
            set { SetPropertyValue<string>("CustomField1", ref fCustomField1, value); }
        }
    }

}
