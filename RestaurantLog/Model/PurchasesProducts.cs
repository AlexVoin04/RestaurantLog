//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestaurantLog.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class PurchasesProducts
    {
        public int ID { get; set; }
        public int PurchasesID { get; set; }
        public int ProductsID { get; set; }
    
        public virtual Products Products { get; set; }
        public virtual Purchases Purchases { get; set; }
    }
}