using System.ComponentModel.DataAnnotations.Schema;

namespace Calendar.Domain.Entities;

public class EventEntity
{
    public long Id { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Title { get; set; }
    public string Location { get; set; }
    public string Description { get; set; }
    [NotMapped] public string ScheduleString => "2024/07/12";
}