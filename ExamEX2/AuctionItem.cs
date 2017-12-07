using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ExamEX2
{
    [DataContract]
    public class AuctionItem
    {
        [DataMember]
        public int ItemNumber { get; set; }
        [DataMember]
        public string ItemDescription { get; set; }
        [DataMember]
        public int RatingPrice { get; set; }
        [DataMember]
        public decimal BidPrice { get; set; }
        [DataMember]
        public string BidCustomName { get; set; }
        [DataMember]
        public string BidCustomPhone { get; set; }
        [DataMember]
        public DateTime BidTimestamp { get; set; }
    }
}