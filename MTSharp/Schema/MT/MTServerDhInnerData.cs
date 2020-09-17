using MTSharp.Attributes;

namespace MTSharp.Schema.MT
{
    [MTObject(0xb5890dba)]
    public class MTServerDhInnerData : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xb5890dba;
            }
        }

        [MTParameter(Order = 0, BytesCount = 16)]
        public byte[] Nonce { get; set; }
        [MTParameter(Order = 1, BytesCount = 16)]
        public byte[] ServerNonce { get; set; }
        [MTParameter(Order = 2)]
        public int G { get; set; }
        [MTParameter(Order = 3)]
        public byte[] DhPrime { get; set; }
        [MTParameter(Order = 4)]
        public byte[] GA { get; set; }
        [MTParameter(Order = 5)]
        public int ServerTime { get; set; }


    }
}