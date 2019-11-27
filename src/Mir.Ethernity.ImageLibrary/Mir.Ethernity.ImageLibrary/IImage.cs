using System;
namespace Mir.Ethernity.ImageLibrary
{
    public struct ImageContent
    {
        public ushort Width;
        public ushort Height;
        public short OffsetX;
        public short OffsetY;
    }

    public struct ShadowContent
    {
        public ShadowType Type;
        public ushort Width;
        public ushort Height;
        public short OffsetX;
        public short OffsetY;
    }

    public struct OverlayContent
    {
        public ushort Width;
        public ushort Height;
        public short OffsetX;
        public short OffsetY;
    }

    public interface IImage
    {
        int Index { get; }

        ImageContent Image { get; }
        ShadowContent Shadow { get; }
        OverlayContent Overlay { get; }

        ImageData GetData(ImageType type);
    }
}
