namespace LovenseAPI.Toys
{
    class Osci : Toy
    {
        public bool Preset(int pattern)
        {
            return Request("Preset", new()
            {
                { "v", pattern }
            });
        }
    }
}
