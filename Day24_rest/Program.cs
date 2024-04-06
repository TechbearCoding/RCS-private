namespace Day24_rest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebService webService = new WebService();
            var client = new HttpClient();
            webService.GetPosts(client);
            webService.GetComment(client);
        }
    }
}
