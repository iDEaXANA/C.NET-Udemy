using System.Text.Json.Serialization;

namespace CNET.C.NET.Models {

    public class Computer {
        [JsonPropertyName("computer_id")]
        public int ComputerId {get; set;}
        [JsonPropertyName("motherboard")]
        public string Motherboard {get; set;} = "";
        // private string _motherboard;
        // private string Motherboard {get{return _motherboard;} set(_motherboard = value;)}
        [JsonPropertyName("cpu_cores")]
        public int? CPUCores {get; set;} 
        [JsonPropertyName("has_wifi")]
        public bool HasWifi {get; set;}
        [JsonPropertyName("has_lte")]
        public bool HasLTE {get; set;}
        [JsonPropertyName("release_date")]
        public DateTime? ReleaseDate {get; set;}
        [JsonPropertyName("price")]
        public decimal Price {get; set;}
        [JsonPropertyName("video_card")]
        public string VideoCard {get; set;} = "";

        //!! Old Way!
        // public Computer() {
        //     if (Motherboard == null) {
        //         Motherboard = "";
        //     }
        //     if (VideoCard == null) {
        //         VideoCard = "";
        //     }
        // }
    }
    
}