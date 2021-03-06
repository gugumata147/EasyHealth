﻿namespace EasyHealth.Shared.Model
{
    using System.ComponentModel.DataAnnotations;

    public class HospitalSupply
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        [Required(ErrorMessage = "O campo \"Nome\" é obrigatório!")]
        [MaxLength(150, ErrorMessage = "O campo \"Nome\" não pode ultrapassar 150 caracteres!")]
        public string Name { get; set; }  
        [Required(ErrorMessage = "O campo \"Categoria\" é obrigatório")]
        public int? SupplyCategoryId { get; set; }        
        public SupplyCategory SupplyCategory { get; set; }        
    }
}
