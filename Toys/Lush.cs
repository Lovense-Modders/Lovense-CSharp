namespace LovenseAPI.Toys
{
    public class Lush : Toy
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
