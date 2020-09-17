using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x17db940b)]
    public class TLBotInlineMediaResult : TLAbsBotInlineResult
    {
        public override uint Constructor
        {
            get
            {
                return 0x17db940b;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public string Id { get; set; }
        [MTParameter(Order = 2)]
        public string Type { get; set; }
        [MTParameter(Order = 3, FromFlag = 0, FlagType = FlagType.Null)]
        public TLAbsPhoto Photo { get; set; }
        [MTParameter(Order = 4, FromFlag = 1, FlagType = FlagType.Null)]
        public TLAbsDocument Document { get; set; }
        [MTParameter(Order = 5, FromFlag = 2, FlagType = FlagType.Null)]
        public string Title { get; set; }
        [MTParameter(Order = 6, FromFlag = 3, FlagType = FlagType.Null)]
        public string Description { get; set; }
        [MTParameter(Order = 7)]
        public TLAbsBotInlineMessage SendMessage { get; set; }


    }
}