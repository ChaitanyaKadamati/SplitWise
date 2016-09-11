
namespace TestApplication
{
    public  class Expense
    {
        public float Money { get; set; }

        public void UpdateSpent(float howMuchSpent)
        {
            this.Money += howMuchSpent;
        }

        public void UpdateBorrow(float chargesPerHead)
        {
            this.Money -= chargesPerHead;
        }
    }
}
