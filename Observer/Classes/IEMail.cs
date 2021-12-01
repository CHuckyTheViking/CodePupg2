namespace Design_Patterns_Assignment.Observer.Classes
{
    interface IEMail
    {   
        int Id { get; set; }
        string From { get; set; }
        string Message { get; set; }
    }
}