// JSON pertsonaiak transformatua
using Newtonsoft.Json;

public class Rootobject
{

    public Class1[] Property1 { get; set; }
}

public class Class1


{
    [JsonProperty("char_id")]
    public int char_id { get; set; }
    [JsonProperty("name")]
    public string name { get; set; }
    [JsonProperty("birthday")]
    public string birthday { get; set; }
    [JsonProperty("occupation")]
    public string[] occupation { get; set; }
    [JsonProperty("img")]

    public string img { get; set; }
    [JsonProperty("status")]

    public string status { get; set; }
    [JsonProperty("nickname")]

    public string nickname { get; set; }
    [JsonProperty("appearance")]


    public int?[] appearance { get; set; }
    [JsonProperty("portrayed")]

    public string portrayed { get; set; }
    [JsonProperty("category")]

    public string category { get; set; }
    [JsonProperty("better_call_saul_appearance")]

    public int?[] better_call_saul_appearance { get; set; }
}
