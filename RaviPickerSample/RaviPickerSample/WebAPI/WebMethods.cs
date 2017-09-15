using System;
using System.Diagnostics;
using Newtonsoft.Json;
using RestSharp;

namespace RaviPickerSample.WebAPI
{
    public class WebMethods
    {
		/* Get Security Questions API*/
		public string securityQuestionsResponse { get; set; }

		public event SecurityQuestionsEventHandler securityQuestionsEvent;

		public delegate void SecurityQuestionsEventHandler(WebMethods sender, EventArgs e);

		public void GetSecurityQuestions()
		{
			var client = new RestClient(ConstantsFile.UriSecurityQuestions);

			var request = new RestRequest(Method.GET);
			client.ExecuteAsync(request, response =>
			{
				Debug.WriteLine("Security Questions Response " + response.Content);
				this.securityQuestionsResponse = response.Content;
				securityQuestionsEvent(this, new EventArgs());
			});
		}
    }
}
