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

    public partial class kadhiya_Adel : XPLiteObject
    {
        string fCode_ka_Justice;
        [Key]
        [Size(50)]
        public string Code_ka_Justice
        {
            get { return fCode_ka_Justice; }
            set { SetPropertyValue<string>("Code_ka_Justice", ref fCode_ka_Justice, value); }
        }
        string fCode_ka;
        [Size(50)]
        public string Code_ka
        {
            get { return fCode_ka; }
            set { SetPropertyValue<string>("Code_ka", ref fCode_ka, value); }
        }
        string fCod_Justice;
        [Size(50)]
        public string Cod_Justice
        {
            get { return fCod_Justice; }
            set { SetPropertyValue<string>("Cod_Justice", ref fCod_Justice, value); }
        }
        string fDescription;
        [Size(SizeAttribute.Unlimited)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
    }

}
