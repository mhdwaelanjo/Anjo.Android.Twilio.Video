using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Twilio.Video
{
    public partial class LocalParticipant : global::Java.Lang.Object, global::Com.Twilio.Video.IParticipant
    {
        public IParticipant.State GetState()
        {
            return this.State; 
        }
    }

    public partial class RemoteParticipant : global::Java.Lang.Object, global::Com.Twilio.Video.IParticipant
    {
        public IParticipant.State GetState()
        {
            return this.State;
        }
    }

}
