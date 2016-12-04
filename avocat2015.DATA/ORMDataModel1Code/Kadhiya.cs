using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Linq;
namespace avocat2015.DATA.baavocat
{

    public partial class Kadhiya
    {
        public Kadhiya(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        public decimal totalPaye
        {
            get
            {
                return (from Reglement_Client rc in this.Reglement_Clients select rc.Montant_reg).Sum();
            }
        }
    }

}
