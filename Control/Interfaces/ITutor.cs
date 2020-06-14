namespace Control.Interfaces
{
    interface ITutor
    {
        short TutorId { get; set; }
        string TutorName { get; set; }
        string Type { get; set; }
        string Tel { get; set; }
        string Email { get; set; }
        char Sex { get; set; }


    }
}
