using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Sss.BasicHomePage.Models.Poco;
using Sss.BasicHomePage.Services;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.Web.Models;

namespace Sss.BasicHomePage.ServicesImpl
{
    public class ImageService : BaseService, IImageService
    {
        public Image GetImage(IPublishedContent img, int? width = null, int? height = null, ImageCropMode imageCropMode = ImageCropMode.Crop)
        {

            var media = CurrentHelper.Media(img.Id);

            if (media == null)
                throw new NodeNotFoundException($"node width id {img.Id} not found!");


            return new Image()
            {
                LargeUrl = media.GetCropUrl(width, height, imageCropMode: imageCropMode),
                SmallUrl = media.GetCropUrl(width / 2, height, imageCropMode: imageCropMode),
                Alt = media.Name
            };
        }


        public IEnumerable<Image> GetImages(IEnumerable<IPublishedContent> mediaNodes, int? width = null, int? height = null)
        {
            var smallUrl = string.Empty;
            return mediaNodes.Select(mn => new Image() { LargeUrl = mn.GetCropUrl(width: width, height: height), SmallUrl = mn.GetCropUrl(width: width / 2, height: height) });
        }
    }
}
