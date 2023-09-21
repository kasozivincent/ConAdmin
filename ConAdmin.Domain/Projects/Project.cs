using ConAdmin.Domain.Companies;
using ConAdmin.Domain.Employees;

namespace ConAdmin.Domain.Projects;

public class Project : EntityBase
{
    public string Number { get; }
    public string Name { get; }
    public Address Address { get; set; }
    private Company _owner;
    private Employee constructionAdministrator;
    private Employee principalInCharge;
    private DateTime? contractDate;
    private DateTime? estimatedStartDate;
    private DateTime? estimatedCompletionDate;
    private DateTime? adjustedCompletionDate;
    private DateTime? currentCompletionDate;
    private DateTime? actualCompletionDate;
    private decimal contingencyAllowanceAmount;
    private decimal testingAllowanceAmount;
    private decimal utilityAllowanceAmount;
    private decimal originalConstructionCost;
    private int totalChangeOrderDays;
    private decimal adjustedConstructionCost;
    private decimal totalChangeOrdersAmount;
    private int totalSquareFeet;
    private int percentComplete;
    private string remarks;
    private decimal aeChangeOrderAmount;
    private string contractReason;
    private string agencyApplicationNumber;
    private string agencyFileNumber;
    private MarketSegment segment;
    private List<Allowance> allowances;
    private List<Contract> contracts;

    public Project(object key, string number, string name) : base(key)
    {
        Number = number;
        Name = name;
        Address = null;
        //this._owner = new Company();
        this.constructionAdministrator = null;
        this.principalInCharge = null;
        this.contractDate = null;
        this.estimatedStartDate = null;
        this.estimatedCompletionDate = null;
        this.currentCompletionDate = null;
        this.actualCompletionDate = null;
        this.contingencyAllowanceAmount = 0;
        this.testingAllowanceAmount = 0;
        this.utilityAllowanceAmount = 0;
        this.originalConstructionCost = 0;
        this.totalChangeOrderDays = 0;
        this.adjustedConstructionCost = 0;
        this.totalChangeOrdersAmount = 0;
        this.totalSquareFeet = 0;
        this.percentComplete = 0;
        this.remarks = string.Empty;
        this.aeChangeOrderAmount = 0;
        this.contractReason = string.Empty;
        this.agencyApplicationNumber = string.Empty;
        this.agencyFileNumber = string.Empty;
        this.segment = null;
        this.allowances = new List<Allowance>();
        this.contracts = new List<Contract>();
    }
   
}
    