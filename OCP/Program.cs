namespace OCP
{
    public class Membership
    {
        public int MembershipType { get; set; }
        public void Add()
        {
            // TO DO : 
        }
        public virtual int GetTrining()
        {
            return 2;
            //this we can add anthoer in this class we don't have to update this we can extends this 
            //if (MembershipType == 1)
            //{
            //    return 5;
            //}
            //else if (MembershipType == 2)
            //{
            //    return 10;
            //}
            //else if (MembershipType == 3)
            //{
            //    return 20;
            //}
            //else
            //{
            //    return 2;
            //}
        }
    }
    public class ProMemberShip : Membership
    {
        public override int GetTrining()
        {
            return 5;
        }
    }
    public class PlusMemberShip : Membership
    {
        public override int GetTrining()
        {
            return 10 ;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}