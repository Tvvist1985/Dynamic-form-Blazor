namespace Model
{
    public class DateInput : IFormType<DateTime>
    {      
        public DateTime Value { get; set; }
        public DateInput() { }
        public DateInput(DateTime value)
        {
            Value = value;          
        }
    }
}
