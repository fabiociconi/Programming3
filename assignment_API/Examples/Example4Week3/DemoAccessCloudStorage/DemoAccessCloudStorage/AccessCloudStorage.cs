using Google.Cloud.Storage.V1;
using System;
using System.IO;
using System.Text;

namespace DemoAccessCloudStorage
{
    class AccessCloudStorage
    {
        static void Main(string[] args)
        {
            // Your Google Cloud Platform project ID.
            string projectId = "project4comp306";

            // Instantiates a client.
            StorageClient storageClient = StorageClient.Create();

            // The name for the new bucket.
            string bucketName = projectId + "-test-bucket";
            try
            {
                // Creates the new bucket.
                storageClient.CreateBucket(projectId, bucketName);
                Console.WriteLine($"Bucket {bucketName} created.");

                var content = Encoding.UTF8.GetBytes("hello, world");
                var obj1 = storageClient.UploadObject(bucketName, "sampleFile1.txt", "text/plain", new MemoryStream(content));
                var obj2 = storageClient.UploadObject(bucketName, "folder1/sampleFile2.txt", "text/plain", new MemoryStream(content));

                MemoryStream ms = new MemoryStream();
                using (FileStream file = new FileStream("garden.jpg", FileMode.Open, FileAccess.Read))
                         file.CopyTo(ms);

                var obj3 = storageClient.UploadObject(bucketName, "flower.jpg", "image/jpeg", ms);


					FileStream mp4file = new FileStream("SpannerDemo.mp4", FileMode.Open, FileAccess.Read);

					var obj5 = storageClient.UploadObject(bucketName, "Spanner.mp4", "video/mp4", mp4file);



                foreach (var obj in storageClient.ListObjects(bucketName, ""))
                {
                    Console.WriteLine(obj.Name);
                }

                //Download file
                using (var stream = File.OpenWrite("sampleFile1.txt"))
                {
                    storageClient.DownloadObject(bucketName, "sampleFile1.txt", stream);
                }


                using (var stream = File.OpenWrite("DownloadedSpanner.mp4"))
                {
                    storageClient.DownloadObject(bucketName, "Spanner.mp4", stream);
                }

            }
            catch (Google.GoogleApiException e)
            when (e.Error.Code == 409)
            {
                // The bucket already exists.  That's fine.
                Console.WriteLine(e.Error.Message);
            }
        }
    }
}
