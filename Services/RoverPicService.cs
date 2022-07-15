using RoverAPI.Interfaces;
using System.Text.Json;
using RoverAPI.Models;
using RestSharp;

namespace RoverAPI.Services
{
    public class RoverPicService : IRoverPicService
    {
        RestClient client = new RestClient();

        public Content GetPicsBySolDate(int solDate)
        {
            string url = $"https://mars-photos.herokuapp.com/api/v1/rovers/curiosity/photos?api_key=DEMO_KEY&sol={solDate}";
            Content photosArray = null;
            RestRequest request = new RestRequest(url);

            var response = client.GetAsync(request);
            var resString = response.Result.Content;
            if (resString != null)
            {
                photosArray = Newtonsoft.Json.JsonConvert.DeserializeObject<Content>(resString);
                for (var i = 0; i < photosArray.Photos.Count; i++)
                {
                    var photo = photosArray.Photos[i];
                    string fileName = photo.Id.ToString();
                    Uri imgUrl = photo.ImgSrc;

                    var path = Path.Combine(Directory.GetCurrentDirectory(), "Image Directory", fileName);

                    using (var client = new HttpClient())
                    {
                        using (var imageStream = client.GetStreamAsync(imgUrl))
                        {
                            using (var stream = new FileStream(path, FileMode.Create))
                            {
                                imageStream.Result.CopyTo(stream);
                            }
                        }
                    }
                }
            }
            return photosArray;
        }
    }
}
