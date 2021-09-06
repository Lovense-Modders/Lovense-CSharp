namespace LovenseAPI.Toys
{
    class Max : Toy
    {
        public bool AirAuto(int speed)
        {
            return Request("AirAuto", new()
            {
                { "v", speed }
            });
        }
        public bool AirIn()
        {
            return Request("AirIn");
        }
        public bool AirOut()
        {
            return Request("AirOut");
        }
        public bool AAirLevel(int speed, int sec)
        {
            return Request("AAirLevel", new()
            {
                { "a", speed },
                { "sec", sec }
            });
        }
        public bool AVibAir(int vibration, int contraction, int sec)
        {
            return Request("AVibAir", new()
            {
                { "v", vibration },
                { "a", contraction },
                { "sec", sec }
            });
        }
    }
}
