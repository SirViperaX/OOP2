using System.Text;

namespace OOP2
{
    internal class MyDateTime
    {
        private int days;
        private int months;
        private int years;
        private int hours;
        private int minutes;
        private int seconds;

        public MyDateTime(int days = 0, int months = 0, int years = 0, int hours = 0, int minutes = 0, int seconds = 0)
        {
            this.days = days;
            this.months = months;
            this.years = years;
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.days)
              .Append(' ')
              .Append(string.Format("{0,2:D2}",this.months))
              .Append(' ')
              .Append(this.years)
              .Append(' ')
              .Append(this.hours)
              .Append(':')
              .Append(this.minutes)
              .Append(':')
              .Append(this.seconds);
            return sb.ToString();
        }
    }
}