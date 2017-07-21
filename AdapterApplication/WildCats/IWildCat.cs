namespace AdapterApplication.WildCats
{
    public interface IWildCat
    {
        string Breed { get; }
        void Growl();
        void Scratch();
    }
}
