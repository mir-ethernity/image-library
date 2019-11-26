using System;
namespace Mir.Ethernity.ImageLibrary
{
    public interface IImage
    {
        ushort Index { get; }

        IImage this[ImageType type] { get; }
    }
}
