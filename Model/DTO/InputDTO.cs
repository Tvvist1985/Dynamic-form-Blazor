namespace Model.DTO
{
    public class InputDTO<T> : IInputForForm<T>
    {
        public T Object { get; set; }
        public string Title { get; set; } 
        public InputDTO() { }       
        public InputDTO(T obj, string title)
        {
            Object = obj;
            Title = title;
        }
    }
}
