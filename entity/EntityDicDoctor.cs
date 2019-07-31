using System;
using System.Text;
using System.Data;
using System.Runtime.Serialization;

namespace DentalSys
{
    /// <summary>
    /// EntityDicDoctor
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "dicDoctor")]
    public class EntityDicDoctor : BaseDataContract
    {
        /// <summary>
        /// fdoctcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fdoctcode", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String fdoctcode { get; set; }

        /// <summary>
        /// fdoctname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fdoctname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String fdoctname { get; set; }

        /// <summary>
        /// fbirthday
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fbirthday", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.DateTime fbirthday { get; set; }

        /// <summary>
        /// fsex
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fsex", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String fsex { get; set; }

        /// <summary>
        /// frank
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "frank", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String frank { get; set; }

        /// <summary>
        /// fspeciality
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fspeciality", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String fspeciality { get; set; }

        /// <summary>
        /// fhiredate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fhiredate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.DateTime? fhiredate { get; set; }

        /// <summary>
        /// fdeparturedate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fdeparturedate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.DateTime? fdeparturedate { get; set; }

        /// <summary>
        /// fstatus
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fstatus", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Decimal fstatus { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string fdoctcode = "fdoctcode";
            public string fdoctname = "fdoctname";
            public string fbirthday = "fbirthday";
            public string fsex = "fsex";
            public string frank = "frank";
            public string fspeciality = "fspeciality";
            public string fhiredate = "fhiredate";
            public string fdeparturedate = "fdeparturedate";
            public string fstatus = "fstatus";
        }
    }
}

