//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tortuga_Sviridov.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.OrderDish = new HashSet<OrderDish>();
        }
    
        public int IDOrder { get; set; }
        public int IDTable { get; set; }
        public System.DateTime DateOrder { get; set; }
        public decimal FinishCost { get; set; }
        public int IDEmployee { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Table Table { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDish> OrderDish { get; set; }
    }
}
