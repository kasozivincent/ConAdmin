using ConAdmin.Domain.Contacts;

namespace ConAdmin.Domain.Projects;

public class ProjectContact : EntityBase
{
    public Project Project { get; }
    public bool OnFinalDistributionList { get; set; }
    public Contact Contact { get; }
    
    public ProjectContact(Project project, object? key, Contact contact) : base(key)
    {
        Project = project;
        Contact = contact;
        OnFinalDistributionList = false;
    }
}