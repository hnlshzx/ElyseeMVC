//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Elysee.Infrastruture.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class OT_Attachment
    {
        public string ObjectID { get; set; }
        public byte[] Content { get; set; }
        public string BizObjectId { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<int> LastVersion { get; set; }
        public string DataField { get; set; }
        public string ContentType { get; set; }
        public Nullable<int> ContentLength { get; set; }
        public string FileName { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public string Description { get; set; }
        public Nullable<long> FileFlag { get; set; }
        public string Keywords { get; set; }
        public string BizObjectSchemaCode { get; set; }
        public string StoragePath { get; set; }
        public string StorageFileName { get; set; }
        public string DownloadUrl { get; set; }
        public string ParentObjectID { get; set; }
        public string ParentPropertyName { get; set; }
        public Nullable<int> ParentIndex { get; set; }
    }
}
