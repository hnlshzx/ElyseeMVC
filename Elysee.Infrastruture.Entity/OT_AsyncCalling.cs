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
    
    public partial class OT_AsyncCalling
    {
        public string ObjectID { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public string UserId { get; set; }
        public string UserLoginName { get; set; }
        public string BizServiceCode { get; set; }
        public string MethodName { get; set; }
        public Nullable<int> CallType { get; set; }
        public string Params { get; set; }
        public byte[] RetMessage { get; set; }
        public string ParentObjectID { get; set; }
        public string ParentPropertyName { get; set; }
        public Nullable<int> ParentIndex { get; set; }
    }
}
