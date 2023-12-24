namespace Model.DTO
{
    public interface IInputForForm<out T>
    {
        public string Title { get; set; }
        public T Object { get;}
    }
}
