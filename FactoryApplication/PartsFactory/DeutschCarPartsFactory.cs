using FactoryApplication.Parts;

namespace FactoryApplication.PartsFactory
{
    public class DeutschCarPartsFactory : CarPartsFactory
    {
        public override Engine CreateEngine()
        {
            return new DieselEngine();
        }

        public override Paint CreatePaint()
        {
            return new WhitePaint();
        }

        public override Wheels CreateWheels()
        {
            return new BigWheels();
        }
    }
}
