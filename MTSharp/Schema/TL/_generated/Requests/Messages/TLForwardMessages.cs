using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MTSharp;
using MTSharp.Attributes;
using MTSharp.Enums;
using MTSharp.Schema;
using MTSharp.Schema.TL;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0xd9fee60e)]
    public class TLForwardMessages : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xd9fee60e;
            }
        }

		[MTParameter(Order = 0)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FromFlag=5, FlagType= FlagType.True)]
		public bool Silent { get; set; }
		[MTParameter(Order = 2, FromFlag=6, FlagType= FlagType.True)]
		public bool Background { get; set; }
		[MTParameter(Order = 3, FromFlag=8, FlagType= FlagType.True)]
		public bool WithMyScore { get; set; }
		[MTParameter(Order = 4, FromFlag=9, FlagType= FlagType.True)]
		public bool Grouped { get; set; }
		[MTParameter(Order = 5)]
		public TLAbsInputPeer FromPeer { get; set; }
		[MTParameter(Order = 6)]
		public TLVector<int> Id { get; set; }
		[MTParameter(Order = 7)]
		public TLVector<long> RandomId { get; set; }
		[MTParameter(Order = 8)]
		public TLAbsInputPeer ToPeer { get; set; }
		[MTParameter(Order = 9, FromFlag=10, FlagType= FlagType.Null)]
		public int? ScheduleDate { get; set; }


    }
}