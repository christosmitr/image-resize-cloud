using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Processing;
using System.IO;


namespace ImageResizeFunction.Services
{
    public class ImageResizer : IImageResizer
    {
        public void Resize(Stream input, Stream output)
        {
            using (Image image = Image.Load(input))
            {
                //Resize height and width of the image by 2
                image.Mutate(x => x.Resize(image.Width / 2, image.Height / 2));
                image.Save(output, new JpegEncoder());
            }
        }
    }
}
