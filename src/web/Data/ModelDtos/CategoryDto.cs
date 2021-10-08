using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web.Data.ModelDtos
{
    public class CategoryDto
    {
        public int Id { get; set; } = 0;
        public string NameCategory { get; set; } = "";
        public string DescriptionCategory { get; set; } = "";
        public DateTime CurrentDate { get; set; }
        public bool IsIncome { get; set; }
        public string NameReceipt { get; set; } = "";
        public decimal SumReceipt { get; set; } = 0;
        public string NameExpenditure { get; set; } = "";
        public decimal SumExpenditure { get; set; } = 10;
        public int? ExpenditureId { get; set; }
        public int? ReceiptId { get; set; }

        public decimal CurrentBalance { get; set; } = 0;
        public decimal SavingForThisMounth { get; set; } = 0;
        public decimal BalanceTheBeginningMounth { get; set; } = 0;

        public string SumPercentage => (this.SumExpenditure * 100) / this.SumReceipt + "%";
    }
}
