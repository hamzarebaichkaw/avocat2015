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

    public partial class Reglement_Justice : XPLiteObject
    {
        string fCode_Reglement;
        [Key]
        [Size(50)]
        public string Code_Reglement
        {
            get { return fCode_Reglement; }
            set { SetPropertyValue<string>("Code_Reglement", ref fCode_Reglement, value); }
        }
        Kadhiya_Justice fCode_Kadhiya;
        [Association(@"Reglement_JusticeReferencesKadhiya_Justice")]
        public Kadhiya_Justice Code_Kadhiya
        {
            get { return fCode_Kadhiya; }
            set { SetPropertyValue<Kadhiya_Justice>("Code_Kadhiya", ref fCode_Kadhiya, value); }
        }
        string fCod_Justice;
        [Size(50)]
        public string Cod_Justice
        {
            get { return fCod_Justice; }
            set { SetPropertyValue<string>("Cod_Justice", ref fCod_Justice, value); }
        }
        decimal fMontant_reg;
        public decimal Montant_reg
        {
            get { return fMontant_reg; }
            set { SetPropertyValue<decimal>("Montant_reg", ref fMontant_reg, value); }
        }
        string fMode_Payement;
        public string Mode_Payement
        {
            get { return fMode_Payement; }
            set { SetPropertyValue<string>("Mode_Payement", ref fMode_Payement, value); }
        }
        string fNum_piece;
        [Size(50)]
        public string Num_piece
        {
            get { return fNum_piece; }
            set { SetPropertyValue<string>("Num_piece", ref fNum_piece, value); }
        }
        string fBanque;
        public string Banque
        {
            get { return fBanque; }
            set { SetPropertyValue<string>("Banque", ref fBanque, value); }
        }
        DateTime fDate;
        public DateTime Date
        {
            get { return fDate; }
            set { SetPropertyValue<DateTime>("Date", ref fDate, value); }
        }
    }

}