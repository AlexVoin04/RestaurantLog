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
    
    public partial class Dishes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dishes()
        {
            this.ConsituentDishes = new HashSet<ConsituentDishes>();
            this.OrderDishes = new HashSet<OrderDishes>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public int TypeOfTheDishesID { get; set; }
        public decimal WeightOfTheDish { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConsituentDishes> ConsituentDishes { get; set; }
        public virtual TypesOfDishes TypesOfDishes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDishes> OrderDishes { get; set; }
    }
}
