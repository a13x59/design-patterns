﻿using FactoryApplication.Parts;

namespace FactoryApplication.PartsFactory
{
    public class RussianCarPartsFactory : CarPartsFactory
    {
        public override Engine CreateEngine()
        {
            return new GasolineEngine();
        }

        public override Paint CreatePaint()
        {
            return new BlackPaint();
        }

        public override Wheels CreateWheels()
        {
            return new MediumWheels();
        }
    }
}
