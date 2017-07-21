namespace AdapterApplication.HomeCats
{
    public interface IHomeCat
    {
        string Name { get; set; }
        void Meow();
        void Scratch();
    }
}
