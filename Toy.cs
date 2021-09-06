using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovenseAPI
{
    public class Toy
    {
        public string id;
        public string name;
        public int status;
        public int battery;
        public string fVersion;
        public bool control;
        public string nickName;
        public string mode;
        public string version;

        public bool Request(string action)
        {
            Dictionary<string, dynamic> parameters = new();
            parameters.Add("t", id);

            return Lovense.Request(action, parameters);
        }

        public bool Request(string action, Dictionary<string, dynamic> parameters)
        {
            parameters = parameters != null ? parameters : new();
            parameters.Add("t", id);

            return Lovense.Request(action, parameters);
        }
        public bool Request(string action, Dictionary<string,dynamic> parameters, out string value)
        {
            parameters = parameters != null ? parameters : new();
            parameters.Add("t", id);

            return Lovense.Request(action, parameters, out value);
        }

        public bool Vibrate(int speed)
        {
            return Request("Vibrate", new()
            {
                { "v", speed }
            });
        }

        public bool AVibrate(int speed, int sec)
        {
            return Request("AVibrate", new()
            {
                { "v", speed },
                { "sec", sec }
            });
        }

        public int Battery()
        {
            string body;
            bool found = Request("Battery", null, out body);

            BatteryResponse resp = JsonConvert.DeserializeObject<BatteryResponse>(body);

            return resp.data;
        }
    }
}
