using System;

namespace Mir.Ethernity.ImageLibrary
{
    public interface IImageLibrary : IDisposable
    {
        string Name { get; }
        int Length { get; }

        IImage[] Images { get; }
        IImage[] Shadows { get; }
        IImage[] Overlays { get; }
    }
}
