namespace LovenseAPI.Toys
{
    public class Hush : Toy
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
