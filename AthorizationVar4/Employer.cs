//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AthorizationVar4
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employer
    {
        public int tabNum { get; set; }
        public string name { get; set; }
        public System.DateTime dateStartWork { get; set; }
        public int position { get; set; }
        public decimal salary { get; set; }
        public string password { get; set; }
        public Nullable<int> State { get; set; }

    
        public virtual Employer Employer1 { get; set; }
        public virtual Employer Employer2 { get; set; }
        public virtual Position Position1 { get; set; }
        public virtual State State1 { get; set; }
    }
}
