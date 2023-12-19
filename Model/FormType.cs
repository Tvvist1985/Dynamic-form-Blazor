namespace Model
{
    public class FormType<T>
    {
        public string Title { get; set; }
        public T Value { get; set; }
        public FormType() { }
        
        public FormType(T MyProperty, string title)
        {
            Value = MyProperty;
            Title = title;
        }
    }
}
