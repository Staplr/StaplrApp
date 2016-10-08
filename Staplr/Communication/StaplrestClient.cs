using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Net;
using System.Json;
using System.IO;
using System.Threading.Tasks;

using Staplr.User;
using Staplr.Common;
using Staplr.Stapl;

namespace Staplr.Communication
{
    public static class StaplrestClient
    {
        static StaplrestClient()
        {
            RemoteUrl = "staplr.me/api/";
        }

        public static JsonValue CreateNewUser(User.User user, String password)
        {
            String remoteString = RemoteUrl + "users/";
            remoteString += "JSON?username=" + user.Username;
            remoteString += "&email=" + user.Email;
            remoteString += "&password=" + password;
            remoteString += "&name=" + user.Name;

            HttpWebRequest request = new HttpWebRequest(new Uri(remoteString));
            request.ContentType = "application/json";
            request.Method = "POST";
            return SendRequest(request).Result;
        }

        public static JsonValue DeleteUser(int userId)
        {
            String remoteString = RemoteUrl + "users/";
            remoteString += "JSON?id=" + userId.ToString();

            HttpWebRequest request = new HttpWebRequest(new Uri(remoteString));
            request.ContentType = "application/json";
            request.Method = "DELETE";
            return SendRequest(request).Result;
        }

        public static JsonValue GetUser(int userId)
        {
            String remoteString = RemoteUrl + "users/";
            remoteString += "JSON?id=" + userId.ToString();

            HttpWebRequest request = new HttpWebRequest(new Uri(remoteString));
            request.ContentType = "application/json";
            request.Method = "POST";
            return SendRequest(request).Result;
        }

        public static JsonValue GetAllUsers()
        {
            String remoteString = RemoteUrl + "users/";
            HttpWebRequest request = new HttpWebRequest(new Uri(remoteString));
            request.ContentType = "application/json";
            request.Method = "GET";
            return SendRequest(request).Result;
        }

        public static JsonValue CreateCourse(Course course)
        {
            String remoteString = RemoteUrl + "course/";
            remoteString += "JSON?instructor_Id=" + course.CourseInstructor.ToString();
            remoteString += "&description=" + course.Description;
            remoteString += "&name=" + course.CourseName;

            HttpWebRequest request = new HttpWebRequest(new Uri(remoteString));
            request.ContentType = "application/json";
            request.Method = "DELETE";
            return SendRequest(request).Result;
        }

        public static JsonValue DeleteCourse(int courseId)
        {
            String remoteString = RemoteUrl + "course/";
            remoteString += "JSON?course_id=" + courseId.ToString();

            HttpWebRequest request = new HttpWebRequest(new Uri(remoteString));
            request.ContentType = "application/json";
            request.Method = "DELETE";
            return SendRequest(request).Result;
        }

        public static JsonValue GetAllCourses()
        {
            String remoteString = RemoteUrl + "course/";
            HttpWebRequest request = new HttpWebRequest(new Uri(remoteString));
            request.ContentType = "application/json";
            request.Method = "DELETE";
            return SendRequest(request).Result;
        }

        public static JsonValue AddStudentToCourse(int userId, int courseId)
        {
            String remoteString = RemoteUrl + "add_to_course/";
            remoteString += "JSON?student_id=" + userId.ToString();
            remoteString += "&course_id=" + courseId.ToString();

            HttpWebRequest request = new HttpWebRequest(new Uri(remoteString));
            request.ContentType = "application/json";
            request.Method = "POST";
            return SendRequest(request).Result;
        }

        public static JsonValue RemoveStudentFromCourse(int userId, int courseId)
        {
            String remoteString = RemoteUrl + "remove_from_course/";
            remoteString += "JSON?student_id=" + userId.ToString();
            remoteString += "&course_id=" + courseId.ToString();

            HttpWebRequest request = new HttpWebRequest(new Uri(remoteString));
            request.ContentType = "application/json";
            request.Method = "POST";
            return SendRequest(request).Result;
        }

        public static JsonValue GetCourse(int courseId)
        {
            String remoteString = RemoteUrl + "course_from_id/";
            remoteString += "JSON?course_id=" + courseId.ToString();

            HttpWebRequest request = new HttpWebRequest(new Uri(remoteString));
            request.ContentType = "application/json";
            request.Method = "POST";
            return SendRequest(request).Result;
        }

        public static JsonValue CreateChapter(int courseId, Chapter chapter)
        {
            String remoteString = RemoteUrl + "chapter/";
            remoteString += "JSON?course_id=" + courseId.ToString();
            remoteString += "&description=" + chapter.Description;
            remoteString += "&name=" + chapter.ChapterName;

            HttpWebRequest request = new HttpWebRequest(new Uri(remoteString));
            request.ContentType = "application/json";
            request.Method = "POST";
            return SendRequest(request).Result;
        }

