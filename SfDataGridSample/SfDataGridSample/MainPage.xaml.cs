using Syncfusion.Maui.Core.Carousel;
using Syncfusion.Maui.DataGrid;

namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public OrderInfoRepository? OrderInfo { get; set; }

        public MainPage()
        {
            InitializeComponent();

            //BindingContext = new OrderInfoRepository();
            //var dataGrid = new SfDataGrid();
            //dataGrid.SetBinding(SfDataGrid.ItemsSourceProperty, new Binding(nameof(OrderInfoRepository.OrderInfoCollection)));
            //Content = dataGrid;

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