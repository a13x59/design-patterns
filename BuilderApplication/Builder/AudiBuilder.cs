namespace BuilderApplication.Builder
{
    public class AudiBuilder : CarBuilderBase
    {
        public AudiBuilder() : base()
        {
        }

        public override void BuildEngine()
        {
            Car.Engine = "2.0 TFSI";
        }

        public override void BuildFrame()
        {
            Car.Frame = "Audi frame";
        }

        public override void BuildLuxury()
        {
            Car.Luxury = "Audi Exclusive Interior";
        }

        public override void BuildMultimedia()
        {
            Car.Multimedia = "Audi MMI Multimedia";
        }

        public override void BuildSafety()
        {
            Car.Safety = "Side Assist";
        }

        public override void BuildWheels()
        {
            Car.Wheels += "18\" Audi Wheel";
        }
    }
}
