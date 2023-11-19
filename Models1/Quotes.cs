// JSON quotes transformatua
namespace SussyApi.Models1
{

    public class Rootobject
    {
        public Class2[] Property1 { get; set; }
    }

    public class Class2
    {

        public int quote_id { get; set; }
        public string quote { get; set; }
        public string author { get; set; }
        public string series { get; set; }
    }

}
