namespace CaptureWebPage
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thread.CurrentThread.SetApartmentState(ApartmentState.STA);
            //byte[] img = new Uri("http://www.uol.com.br").ToImage();
            //using (var fs = new FileStream("test.bmp", FileMode.CreateNew))
            //{
            //    fs.Write(img, 0, img.Length);
            //    fs.Flush();
            //}

            //WebsiteToImage websiteToImage = new WebsiteToImage("http://stackoverflow.com/questions/2715385/convert-webpage-to-image-from-asp-net", @"Test2.jpg");
            //websiteToImage.Generate();
            //WebsiteToImage websiteToImage = new WebsiteToImage("https://github.com/jdavis?tab=repositories", @"Test3.jpg");
            //websiteToImage.Generate();
            WebsiteToImage websiteToImage = new WebsiteToImage("http://www.bbc.co.uk/vietnamese/world/2014/08/140817_ukraine_russian_aid_arrives.shtml", @"Test4.jpg");
            websiteToImage.Generate();
        }
    }
}
