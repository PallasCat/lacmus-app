using System.Collections.Generic;
using Avalonia.Media;
using MetadataExtractor;

namespace RescuerLaApp.Models.Photo
{
    public class Photo : IPhoto
    {
        public ImageBrush ImageBrush { get; set; }
        public string Caption { get; set; }
        public Attribute Attribute { get; set; }
        public IReadOnlyList<Directory> MetaDataDirectories { get; set; }
    }
}