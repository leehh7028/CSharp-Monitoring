using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Google.Apis.Auth.OAuth2;
using Grpc.Auth;
using Grpc.Core;
using Google.Api.Gax.Grpc;
using System.Diagnostics;
using Google.Cloud.Firestore;
using Google.Cloud.Datastore.V1;

/*
 * Fireabse 연동하는 과정에서 삭제된 패키지 목록
 * Google.Cloud.Firestore
 * Google.Cloud.Firestore.V1
 * Google.Cloud.Storage.V1
 * 
 * 해당 패키지들을 설치하면 충돌은 나지만 정상 실행이 됨 
 * 
 */
namespace SchoolBusMonitor
{
    public partial class Form1
    {
        public void Firebase_Connection()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"safe-zone-child-firebase-adminsdk-mq2cq-8ea2101a36.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            // Your Google Cloud Platform project ID.
            string projectId = "safe-zone-child";

            // Instantiates a client
            DatastoreDb db = DatastoreDb.Create(projectId);
           

            // The kind for the new entity
            string kind = "Task";
            // The name/ID for the new entity
            string name = "sampletask1";
            KeyFactory keyFactory = db.CreateKeyFactory(kind);
            // The Cloud Datastore key for the new entity
            Key key = keyFactory.CreateKey(name);

            var task = new Entity
            {
                Key = key,
                ["description"] = "8888Buy milk"
            };
            using (DatastoreTransaction transaction = db.BeginTransaction())
            {
                // Saves the task
                transaction.Upsert(task);
                transaction.Commit();

                Console.WriteLine($"Saved {task.Key.Path[0].Name}: {(string)task["description"]}");
            }
            
        }
    }
}
