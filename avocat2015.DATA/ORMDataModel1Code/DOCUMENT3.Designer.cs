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

    public partial class DOCUMENT3 : XPLiteObject
    {
        decimal fCOD_DOC;
        [Key]
        public decimal COD_DOC
        {
            get { return fCOD_DOC; }
            set { SetPropertyValue<decimal>("COD_DOC", ref fCOD_DOC, value); }
        }
        byte[] fFICHIER3;
        [Size(SizeAttribute.Unlimited)]
        public byte[] FICHIER3
        {
            get { return fFICHIER3; }
            set { SetPropertyValue<byte[]>("FICHIER3", ref fFICHIER3, value); }
        }
        string fNOM_FICHIER3;
        [Size(SizeAttribute.Unlimited)]
        public string NOM_FICHIER3
        {
            get { return fNOM_FICHIER3; }
            set { SetPropertyValue<string>("NOM_FICHIER3", ref fNOM_FICHIER3, value); }
        }
        decimal fCOD_OP;
        public decimal COD_OP
        {
            get { return fCOD_OP; }
            set { SetPropertyValue<decimal>("COD_OP", ref fCOD_OP, value); }
        }
    }

}