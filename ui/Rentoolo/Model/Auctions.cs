//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rentoolo.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Auctions
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal StartPrice { get; set; }
        public System.DateTime Created { get; set; }
        public System.Guid UserId { get; set; }
    }
}
