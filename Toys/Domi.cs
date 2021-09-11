namespace LovenseAPI.Toys
{
    public class Domi : Toy
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
