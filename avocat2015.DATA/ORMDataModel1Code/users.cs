using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace avocat2015.DATA.baavocat
{

    public partial class users
    {
        public users() : base(Session.DefaultSession) { }
        public users(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

    }
  
}
