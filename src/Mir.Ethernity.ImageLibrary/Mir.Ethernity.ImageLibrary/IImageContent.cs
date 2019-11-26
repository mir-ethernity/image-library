namespace Mir.Ethernity.ImageLibrary
{
    public interface IImageContent
    {
        ushort Width { get; set; }
        ushort Height { get; set; }
        short OffsetX { get; }
        short OffsetY { get; }

        ImageData GetData();
    }
}
