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

    public partial class Reglement_Client : XPLiteObject
    {
        int fCode_Reglement;
        [Key(true)]
        public int Code_Reglement
        {
            get { return fCode_Reglement; }
            set { SetPropertyValue<int>("Code_Reglement", ref fCode_Reglement, value); }
        }
        Kadhiya fCode_Kadhiya;
        [Size(50)]
        [Association(@"Reglement_ClientReferencesKadhiya")]
        public Kadhiya Code_Kadhiya
        {
            get { return fCode_Kadhiya; }
            set { SetPropertyValue<Kadhiya>("Code_Kadhiya", ref fCode_Kadhiya, value); }
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
        DateTime fDate_payement;
        public DateTime Date_payement
        {
            get { return fDate_payement; }
            set { SetPropertyValue<DateTime>("Date_payement", ref fDate_payement, value); }
        }
        DateTime fDate_piece;
        public DateTime Date_piece
        {
            get { return fDate_piece; }
            set { SetPropertyValue<DateTime>("Date_piece", ref fDate_piece, value); }
        }
        string fCode_client;
        [Size(50)]
        public string Code_client
        {
            get { return fCode_client; }
            set { SetPropertyValue<string>("Code_client", ref fCode_client, value); }
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
