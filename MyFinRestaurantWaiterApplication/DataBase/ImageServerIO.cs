
using MyFinCassa.Helper;
using RestSharp;
using System;
using System.Drawing;
using System.IO;

namespace MyFinCassa.Database
{
    public static class ImageServerIO
    {
        public static string photosFolderUri = DataSQL.URL + @"/photos";
        private static readonly RestClient client = new RestClient(photosFolderUri);

        public static void SaveJpegImageToServer(Image image, string imageName)
        {
            if (image == null || string.IsNullOrEmpty(imageName))
            {
                throw new ArgumentNullException("Image or imageName cannot be null");
            }

            try
            {
                using (var ms = new MemoryStream())
                {
                    // Сохраняем изображение в формате JPEG в MemoryStream
                    using (var bitmap = new Bitmap(image))
                    {
                        bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }

                    byte[] imageBytes = ms.ToArray();
                    imageName = TransliterationHelper.CyrillicToLatin(imageName);
                    var req = new RestRequest("/upload_image.php")
                        .AddFile("image", imageBytes, imageName + ".jpg", "image/jpeg");

                    var res = client.Post(req);
                }
            }
            catch (Exception ex)
            {
                // Обрабатываем ошибку
                Dialog.Error(ex.Message.ToString());
            }
        }

        public static void SavePngImageToServer(Image image, string imageName)
        {
            if (image == null || string.IsNullOrEmpty(imageName))
            {
                throw new ArgumentNullException("Image or imageName cannot be null");
            }

            try
            {
                using (var ms = new MemoryStream())
                {
                    // Сохраняем изображение в формате PNG в MemoryStream
                    using (var bitmap = new Bitmap(image))
                    {
                        bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    }

                    byte[] imageBytes = ms.ToArray();
                    imageName = TransliterationHelper.CyrillicToLatin(imageName);
                    var req = new RestRequest("/upload_image.php")
                        .AddFile("image", imageBytes, imageName + ".png", "image/png");

                    var res = client.Post(req);
                }
            }
            catch (Exception ex)
            {
                // Обрабатываем ошибку
                Dialog.Error(ex.Message.ToString());
            }
        }

        public static Image GetImage(string imageName)
        {
            if (string.IsNullOrEmpty(imageName))
            {
                return null;
                //throw new ArgumentNullException("imageName cannot be null");
            }

            try
            {
                // URL сервера
                imageName = TransliterationHelper.CyrillicToLatin(imageName);
                string fullImagePath = photosFolderUri + "/images/" + imageName;
                var client = new RestClient(fullImagePath);
                var request = new RestRequest();

                // Выполняем запрос и получаем ответ
                byte[] imageBytes = client.DownloadData(request);

                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    Image img = Image.FromStream(ms);
                    return img;
                }
            }
            catch (Exception ex)
            {
                // Обрабатываем ошибку
                // Dialog.Error(ex.Message.ToString());
                Console.WriteLine(ex.Message.ToString());
                return null;
            }
        }
    }
}

