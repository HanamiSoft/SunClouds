using SunClouds.ViewModel.Helpers;

namespace SunClouds.ViewModel
{
    internal class FeelingUCViewModel : BindingHelper
    {
        #region props
        private string textContent;

        public string TextContent
        {
            get { return textContent; }
            set { textContent = value; OnPropertyChanged(); }
        }
        private string dataContent;

        public string DataContent
        {
            get { return dataContent; }
            set { dataContent = value; OnPropertyChanged(); }
        }
        #endregion

        public FeelingUCViewModel(string textContent, string dataContent)
        {
            this.dataContent = dataContent;
            this.textContent = textContent;
        }
    }
}
