using ConAdmin.Domain.Projects;

namespace ConAdmin.Domain.Submittals;

public class RoutingItem : EntityBase
{
    public Discipline Discipline { get; }
    public int RoutingOrder { get; }
    public ProjectContact Recipient { get; }
    public DateTime DateSent { get; }
    private DateTime? dateReturned;
    public int DaysLapsed { get; private set; }
 
    public RoutingItem(object key, Discipline discipline, int routingOrder, ProjectContact recipient,
        DateTime dateSent) : base(key)
    {
        Discipline = discipline;
        RoutingOrder = routingOrder;
        Recipient = recipient;
        DateSent = dateSent;
        this.dateReturned = null;
        DaysLapsed = 0;
    }
 
    public DateTime? DateReturned
    {
        get => this.dateReturned; 
        set
        {
            if (value == this.dateReturned || !value.HasValue) return;
            this.dateReturned = value;
            this.CalculateDaysLapsed();
        }
    }
    private void CalculateDaysLapsed()
    {
        if (this.dateReturned.HasValue && this.dateReturned.Value > DateSent)
            DaysLapsed = this.dateReturned.Value.Subtract(DateSent).Days;
    }
}
