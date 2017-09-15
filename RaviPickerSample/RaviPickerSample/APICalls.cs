using System;
using System.Collections.Generic;
using RaviPickerSample.WebAPI;

namespace RaviPickerSample
{
    public class MajorGroup
	{
		public int MajorGrupId { get; set; }
		public string majorGroupName { get; set; }
	}


	public List<MajorGroup> majorGroupResponce;

	public static List<MajorGroup> GetMajorGroupdData()
	{

		WebMethods webAPI = new WebMethods();
		webAPI.GetSecurityQuestions();
		webAPI.securityQuestionsEvent += ((WebMethods webAPISender, EventArgs e2) =>
		{
			Device.BeginInvokeOnMainThread(() =>
			{
				Debug.WriteLine(webAPISender.securityQuestionsResponse);

				QuestionsModal.RootObject questionsData = SimpleJson.DeserializeObject<QuestionsModal.RootObject>(webAPI.securityQuestionsResponse);

				foreach (QuestionsModal.Question questionTextAndId in questionsData.Questions)
				{
					Debug.WriteLine("Question:" + questionTextAndId.Text + "id" + questionTextAndId.Id);
					majorGroupResponce.Items.Add(questionTextAndId.Text);
				}
			});
		});
		return majorGroupResponce;
	}



    public class APICalls
    {
        public APICalls()
        {
        }


    }
}
