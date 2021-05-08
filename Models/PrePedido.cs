using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace plantitas.Models
{
    //CARRITO
    [Table("t_pre_order")]
    public class PrePedido
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID {get; set;}

        public String UserID {get; set;}

        public int ProductID{get; set;}

        public int Quantity {get; set;}

        public Decimal Price { get; set; }
    }
}