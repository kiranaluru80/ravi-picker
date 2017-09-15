using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using RaviPickerSample.WebAPI;
using Xamarin.Forms;

namespace RaviPickerSample
{
    public class RaviPickerSamplePageViewModal : ViewModelBase
    {
       // public List<string> Countries => countries;
        public List<MajorgroupModel> Majorgroups => majorgroups;
        // countries = offlineData;

        APICalls obj = new APICalls();


        majorgroups  = obj.getMajorGroupdData();

		List<string> countries = new List<string>
		{
		"Afghanistan",
		"Albania",
		"Algeria",
		"Andorra",
		"Angola",
		};


		string selectedCityName;
		public string SelectedCityName
		{
			get { return selectedCityName; }
			set
			{
				if (selectedCityName != value)
				{
					selectedCityName = value;
					OnPropertyChanged();
					OnPropertyChanged("SelectedCity");
				}
			}
		}



		string userName;
		public string UserName
		{
			get { return userName; }
			set
			{
				if (userName != value)
				{
					userName = value;
					OnPropertyChanged();
					OnPropertyChanged("SelectedCity");
				}
			}
		}


	}
}
