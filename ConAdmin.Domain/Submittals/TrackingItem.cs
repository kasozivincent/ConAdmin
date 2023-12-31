﻿namespace ConAdmin.Domain.Submittals;

public class TrackingItem : EntityBase
{
    private int totalItemsReceived;
    private int totalItemsSent;
    private int deferredApproval;
    private int substitutionNumber;
    private string description;
    private ActionStatus status;
 
    public TrackingItem()
    {
        this.totalItemsReceived = 0;
        this.totalItemsSent = 0;
        this.deferredApproval = 0;
        this.description = string.Empty;
        this.status = ActionStatus.NoExceptionTaken;
    }
 
    public int TotalItemsReceived
    {
        get { return this.totalItemsReceived; }
        set
        {
            if (value != this.totalItemsReceived)
            {
                this.totalItemsReceived = value;
                // Default to making the total number
                // of items sent equal to what was received
                this.totalItemsSent = value;
            }
        }
    }
 
    public int TotalItemsSent
    {
        get { return this.totalItemsSent; }
        set { this.totalItemsSent = value; }
    }
 
    public int DeferredApproval
    {
        get { return this.deferredApproval; }
        set { this.deferredApproval = value; }
    }
 
    public int SubstitutionNumber{
        get { return this.substitutionNumber; }
        set { this.substitutionNumber = value; }
    }
 
    public string Description
    {
        get { return this.description; }
        set { this.description = value; }
    }
 
    public ActionStatus Status
    {
        get { return this.status; }
        set { this.status = value; }
    }
}