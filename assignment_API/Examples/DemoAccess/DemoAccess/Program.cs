using Google.Cloud.Storage.V1;
using System;
using System.IO;

namespace DemoAccess
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            string projectID = "ciconi-1";

            StorageClient sc = StorageClient.Create();
            string buckedName = projectID + "-test-bucket";

            try
            {
                sc.CreateBucket(projectID, buckedName);
                Console.WriteLine($"Bucket{buckedName} created.");


                //upload coisas
                MemoryStream ms = new MemoryStream();
                using (FileStream file = new FileStream("C:\Users\ZeusAC\Desktop\1.png",
                    FileMode.Open, FileAccess.Read)) file.CopyTo(ms);

                var obj1 = sc.UploadObject(buckedName, "testc.pnj", "images/png", ms);

                // FileStream mp4 = new
                //parei aqui//
            }
            catch (Google.GoogleApiException e)
            when (e.Error.Code == 409)
            {

                Console.WriteLine(e.Error.Message);
            }
        }
    }
}
