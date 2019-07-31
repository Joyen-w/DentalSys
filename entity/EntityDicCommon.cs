using System;
using System.Text;
using System.Data;
using System.Runtime.Serialization;

namespace DentalSys
{
    /// <summary>
    /// EntityDicCommon
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "dicCommon")]
    public class EntityDicCommon : BaseDataContract
    {
        /// <summary>
        /// fclassid
        /// 001  患者来源
        /// 002  患者分类
        /// 003  会员登记
        /// 004  联系地址
        /// 005  过敏史
        /// 006  既往史
        /// 007  患者印象
        /// 008  民族
        /// 009  洁牙习惯
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fclassid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 1)]
        public System.String fclassid { get; set; }

        /// <summary>
        /// fno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fno", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String fno { get; set; }

        /// <summary>
        /// fname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String fname { get; set; }

        /// <summary>
        /// fsortno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fsortno", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Decimal fsortno { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string fclassid = "fclassid";
            public string fno = "fno";
            public string fname = "fname";
            public string fsortno = "fsortno";
        }
    }
}
