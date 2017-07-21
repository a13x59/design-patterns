using AdapterApplication.HomeCats;
using AdapterApplication.WildCats;

namespace AdapterApplication.Adapters
{
    public class HomeCatAdapter : IHomeCat
    {
        private IWildCat _wildCat;
        public string Name {
            get { return _wildCat.Breed; }
            set { }
        }

        public HomeCatAdapter(IWildCat wildCat)
        {
            _wildCat = wildCat;
        }

        public void Meow()
        {
            _wildCat.Growl();
        }

        public void Scratch()
        {
            _wildCat.Scratch();
        }
    }
}
