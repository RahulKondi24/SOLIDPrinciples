namespace LSP
{
    public interface ITraining
    {
        int GetTrining();
    }
    public interface IMembership: ITraining
    {
        void Add();
    }
    public class Membership: IMembership
    {
        public virtual void Add()
        {
            // TO DO : 
        }
        public virtual int GetTrining()
        {
            return 2;
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
            return 10;
        }
    }
   
    //public class TrialMemberShip : Membership
    //{
    //    public override void Add()
    //    {
    //        throw new NotImplementedException("Trial Membership is not store in DB");
    //    }
    //    public override int GetTrining()
    //    {
    //        return 5;
    //    }
    //}
    public class TrialMemberShip : ITraining
    {
        public int GetTrining()
        {
            return 5;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            List<Membership> list = new List<Membership>();

            list.Add(new ProMemberShip());
            list.Add(new PlusMemberShip());
            //list.Add(new TrialMemberShip());
            foreach (var item in list)
            {
                item.Add();
            }
        }
    }
}