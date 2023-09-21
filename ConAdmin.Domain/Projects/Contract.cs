using ConAdmin.Domain.Companies;

namespace ConAdmin.Domain.Projects;

public class Contract : EntityBase
{
    public Company Contractor { get; set; }
    public string ScopeOfWork { get; set; }
    public string BidPackageNumber { get; set; }
    
    public DateTime? ContractDate { get; set; }
    
    public DateTime? NoticeToProceedDate { get; set; }
    public decimal ContractAmount { get; set; }
 
    public Contract(object key) : base(key)
    {
        //Contractor = new Company();
        ScopeOfWork = string.Empty;
        BidPackageNumber = string.Empty;
        ContractAmount = 0;
    }
 
   
}