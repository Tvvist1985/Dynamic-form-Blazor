namespace Model
{
    public class Date: FormType<DateTime>
    {
        public Date() { }
        public Date(DateTime DateTime, string title) : base(DateTime, title) { }        
    }
}
