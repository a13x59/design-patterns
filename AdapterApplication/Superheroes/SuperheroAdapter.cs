namespace AdapterApplication.Superheroes
{
    class SuperheroAdapter : ISuperhero
    {
        private IFly _fly;
        private IShoot _shoot;
        private IWalls _walls;

        public SuperheroAdapter(IFly fly, IShoot shoot, IWalls walls)
        {
            _fly = fly;
            _shoot = shoot;
            _walls = walls;
        }

        public void Fly()
        {
            _fly.Fly();
        }

        public void GoThrougtWalls()
        {
            _walls.GoThroughWalls();
        }

        public void Shoot()
        {
            _shoot.Shoot();
        }
    }
}
