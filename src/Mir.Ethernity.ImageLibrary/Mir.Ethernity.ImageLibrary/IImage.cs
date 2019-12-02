using System;
namespace Mir.Ethernity.ImageLibrary
{
    public interface IImage
    {
        ModificatorType Modificator { get; }

        ushort Width { get; }
        ushort Height { get; }
        short OffsetX { get; }
        short OffsetY { get; }

        ImageData GetData();
    }
}
