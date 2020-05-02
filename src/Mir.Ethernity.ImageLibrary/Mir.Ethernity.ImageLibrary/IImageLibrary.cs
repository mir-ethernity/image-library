using System;
using System.Collections.Generic;

namespace Mir.Ethernity.ImageLibrary
{
    public interface IImageLibrary : IDisposable
    {
        bool Initialized { get; }

        string Name { get; }
        int Count { get; }

        IDictionary<ImageType, IImage> this[int index] { get; }

        void Initialize();
    }
}
