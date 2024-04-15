using ToDoList.MVC.Models;

namespace ToDoList.MVC.Helpers
{
    public static class CalendarHelper
    {
        public static CalendarViewModel GetCalendarViewModelByMonth(int month = 0)
        {
            int year = DateTime.Now.Year;

            month = month == 0
                ? DateTime.Now.Month
                : month;

            DateTime selectedDate = new DateTime(year, month, 1);
            DateTime firstDayOfMonth = new DateTime(selectedDate.Year, selectedDate.Month, 1);

            int daysInWeek = Enum.GetNames(typeof(DayOfWeek)).Length;
            int dayOfWeek = ((int)firstDayOfMonth.DayOfWeek - 1 + daysInWeek) % daysInWeek;

            int daysInMonth = DateTime.DaysInMonth(selectedDate.Year, selectedDate.Month);

            return new CalendarViewModel
            {
                Month = month,
                SelectedDate = selectedDate,
                DayOfWeek = dayOfWeek,
                DaysInMonth = daysInMonth,
                DaysWithToDoItem = new HashSet<int>()
            };
        }
    }
}
