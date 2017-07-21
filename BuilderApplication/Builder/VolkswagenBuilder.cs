namespace BuilderApplication.Builder
{
    public class VolkswagenBuilder : CarBuilderBase
    {
        public VolkswagenBuilder() : base()
        {
        }

        public override void BuildEngine()
        {
            Car.Engine = "1.8 TSI";
        }

        public override void BuildFrame()
        {
            Car.Frame = "VW frame";
        }

        public override void BuildLuxury()
        {
            Car.Luxury = "VW R-style";
        }

        public override void BuildMultimedia()
        {
            Car.Multimedia = "VW RNS 510";
        }

        public override void BuildSafety()
        {
            Car.Safety = "VW Lane Assist";
        }

        public override void BuildWheels()
        {
            Car.Wheels += "17\" VW Wheel";
        }
    }
}
