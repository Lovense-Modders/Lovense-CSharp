namespace LovenseAPI.Toys
{
    public class Edge : Toy
    {
        public bool Vibrate1(int speed)
        {
            return Request("Vibrate1", new()
            {
                { "v", speed }
            });
        }
        public bool AVibrate1(int speed, int sec)
        {
            return Request("AVibrate1", new()
            {
                { "v", speed },
                { "sec", sec }
            });
        }
        public bool Vibrate2(int speed)
        {
            return Request("Vibrate2", new()
            {
                { "v", speed }
            });
        }
        public bool AVibrate2(int speed, int sec)
        {
            return Request("AVibrate2", new()
            {
                { "v", speed },
                { "sec", sec }
            });
        }
        public bool Preset(int pattern)
        {
            return Request("Preset", new()
            {
                { "v", pattern }
            });
        }
    }
}
