using System;
using System.Text;
using System.Data;
using System.Runtime.Serialization;

namespace DentalSys
{
    /// <summary>
    /// EntityDsPatient
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "dsPatient")]
    public class EntityDsPatient : BaseDataContract
    {
        /// <summary>
        /// fcaseno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fcaseno", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String fcaseno { get; set; }

        /// <summary>
        /// fpatname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fpatname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String fpatname { get; set; }

        /// <summary>
        /// fsex
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fsex", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String fsex { get; set; }

        /// <summary>
        /// ftelno1
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ftelno1", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String ftelno1 { get; set; }

        /// <summary>
        /// ftelno1ower
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ftelno1ower", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String ftelno1ower { get; set; }

        /// <summary>
        /// ftelno2
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ftelno2", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String ftelno2 { get; set; }

        /// <summary>
        /// ftelno2ower
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ftelno2ower", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String ftelno2ower { get; set; }

        /// <summary>
        /// fbirthday
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fbirthday", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.DateTime? fbirthday { get; set; }

        /// <summary>
        /// fnation
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fnation", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String fnation { get; set; }

        /// <summary>
        /// fsource
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fsource", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String fsource { get; set; }

        /// <summary>
        /// fclass
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fclass", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String fclass { get; set; }

        /// <summary>
        /// fimpression
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fimpression", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.String fimpression { get; set; }

        /// <summary>
        /// fmemberno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fmemberno", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.String fmemberno { get; set; }

        /// <summary>
        /// fmembergrade
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fmembergrade", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.String fmembergrade { get; set; }

        /// <summary>
        /// fcontactaddr
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fcontactaddr", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.String fcontactaddr { get; set; }

        /// <summary>
        /// fallergy
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fallergy", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.String fallergy { get; set; }

        /// <summary>
        /// fillhistory
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fillhistory", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.String fillhistory { get; set; }

        /// <summary>
        /// fsocialno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fsocialno", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.String fsocialno { get; set; }

        /// <summary>
        /// femail
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "femail", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 19)]
        public System.String femail { get; set; }

        /// <summary>
        /// fconsult
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fconsult", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 20)]
        public System.String fconsult { get; set; }

        /// <summary>
        /// fsmoketimesofday
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fsmoketimesofday", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 21)]
        public System.Decimal? fsmoketimesofday { get; set; }

        /// <summary>
        /// fbrushtimesofday
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fbrushtimesofday", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 22)]
        public System.Decimal? fbrushtimesofday { get; set; }

        /// <summary>
        /// fbrushminuteoftime
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fbrushminuteoftime", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 23)]
        public System.Decimal? fbrushminuteoftime { get; set; }

        /// <summary>
        /// fbrushhabit
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fbrushhabit", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 24)]
        public System.String fbrushhabit { get; set; }

        /// <summary>
        /// fclinictime
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fclinictime", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 25)]
        public System.DateTime? fclinictime { get; set; }

        /// <summary>
        /// fclinictype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fclinictype", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 26)]
        public System.String fclinictype { get; set; }

        /// <summary>
        /// fdoctid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fdoctid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 27)]
        public System.String fdoctid { get; set; }

        /// <summary>
        /// fcomment
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fcomment", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 28)]
        public System.String fcomment { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string fcaseno = "fcaseno";
            public string fpatname = "fpatname";
            public string fsex = "fsex";
            public string ftelno1 = "ftelno1";
            public string ftelno1ower = "ftelno1ower";
            public string ftelno2 = "ftelno2";
            public string ftelno2ower = "ftelno2ower";
            public string fbirthday = "fbirthday";
            public string fnation = "fnation";
            public string fsource = "fsource";
            public string fclass = "fclass";
            public string fimpression = "fimpression";
            public string fmemberno = "fmemberno";
            public string fmembergrade = "fmembergrade";
            public string fcontactaddr = "fcontactaddr";
            public string fallergy = "fallergy";
            public string fillhistory = "fillhistory";
            public string fsocialno = "fsocialno";
            public string femail = "femail";
            public string fconsult = "fconsult";
            public string fsmoketimesofday = "fsmoketimesofday";
            public string fbrushtimesofday = "fbrushtimesofday";
            public string fbrushminuteoftime = "fbrushminuteoftime";
            public string fbrushhabit = "fbrushhabit";
            public string fclinictime = "fclinictime";
            public string fclinictype = "fclinictype";
            public string fdoctid = "fdoctid";
            public string fcomment = "fcomment";
        }
    }
}
