namespace BCS.App.Model
{
    public class NumberWithOutput
    {
        public NumberWithOutput(int number, string output)
        {
            this.Number = number;
            this.Output = output;
        }

        public int Number { get; set; }

        public string Output { get; set; }
    }
}
