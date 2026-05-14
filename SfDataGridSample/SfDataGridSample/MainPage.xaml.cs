using Syncfusion.Maui.Core.Carousel;
using Syncfusion.Maui.DataGrid;

namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            AddRowStyle();
        }

        private void AddRowStyle()
        {
            var rowStyle = new Style(typeof(DataGridRow))
            {
                Setters =
                {
                    new Setter
                    {
                        Property = DataGridRow.BackgroundProperty,
                        Value = new Binding(".", converter: new IsDeletedToColorConverter())
                    }
                }
            };

            Resources.Add(rowStyle);
        }
    }
}