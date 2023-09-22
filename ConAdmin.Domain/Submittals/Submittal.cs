using ConAdmin.Domain.Employees;
using ConAdmin.Domain.Projects;

namespace ConAdmin.Domain.Submittals;

public class Submittal : EntityBase
{
    private object projectKey;
    private SpecificationSection specSection;
    private string specSectionPrimaryIndex;
    private string specSectionSecondaryIndex;
    private ProjectContact to;
    private DateTime transmittalDate;
    private Employee from;
    private int totalPages;
    private Delivery deliveryMethod;
    private string otherDeliveryMethod;
    private string phaseNumber;
    private bool reimbursable;
    private bool final;
    private List <CopyTo> copyToList;
    private DateTime? dateReceived;
    private string contractNumber;
    private List <TrackingItem> trackingItems;
    private List <RoutingItem> routingItems;
    private string remarks;
    private ActionStatus action;
    private SubmittalStatus status;
    private DateTime? dateToField;
    private SubmittalRemainderLocation remainderLocation;
    private string remainderUnderSubmittalNumber;
    private string otherRemainderLocation;
    
    public Submittal(SpecificationSection specSection, object projectKey)
        : this(null, specSection, projectKey)
    {
    }
    
    public Submittal(object key, SpecificationSection specSection,
        object projectKey) : base(key)
    {
        this.projectKey = projectKey;
        this.specSection = specSection;
        this.specSectionPrimaryIndex = "01";
        this.specSectionSecondaryIndex = "00";
        this.to = null;
        this.transmittalDate = DateTime.Now;
        this.from = null;
        this.totalPages = 1;
        this.deliveryMethod = Delivery.None;
        this.otherDeliveryMethod = string.Empty;
        this.phaseNumber = string.Empty;
        this.reimbursable = false;
        this.final = false;
        this.copyToList = new List < CopyTo > ();
        this.dateReceived = null;
        this.contractNumber = string.Empty;
        this.trackingItems = new List < TrackingItem > ();
        this.routingItems = new List < RoutingItem > ();
        this.remarks = string.Empty;
        this.action = ActionStatus.NoExceptionTaken;
        this.status = null;
        this.dateToField = null;
        this.remainderLocation = SubmittalRemainderLocation.None;
        this.remainderUnderSubmittalNumber = string.Empty;
        this.otherRemainderLocation = string.Empty;
        //this.Validate();
    }
    
    public object ProjectKey
    {
        get { return this.projectKey; }
    }
 
    public SpecificationSection SpecSection
    {
        get { return this.specSection; }
        set { this.specSection = value; }
    }
 
    public string SpecSectionPrimaryIndex{
        get { return this.specSectionPrimaryIndex; }
        set { this.specSectionPrimaryIndex = value; }
    }
 
    public string SpecSectionSecondaryIndex
    {
        get { return this.specSectionSecondaryIndex; }
        set { this.specSectionSecondaryIndex = value; }
    }
 
    public string Number
    {
        get => string.Format("{0}.{1}.{2}",
            this.specSection.Number, this.specSectionPrimaryIndex,
            this.specSectionSecondaryIndex);
    }
 
    public ProjectContact To
    {
        get { return this.to; }
        set { this.to = value; }
    }
 
    public DateTime TransmittalDate
    {
        get { return this.transmittalDate; }
        set { this.transmittalDate = value; }
    }
 
    public Employee From
    {
        get { return this.from; }
        set { this.from = value; }
    }
 
    public int TotalPages
    {
        get { return this.totalPages; }
        set { this.totalPages = value; }
    }
 
    public Delivery DeliveryMethod
    {
        get { return this.deliveryMethod; }
        set { this.deliveryMethod = value; }
    }
    
    public string OtherDeliveryMethod{
        get { return this.otherDeliveryMethod; }
        set { this.otherDeliveryMethod = value; }
    }
 
    public string PhaseNumber
    {
        get { return this.phaseNumber; }
        set { this.phaseNumber = value; }
    }
 
    public bool Reimbursable
    {
        get { return this.reimbursable; }
        set { this.reimbursable = value; }
    }
 
    public bool Final
    {
        get { return this.final; }
        set { this.final = value; }
    }
 
    public IList < CopyTo >CopyToList
    {
        get { return this.copyToList; }
    }
 
    public DateTime? DateReceived
    {
        get { return this.dateReceived; }
        set { this.dateReceived = value; }
    }
 
    public string ContractNumber
    {
        get { return this.contractNumber; }
        set { this.contractNumber = value; }
    }
 
    public IList < TrackingItem >TrackingItems
    {
        get { return this.trackingItems; }
    }
 
    public IList < RoutingItem >RoutingItems
    {
        get { return this.routingItems; }
    }public string Remarks
    {
        get { return this.remarks; }
        set { this.remarks = value; }
    }
 
    public ActionStatus Action
    {
        get { return this.action; }
        set { this.action = value; }
    }
 
    public SubmittalStatus Status
    {
        get { return this.status; }
        set { this.status = value; }
    }
 
    public DateTime? DateToField
    {
        get { return this.dateToField; }
        set { this.dateToField = value; }
    }
 
    public SubmittalRemainderLocation RemainderLocation
    {
        get { return this.remainderLocation; }
        set { this.remainderLocation = value; }
    }
 
    public string RemainderUnderSubmittalNumber
    {
        get { return this.remainderUnderSubmittalNumber; }
        set { this.remainderUnderSubmittalNumber = value; }
    }
 
    public string OtherRemainderLocation
    {
        get { return this.otherRemainderLocation; }
        set { this.otherRemainderLocation = value; }
    } 
}