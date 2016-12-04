using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace avocat2015.DATA.baavocat
{

    public partial class Ligne_Reglement
    {
        public Ligne_Reglement(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
