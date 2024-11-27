using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseBase.Domain.Entities
{
    public class BaseRecord
    {
        public string NameOfPart { get; set; } = default!;

        public string? IndeksNumber { get; set; }
        public string? Description {  get; set; }  

        public int NumberOfPartsInBase { get; set; }  

    }
}
