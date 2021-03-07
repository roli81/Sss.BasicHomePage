using System.Collections.Generic;
using System.Net.Mime;
using Sss.BasicHomePage.Models.Poco;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;

namespace Sss.BasicHomePage.Services
{
    public interface IImageService
    {
        Image GetImage(IPublishedContent img, int? width = null, int? height = null, ImageCropMode imageCropMode = ImageCropMode.Crop);
        IEnumerable<Image> GetImages(IEnumerable<IPublishedContent> mediaNodes, int? width = null, int? height = null);


    }
}