using System;
namespace Mir.Ethernity.ImageLibrary
{
    public interface IImage
    {
        bool HasData { get; }
        ImageDataType DataType { get; }
        ModificatorType Modificator { get; }
        CompressionType Compression { get; }

        ushort Width { get; }
        ushort Height { get; }
        short OffsetX { get; }
        short OffsetY { get; }

        byte[] GetBuffer();
    }
}
