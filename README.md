# How to set conditional styling in code behind in MAUI DataGrid
This demo shows how to set conditional styling to DataGridRow in code behind in MAUI SfDataGrid.

You can define and apply the DataGridRow style in the code‑behind and use a value converter to update the row background based on your data object (for example, the IsDeleted property), as shown below:

 ```
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
 ```

