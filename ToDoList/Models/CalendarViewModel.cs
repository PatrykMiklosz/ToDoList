namespace ToDoList.MVC.Models
{
    public class CalendarViewModel
    {
        public int Month { get; set; }
        public DateTime SelectedDate { get; set; }
        public int DayOfWeek { get; set; }
        public int DaysInMonth { get; set; }
        public HashSet<int>? DaysWithToDoItem { get; set; }
    }
}
