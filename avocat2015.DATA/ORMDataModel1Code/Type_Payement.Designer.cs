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

    public partial class Type_Payement : XPLiteObject
    {
        string fType_Payement1;
        [Key]
        [Size(50)]
        [Persistent(@"Type_Payement")]
        public string Type_Payement1
        {
            get { return fType_Payement1; }
            set { SetPropertyValue<string>("Type_Payement1", ref fType_Payement1, value); }
        }
    }

}
