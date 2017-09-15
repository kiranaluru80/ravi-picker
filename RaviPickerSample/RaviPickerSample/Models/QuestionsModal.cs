using System;
using System.Collections.Generic;
namespace RaviPickerSample.Models
{
    public class QuestionsModal
    {
		public class Question
		{
			public int Id { get; set; }
			public string Text { get; set; }
		}


		public class RootObject
		{
			public List<Question> Questions { get; set; }
			// public Question[] questionsaaray { get; set; }
		}
    }
}
