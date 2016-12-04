using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace avocat2015.DATA.baavocat
{

    public partial class Reglement_Avocat
    {
        public Reglement_Avocat(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
