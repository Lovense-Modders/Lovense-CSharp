namespace LovenseAPI.Toys
{
    public class Nora : Toy
    {
        public bool Rotate(int speed)
        {
            return Request("Rotate", new()
            {
                { "v", speed }
            });
        }
        public bool RotateAntiClockwise(int speed)
        {
            return Request("RotateAntiClockwise", new()
            {
                { "v", speed }
            });
        }
        public bool RotateClockwise(int speed)
        {
            return Request("RotateClockwise", new()
            {
                { "v", speed }
            });
        }
        public bool RotateChange()
        {
            return Request("RotateChange");
        }
        public bool ARotate(int speed, int sec)
        {
            return Request("ARotate", new()
            {
                { "r", speed },
                { "sec", sec }
            });
        }
        public bool AVibRotate(int vibration, int rotation, int sec)
        {
            return Request("AVibRotate", new()
            {
                { "v", vibration },
                { "r", rotation },
                { "sec", sec }
            });
        }
    }
}
