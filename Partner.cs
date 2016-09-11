
namespace TestApplication
{
    public class Partner
    {
        public Person Name { get; set; }
        public bool IsLender
        {
            get
            {
                bool result = true;
                if (this.Value > 0)
                    result = false;
                return result;
            }
        }
        public float Value { get; set; }
    }
}
