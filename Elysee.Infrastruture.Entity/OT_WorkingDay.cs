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
    
    public partial class OT_WorkingDay
    {
        public string ObjectID { get; set; }
        public string CalendarId { get; set; }
        public Nullable<System.DateTime> CurrentDate { get; set; }
        public Nullable<int> IsWorkingDay { get; set; }
        public Nullable<int> IsExceptional { get; set; }
        public string Description { get; set; }
        public string ParentObjectID { get; set; }
        public string ParentPropertyName { get; set; }
        public Nullable<int> ParentIndex { get; set; }
    }
}
