namespace LovenseAPI.Toys
{
    public class Ambi : Toy
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
