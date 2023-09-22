using ConAdmin.Domain.Projects;

namespace ConAdmin.Domain.Submittals;

public record CopyTo(ProjectContact Contact, string Notes);