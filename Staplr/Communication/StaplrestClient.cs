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

        public static HttpWebRequest CreateNewUser(User.User user, String password)
        {
            String remoteString = RemoteUrl + "users/";
            remoteString += "JSON?username=" + user.Username;
            remoteString += "&email=" + user.Email;
            remoteString += "&password=" + password;
            remoteString += "&name=" + user.Name;

            HttpWebRequest request = new HttpWebRequest(new Uri(remoteString));
            request.ContentType = "application/json";
            request.Method = "POST";
            return request;
        }

        public static HttpWebRequest DeleteUser(User.User user)
        {
            String remoteString = RemoteUrl + "users/";
            remoteString += "JSON?id=" + user.UserId.ToString();

            HttpWebRequest request = new HttpWebRequest(new Uri(remoteString));
            request.ContentType = "application/json";
            request.Method = "DELETE";
            return request;
        }

        public static HttpWebRequest GetUser(int userId)
        {
            String remoteString = RemoteUrl + "users/";
            remoteString += "JSON?id=" + userId.ToString();

            HttpWebRequest request = new HttpWebRequest(new Uri(remoteString));
            request.ContentType = "application/json";
            request.Method = "POST";
            return request;
        }

        public static HttpWebRequest CreateCourse(Course course)
        {
            String remoteString = RemoteUrl + "course/";
            remoteString += "JSON?instructor_Id=" + course.CourseInstructor.ToString();
            remoteString += "description=" + course.Description;
            remoteString += "name=" + course.CourseName;

            HttpWebRequest request = new HttpWebRequest(new Uri(remoteString));
            request.ContentType = "application/json";
            request.Method = "DELETE";
            return request;
        }

        public static HttpWebRequest DeleteCourse(int courseId)
        {
            String remoteString = RemoteUrl + "course/";
            remoteString += "JSON?course_id=" + courseId.ToString();

            HttpWebRequest request = new HttpWebRequest(new Uri(remoteString));
            request.ContentType = "application/json";
            request.Method = "DELETE";
            return request;
        }

        public static HttpWebRequest AddStudentToCourse(int userId, int courseId)
        {
            String remoteString = RemoteUrl + "add_to_course/";
            remoteString += "JSON?student_id=" + userId.ToString();
            remoteString += "course_id=" + courseId.ToString();

            HttpWebRequest request = new HttpWebRequest(new Uri(remoteString));
            request.ContentType = "application/json";
            request.Method = "POST";
            return request;
        }

        public static HttpWebRequest RemoveStudentFromCourse(int userId, int courseId)
        {
            String remoteString = RemoteUrl + "remove_from_course/";
            remoteString += "JSON?student_id=" + userId.ToString();
            remoteString += "course_id=" + courseId.ToString();

            HttpWebRequest request = new HttpWebRequest(new Uri(remoteString));
            request.ContentType = "application/json";
            request.Method = "POST";
            return request;
        }

        public static HttpWebRequest GetCourse(int courseId)
        {
            String remoteString = RemoteUrl + "course_from_id/";
            remoteString += "JSON?course_id=" + courseId.ToString();

            HttpWebRequest request = new HttpWebRequest(new Uri(remoteString));
            request.ContentType = "application/json";
            request.Method = "POST";
            return request;
        }

        public static async void SendMessage(Message message)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(new Uri(RemoteUrl));
            request.ContentType = "application/json";
            request.Method = "GET";

            // Send the request to the server and wait for the response:
            using (WebResponse response = await request.GetResponseAsync())
            {
                // Get a stream representation of the HTTP web response:
                using (Stream stream = response.GetResponseStream())
                {
                    // Use this stream to build a JSON document object:
                    JsonValue jsonDoc = await Task.Run(() => JsonObject.Load(stream));
                    Console.Out.WriteLine("Response: {0}", jsonDoc.ToString());

                    //// Return the JSON document:
                    //return jsonDoc;
                }
            }
        }

        // Parse the weather data, then write temperature, humidity, 
        // conditions, and location to the screen.
        private static void ParseAndDisplay(JsonValue json)
        {
            // Extract the array of name/value results for the field name "weatherObservation". 
            JsonValue weatherResults = json["weatherObservation"];
            //// Extract the "stationName" (location string) and write it to the location TextBox:
            //location.Text = weatherResults["stationName"];

            //// The temperature is expressed in Celsius:
            //double temp = weatherResults["temperature"];
            //// Convert it to Fahrenheit:
            //temp = ((9.0 / 5.0) * temp) + 32;
            //// Write the temperature (one decimal place) to the temperature TextBox:
            //temperature.Text = String.Format("{0:F1}", temp) + "° F";

            //// Get the percent humidity and write it to the humidity TextBox:
            //double humidPercent = weatherResults["humidity"];
            //humidity.Text = humidPercent.ToString() + "%";

            //// Get the "clouds" and "weatherConditions" strings and 
            //// combine them. Ignore strings that are reported as "n/a":
            //string cloudy = weatherResults["clouds"];
            //if (cloudy.Equals("n/a"))
            //    cloudy = "";
            //string cond = weatherResults["weatherCondition"];
            //if (cond.Equals("n/a"))
            //    cond = "";

            //// Write the result to the conditions TextBox:
            //conditions.Text = cloudy + " " + cond;
        }

        public static String RemoteUrl { get; set; }
    }
}