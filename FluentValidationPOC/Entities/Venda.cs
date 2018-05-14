using System;
using System.Collections.Generic;

namespace FluentValidationPOC.Entities
{
    public class Venda
    {
        public DateTime Data { get; set; }
        public decimal Total { get; set; }
        public TipoVenda Tipo { get; set; }
        public List<ItemVenda> Itens { get; set; }
    }
}
