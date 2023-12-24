namespace Model
{
    public class CheckInput : IFormType<bool>
    {    
        public bool Value { get; set; }
        public CheckInput() { }
       
        public CheckInput(bool value)
        {
            Value = value;          
        }
    }
}
