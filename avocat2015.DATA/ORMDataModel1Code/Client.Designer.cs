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

    public partial class Client : XPLiteObject
    {
        string fCode_Client;
        [Key]
        [Size(50)]
        public string Code_Client
        {
            get { return fCode_Client; }
            set { SetPropertyValue<string>("Code_Client", ref fCode_Client, value); }
        }
        string fType;
        [Size(50)]
        public string Type
        {
            get { return fType; }
            set { SetPropertyValue<string>("Type", ref fType, value); }
        }
        string fFormeJ;
        [Size(50)]
        public string FormeJ
        {
            get { return fFormeJ; }
            set { SetPropertyValue<string>("FormeJ", ref fFormeJ, value); }
        }
        string fNom;
        [Size(150)]
        public string Nom
        {
            get { return fNom; }
            set { SetPropertyValue<string>("Nom", ref fNom, value); }
        }
        string fAdresse;
        [Size(SizeAttribute.Unlimited)]
        public string Adresse
        {
            get { return fAdresse; }
            set { SetPropertyValue<string>("Adresse", ref fAdresse, value); }
        }
        string fTel;
        [Size(50)]
        public string Tel
        {
            get { return fTel; }
            set { SetPropertyValue<string>("Tel", ref fTel, value); }
        }
        string fGsm;
        [Size(50)]
        public string Gsm
        {
            get { return fGsm; }
            set { SetPropertyValue<string>("Gsm", ref fGsm, value); }
        }
        string fFax;
        [Size(50)]
        public string Fax
        {
            get { return fFax; }
            set { SetPropertyValue<string>("Fax", ref fFax, value); }
        }
        string fActivite;
        [Size(200)]
        public string Activite
        {
            get { return fActivite; }
            set { SetPropertyValue<string>("Activite", ref fActivite, value); }
        }
        string fCin;
        [Size(50)]
        public string Cin
        {
            get { return fCin; }
            set { SetPropertyValue<string>("Cin", ref fCin, value); }
        }
        DateTime fDate_cin;
        public DateTime Date_cin
        {
            get { return fDate_cin; }
            set { SetPropertyValue<DateTime>("Date_cin", ref fDate_cin, value); }
        }
        string fLieu_cin;
        public string Lieu_cin
        {
            get { return fLieu_cin; }
            set { SetPropertyValue<string>("Lieu_cin", ref fLieu_cin, value); }
        }
        string fVille;
        public string Ville
        {
            get { return fVille; }
            set { SetPropertyValue<string>("Ville", ref fVille, value); }
        }
        string fEmail;
        public string Email
        {
            get { return fEmail; }
            set { SetPropertyValue<string>("Email", ref fEmail, value); }
        }
        string fMF;
        [Size(50)]
        public string MF
        {
            get { return fMF; }
            set { SetPropertyValue<string>("MF", ref fMF, value); }
        }
        string fRC;
        [Size(50)]
        public string RC
        {
            get { return fRC; }
            set { SetPropertyValue<string>("RC", ref fRC, value); }
        }
        string fCP;
        [Size(50)]
        public string CP
        {
            get { return fCP; }
            set { SetPropertyValue<string>("CP", ref fCP, value); }
        }
        string fDescription;
        [Size(SizeAttribute.Unlimited)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        [Association(@"ContratReferencesClient", typeof(Contrat))]
        public XPCollection<Contrat> Contrats { get { return GetCollection<Contrat>("Contrats"); } }
    }

}