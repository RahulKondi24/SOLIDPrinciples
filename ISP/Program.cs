namespace ISP
{
    public interface ITraining
    {
        int GetTraining();
        //int GetLiveTraining();
    }

    public interface IMembership : ITraining
    {
        void Add();
    }
    public interface ILiveTrining : IMembership
    {
        int GetLiveTraining();
    }
    //public class Membership : IMembership, ILiveTrining
    public  class Membership : IMembership
    {
        public virtual void Add()
        {
            // TO DO : 
        }

        public virtual int GetTraining()
        {
            return 2;
        }
        //public virtual int GetLiveTraining()
        //{
        //    return 5;
        //}

    }
    public class ProMemberShip : Membership
    {
        public override int GetTraining()
        {
            return 5;
        }
    }
    public class PlusMemberShip : Membership
    {
        public override int GetTraining()
        {
            return 10;
        }
    }
    public class PremiumMemberShip : Membership, ILiveTrining
    {
        public override void Add()
        {
            // TO DO
        }
        public override int GetTraining()
        {
            return 10;
        }
        public  int GetLiveTraining()
        {
            return 5;
        }
    }
    public class TrialMemberShip : ITraining
    {
        public int GetTraining()
        {
            return 2;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            //100 old clients 
            IMembership membership1 = new Membership();
            membership1.Add();

            //new clients Livetraining + self-paced
            ILiveTrining membership2 = new PremiumMemberShip();
            membership2.Add();
        }
    }
}