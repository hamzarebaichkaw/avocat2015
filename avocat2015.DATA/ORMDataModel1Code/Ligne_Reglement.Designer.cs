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

    public partial class Ligne_Reglement : XPLiteObject
    {
        int fid_ligne;
        [Key(true)]
        public int id_ligne
        {
            get { return fid_ligne; }
            set { SetPropertyValue<int>("id_ligne", ref fid_ligne, value); }
        }
        int fCode_Reglement;
        public int Code_Reglement
        {
            get { return fCode_Reglement; }
            set { SetPropertyValue<int>("Code_Reglement", ref fCode_Reglement, value); }
        }
        string fCode_Piece;
        [Size(50)]
        public string Code_Piece
        {
            get { return fCode_Piece; }
            set { SetPropertyValue<string>("Code_Piece", ref fCode_Piece, value); }
        }
        string fType_Piece;
        [Size(50)]
        public string Type_Piece
        {
            get { return fType_Piece; }
            set { SetPropertyValue<string>("Type_Piece", ref fType_Piece, value); }
        }
        decimal fmontant;
        public decimal montant
        {
            get { return fmontant; }
            set { SetPropertyValue<decimal>("montant", ref fmontant, value); }
        }
        decimal fmontant_payer;
        public decimal montant_payer
        {
            get { return fmontant_payer; }
            set { SetPropertyValue<decimal>("montant_payer", ref fmontant_payer, value); }
        }
    }

}
