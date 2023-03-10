using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WolfR2.DtoModels
{
    public class LstTrnLineApproveDto
    {
        public EmployeeDto Approver { get; set; }
        public int Lineid { get; set; }
        public int Memoid { get; set; }
        public int Sequence { get; set; }
        public int EmpId { get; set; }
        public int SignatureId { get; set; }
        public string SignatureTh { get; set; }
        public string SignatureEn { get; set; }
        public string Modifiedby { get; set; }
        public string Modifieddate { get; set; }
        public int TemLineId { get; set; }
        public int ApproveType { get; set; }
        public int LineApproveSeq { get; set; }
    }
}
