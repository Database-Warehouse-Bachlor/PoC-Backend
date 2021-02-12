namespace PoC_backend.Models {
    public class Tennant {
        public int businessId {get;set;}
        public string tennantName{get; set;}
        public string address {get; set;}
        public string city {get; set;}
        public int zipcode {get; set;}
        public string errorLog {get; set;}
        public bool missingData {get; set;}
    }
}