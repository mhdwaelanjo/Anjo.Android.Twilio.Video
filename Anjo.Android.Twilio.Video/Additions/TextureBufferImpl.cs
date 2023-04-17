using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tvi.Webrtc
{
    public partial class TextureBufferImpl : global::Java.Lang.Object, global::Tvi.Webrtc.VideoFrame.ITextureBuffer
    {
        VideoFrame.ITextureBuffer.Type? VideoFrame.ITextureBuffer.GetType()
        {
            return this.Type; 
        }
    }

    public abstract partial class WrappedNativeVideoEncoder : global::Java.Lang.Object, global::Tvi.Webrtc.IVideoEncoder
    {
        public IVideoEncoder.ScalingSettings? GetScalingSettings()
        {
            return this.ScalingSettings;
        }
    }
}
