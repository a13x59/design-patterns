using FactoryApplication.Parts;

namespace FactoryApplication.PartsFactory
{
    public abstract class CarPartsFactory
    {
        public abstract Engine CreateEngine();
        public abstract Paint CreatePaint();
        public abstract Wheels CreateWheels();
    }
}
