using System;
namespace Mir.Ethernity.ImageLibrary
{
    public interface IImage
    {
        int Index { get; }

        IImageContent this[ImageType type] { get; }
    }
}
