namespace Model
{
    public class TextInput : IFormType<string>
    {     
        public string Value { get ; set ; }
        public TextInput() { }       
        public TextInput(string value)
        {
            Value = value ;           
        }
    }
}
