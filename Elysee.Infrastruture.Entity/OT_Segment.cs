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
    
    public partial class OT_Segment
    {
        public string ObjectID { get; set; }
        public string ParentID { get; set; }
        public string SourceParentID { get; set; }
        public string CompanyID { get; set; }
        public Nullable<int> Admin { get; set; }
        public string SystemID { get; set; }
        public Nullable<int> Visibility { get; set; }
        public string CategoryID { get; set; }
        public Nullable<int> State { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public string ManagerID { get; set; }
        public string ViceManagerID { get; set; }
        public string SecretaryID { get; set; }
        public string SupervisorID { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public byte[] Attachment { get; set; }
        public Nullable<int> SortKey { get; set; }
        public string WorkflowCode { get; set; }
        public string ParentObjectID { get; set; }
        public string ParentPropertyName { get; set; }
        public Nullable<int> ParentIndex { get; set; }
    }
}
