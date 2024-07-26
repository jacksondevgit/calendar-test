using System.ComponentModel.DataAnnotations.Schema;

namespace Calendar.Domain.Entities;

public class EventEntity
{
    public long Id { get; set; }
    public DateTime Schedule { get; set; }
    [NotMapped]
    public string ScheduleString => Schedule.ToString("yyyy/MM/dd");
}