        public static JsonValue GetChapter(int chapterId)
        {
            String remoteString = RemoteUrl + "chapter_from_id/";
            remoteString += "JSON?chapter_id=" + chapterId.ToString();
            HttpWebRequest request = new HttpWebRequest(new Uri(remoteString));
            request.ContentType = "application/json";
            request.Method = "POST";
            return SendRequest(request).Result;
        }

        public static JsonValue GetAllChaptersByCourse(int courseId)
        {
            String remoteString = RemoteUrl + "chapter_from_course/";
            remoteString += "JSON?course_id=" + courseId.ToString();
            HttpWebRequest request = new HttpWebRequest(new Uri(remoteString));
            request.ContentType = "application/json";
            request.Method = "POST";
            return SendRequest(request).Result;
        }
        
        public static JsonValue GetChapterFromCourse(int courseId)
        {
            String remoteString = RemoteUrl + "chapter_from_id/";
            remoteString += "JSON?course_id=" + courseId.ToString();
            HttpWebRequest request = new HttpWebRequest(new Uri(remoteString));
            request.ContentType = "application/json";
            request.Method = "POST";
            return SendRequest(request).Result;
        }

        public static JsonValue DeleteChapter(int chapterId)
        {
            String remoteString = RemoteUrl + "chapter/";
            remoteString += "JSON?chapter_id=" + chapterId.ToString();
            HttpWebRequest request = new HttpWebRequest(new Uri(remoteString));
            request.ContentType = "application/json";
            request.Method = "DELETE";
            return SendRequest(request).Result;
        }

        public static JsonValue GetAllChapters()
        {
            String remoteString = RemoteUrl + "chapter/";
            HttpWebRequest request = new HttpWebRequest(new Uri(remoteString));
            request.ContentType = "application/json";
            request.Method = "GET";
            return SendRequest(request).Result;
        }

        public static JsonValue GetAllStapls()
        {
            String remoteString = RemoteUrl + "stapls/";
            HttpWebRequest request = new HttpWebRequest(new Uri(remoteString));
            request.ContentType = "application/json";
            request.Method = "GET";
            return SendRequest(request).Result;
        }

        public static JsonValue DeleteStapl(int staplId)
        {
            String remoteString = RemoteUrl + "stapls/";
            remoteString += "JSON?stapl_id=" + staplId.ToString();
            HttpWebRequest request = new HttpWebRequest(new Uri(remoteString));
            request.ContentType = "application/json";
            request.Method = "GET";
            return SendRequest(request).Result;
        }

        public static JsonValue CreateNewPoll(int chapterId, List<String> optionList, int userId)
        {
            String remoteString = RemoteUrl + "poll_from_chapter/";
            remoteString += "JSON?chapter_id=" + chapterId.ToString();
            remoteString += "&user_id=" + userId.ToString();
            for (int i = 0; i < optionList.Count; i++)
            {
                remoteString += "&options=" + optionList[i];
            }
            HttpWebRequest request = new HttpWebRequest(new Uri(remoteString));
            request.ContentType = "application/json";
            request.Method = "POST";
            return SendRequest(request).Result;
        }

        public static JsonValue DeactivatePoll(int staplId)
        {
            String remoteString = RemoteUrl + "poll_inactive/";
            remoteString += "JSON?stapl_id=" + staplId.ToString();
            HttpWebRequest request = new HttpWebRequest(new Uri(remoteString));
            request.ContentType = "application/json";
            request.Method = "POST";
            return SendRequest(request).Result;
        }

        public static JsonValue GetPollResults(int staplId)
        {
            String remoteString = RemoteUrl + "poll_inactive/";
            remoteString += "JSON?stapl_id=" + staplId.ToString();
            HttpWebRequest request = new HttpWebRequest(new Uri(remoteString));
            request.ContentType = "application/json";
            request.Method = "POST";
            return SendRequest(request).Result;
        }

        public static async Task<JsonValue> SendRequest(HttpWebRequest request)
        {
            // Send the request to the server and wait for the response:
            using (WebResponse response = await request.GetResponseAsync())
            {
                // Get a stream representation of the HTTP web response:
                using (Stream stream = response.GetResponseStream())
                {
                    // Use this stream to build a JSON document object:
                    JsonValue jsonDoc = await Task.Run(() => JsonObject.Load(stream));
                    Console.Out.WriteLine("Response: {0}", jsonDoc.ToString());

                    // Return the JSON document:
                    return jsonDoc;
                }
            }
        }

        public static String RemoteUrl { get; set; }
    }
}