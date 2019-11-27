using System;
namespace Mir.Ethernity.ImageLibrary
{
    public interface IImage
    {
        ushort Index { get; }

        IImageContent this[ImageType type] { get; }
    }
}
