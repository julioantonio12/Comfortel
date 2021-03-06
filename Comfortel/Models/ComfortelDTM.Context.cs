﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Comfortel.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ComfortelEntities : DbContext
    {
        public ComfortelEntities()
            : base("name=ComfortelEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Guests> Guests { get; set; }
        public virtual DbSet<Rates> Rates { get; set; }
        public virtual DbSet<Rooms> Rooms { get; set; }
        public virtual DbSet<Payments> Payments { get; set; }
        public virtual DbSet<Reservations> Reservations { get; set; }
    
        public virtual int spInsertUser(string nAME, string lASTNAME, string mOTHERLASTNAME, string uSERNAME, string pASSWORD)
        {
            var nAMEParameter = nAME != null ?
                new ObjectParameter("NAME", nAME) :
                new ObjectParameter("NAME", typeof(string));
    
            var lASTNAMEParameter = lASTNAME != null ?
                new ObjectParameter("LASTNAME", lASTNAME) :
                new ObjectParameter("LASTNAME", typeof(string));
    
            var mOTHERLASTNAMEParameter = mOTHERLASTNAME != null ?
                new ObjectParameter("MOTHERLASTNAME", mOTHERLASTNAME) :
                new ObjectParameter("MOTHERLASTNAME", typeof(string));
    
            var uSERNAMEParameter = uSERNAME != null ?
                new ObjectParameter("USERNAME", uSERNAME) :
                new ObjectParameter("USERNAME", typeof(string));
    
            var pASSWORDParameter = pASSWORD != null ?
                new ObjectParameter("PASSWORD", pASSWORD) :
                new ObjectParameter("PASSWORD", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsertUser", nAMEParameter, lASTNAMEParameter, mOTHERLASTNAMEParameter, uSERNAMEParameter, pASSWORDParameter);
        }
    
        public virtual ObjectResult<spGetUsers__Result> spGetUsers_()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetUsers__Result>("spGetUsers_");
        }
    
        public virtual int spDeleteUser(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spDeleteUser", iDParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> spLogIn(string uSER, string pASS)
        {
            var uSERParameter = uSER != null ?
                new ObjectParameter("USER", uSER) :
                new ObjectParameter("USER", typeof(string));
    
            var pASSParameter = pASS != null ?
                new ObjectParameter("PASS", pASS) :
                new ObjectParameter("PASS", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("spLogIn", uSERParameter, pASSParameter);
        }
    
        public virtual int spEditUser(Nullable<int> iD, string nAME, string lASTNAME, string mOTHERLASTNAME, string pASSWORD, string uSERNAME)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var nAMEParameter = nAME != null ?
                new ObjectParameter("NAME", nAME) :
                new ObjectParameter("NAME", typeof(string));
    
            var lASTNAMEParameter = lASTNAME != null ?
                new ObjectParameter("LASTNAME", lASTNAME) :
                new ObjectParameter("LASTNAME", typeof(string));
    
            var mOTHERLASTNAMEParameter = mOTHERLASTNAME != null ?
                new ObjectParameter("MOTHERLASTNAME", mOTHERLASTNAME) :
                new ObjectParameter("MOTHERLASTNAME", typeof(string));
    
            var pASSWORDParameter = pASSWORD != null ?
                new ObjectParameter("PASSWORD", pASSWORD) :
                new ObjectParameter("PASSWORD", typeof(string));
    
            var uSERNAMEParameter = uSERNAME != null ?
                new ObjectParameter("USERNAME", uSERNAME) :
                new ObjectParameter("USERNAME", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spEditUser", iDParameter, nAMEParameter, lASTNAMEParameter, mOTHERLASTNAMEParameter, pASSWORDParameter, uSERNAMEParameter);
        }
    
        public virtual ObjectResult<spGetGuests_Result> spGetGuests()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetGuests_Result>("spGetGuests");
        }
    
        public virtual int spInsertGuest(string nAME, string lASTNAME, string mOTHERLASTNAME, string eMAIL)
        {
            var nAMEParameter = nAME != null ?
                new ObjectParameter("NAME", nAME) :
                new ObjectParameter("NAME", typeof(string));
    
            var lASTNAMEParameter = lASTNAME != null ?
                new ObjectParameter("LASTNAME", lASTNAME) :
                new ObjectParameter("LASTNAME", typeof(string));
    
            var mOTHERLASTNAMEParameter = mOTHERLASTNAME != null ?
                new ObjectParameter("MOTHERLASTNAME", mOTHERLASTNAME) :
                new ObjectParameter("MOTHERLASTNAME", typeof(string));
    
            var eMAILParameter = eMAIL != null ?
                new ObjectParameter("EMAIL", eMAIL) :
                new ObjectParameter("EMAIL", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsertGuest", nAMEParameter, lASTNAMEParameter, mOTHERLASTNAMEParameter, eMAILParameter);
        }
    
        public virtual int spDeleteGuest(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spDeleteGuest", iDParameter);
        }
    
        public virtual int spEditGuest(Nullable<int> iD, string nAME, string lASTNAME, string mOTHERLASTNAME, string eMAIL)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var nAMEParameter = nAME != null ?
                new ObjectParameter("NAME", nAME) :
                new ObjectParameter("NAME", typeof(string));
    
            var lASTNAMEParameter = lASTNAME != null ?
                new ObjectParameter("LASTNAME", lASTNAME) :
                new ObjectParameter("LASTNAME", typeof(string));
    
            var mOTHERLASTNAMEParameter = mOTHERLASTNAME != null ?
                new ObjectParameter("MOTHERLASTNAME", mOTHERLASTNAME) :
                new ObjectParameter("MOTHERLASTNAME", typeof(string));
    
            var eMAILParameter = eMAIL != null ?
                new ObjectParameter("EMAIL", eMAIL) :
                new ObjectParameter("EMAIL", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spEditGuest", iDParameter, nAMEParameter, lASTNAMEParameter, mOTHERLASTNAMEParameter, eMAILParameter);
        }
    
        public virtual ObjectResult<spGetRates_Result> spGetRates()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetRates_Result>("spGetRates");
        }
    
        public virtual int spDeleteRate(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spDeleteRate", iDParameter);
        }
    
        public virtual int spEditRate(Nullable<int> iD, string nAME, Nullable<float> pRICE)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var nAMEParameter = nAME != null ?
                new ObjectParameter("NAME", nAME) :
                new ObjectParameter("NAME", typeof(string));
    
            var pRICEParameter = pRICE.HasValue ?
                new ObjectParameter("PRICE", pRICE) :
                new ObjectParameter("PRICE", typeof(float));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spEditRate", iDParameter, nAMEParameter, pRICEParameter);
        }
    
        public virtual int spInsertRate(string nAME, Nullable<float> pRICE)
        {
            var nAMEParameter = nAME != null ?
                new ObjectParameter("NAME", nAME) :
                new ObjectParameter("NAME", typeof(string));
    
            var pRICEParameter = pRICE.HasValue ?
                new ObjectParameter("PRICE", pRICE) :
                new ObjectParameter("PRICE", typeof(float));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsertRate", nAMEParameter, pRICEParameter);
        }
    
        public virtual int spDeleteRoom(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spDeleteRoom", iDParameter);
        }
    
        public virtual int spEditRoom(Nullable<int> iD, string dESCRIPTION, string tYPE, string cODE, Nullable<int> rATEID)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var dESCRIPTIONParameter = dESCRIPTION != null ?
                new ObjectParameter("DESCRIPTION", dESCRIPTION) :
                new ObjectParameter("DESCRIPTION", typeof(string));
    
            var tYPEParameter = tYPE != null ?
                new ObjectParameter("TYPE", tYPE) :
                new ObjectParameter("TYPE", typeof(string));
    
            var cODEParameter = cODE != null ?
                new ObjectParameter("CODE", cODE) :
                new ObjectParameter("CODE", typeof(string));
    
            var rATEIDParameter = rATEID.HasValue ?
                new ObjectParameter("RATEID", rATEID) :
                new ObjectParameter("RATEID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spEditRoom", iDParameter, dESCRIPTIONParameter, tYPEParameter, cODEParameter, rATEIDParameter);
        }
    
        public virtual ObjectResult<spGetRooms_Result> spGetRooms()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetRooms_Result>("spGetRooms");
        }
    
        public virtual int spInsertRoom(string dESCRIPTION, string tYPE, string cODE, Nullable<int> rATEID)
        {
            var dESCRIPTIONParameter = dESCRIPTION != null ?
                new ObjectParameter("DESCRIPTION", dESCRIPTION) :
                new ObjectParameter("DESCRIPTION", typeof(string));
    
            var tYPEParameter = tYPE != null ?
                new ObjectParameter("TYPE", tYPE) :
                new ObjectParameter("TYPE", typeof(string));
    
            var cODEParameter = cODE != null ?
                new ObjectParameter("CODE", cODE) :
                new ObjectParameter("CODE", typeof(string));
    
            var rATEIDParameter = rATEID.HasValue ?
                new ObjectParameter("RATEID", rATEID) :
                new ObjectParameter("RATEID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsertRoom", dESCRIPTIONParameter, tYPEParameter, cODEParameter, rATEIDParameter);
        }
    
        public virtual int spEditPayment(Nullable<int> iD, Nullable<System.DateTime> dATE, Nullable<int> tYPE, Nullable<float> aMOUNT, Nullable<int> iDRESERVATION)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var dATEParameter = dATE.HasValue ?
                new ObjectParameter("DATE", dATE) :
                new ObjectParameter("DATE", typeof(System.DateTime));
    
            var tYPEParameter = tYPE.HasValue ?
                new ObjectParameter("TYPE", tYPE) :
                new ObjectParameter("TYPE", typeof(int));
    
            var aMOUNTParameter = aMOUNT.HasValue ?
                new ObjectParameter("AMOUNT", aMOUNT) :
                new ObjectParameter("AMOUNT", typeof(float));
    
            var iDRESERVATIONParameter = iDRESERVATION.HasValue ?
                new ObjectParameter("IDRESERVATION", iDRESERVATION) :
                new ObjectParameter("IDRESERVATION", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spEditPayment", iDParameter, dATEParameter, tYPEParameter, aMOUNTParameter, iDRESERVATIONParameter);
        }
    
        public virtual ObjectResult<spGetPayments_Result> spGetPayments()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetPayments_Result>("spGetPayments");
        }
    
        public virtual int spInsertPayment(Nullable<System.DateTime> dATE, Nullable<int> tYPE, Nullable<float> aMOUNT, Nullable<int> iDRESERVATION)
        {
            var dATEParameter = dATE.HasValue ?
                new ObjectParameter("DATE", dATE) :
                new ObjectParameter("DATE", typeof(System.DateTime));
    
            var tYPEParameter = tYPE.HasValue ?
                new ObjectParameter("TYPE", tYPE) :
                new ObjectParameter("TYPE", typeof(int));
    
            var aMOUNTParameter = aMOUNT.HasValue ?
                new ObjectParameter("AMOUNT", aMOUNT) :
                new ObjectParameter("AMOUNT", typeof(float));
    
            var iDRESERVATIONParameter = iDRESERVATION.HasValue ?
                new ObjectParameter("IDRESERVATION", iDRESERVATION) :
                new ObjectParameter("IDRESERVATION", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsertPayment", dATEParameter, tYPEParameter, aMOUNTParameter, iDRESERVATIONParameter);
        }
    
        public virtual int spDeletePayment(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spDeletePayment", iDParameter);
        }
    
        public virtual ObjectResult<spGetReservations_Result> spGetReservations()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetReservations_Result>("spGetReservations");
        }
    
        public virtual ObjectResult<Nullable<float>> spGetPrice(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<float>>("spGetPrice", iDParameter);
        }
    }
}
