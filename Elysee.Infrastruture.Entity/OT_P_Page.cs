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
    
    public partial class OT_P_Page
    {
        public string ObjectID { get; set; }
        public string Title { get; set; }
        public string PageType { get; set; }
        public string CompanyId { get; set; }
        public string OrgId { get; set; }
        public string TemplateId { get; set; }
        public byte[] PageContent { get; set; }
        public string CreateUser { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string UpdateUser { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<int> IsLock { get; set; }
        public string ParentObjectID { get; set; }
        public string ParentPropertyName { get; set; }
        public Nullable<int> ParentIndex { get; set; }
    }
}
