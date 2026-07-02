# How to set conditional styling in code behind in MAUI DataGrid

In this article, we will show you how to apply conditional row styling in Syncfusion .NET MAUI DataGrid (`SfDataGrid`) using code-behind. Conditional styling enables you to dynamically customize the appearance of DataGrid rows based on the values of the underlying data objects. This technique is particularly useful for highlighting records that require attention, such as deleted items, inactive records, overdue orders, validation failures, or status-based business rules.

In this sample, a `Style` for `DataGridRow` is created programmatically and added to the page resources during initialization. The row background color is determined through a value converter (`IsDeletedToColorConverter`) that evaluates the bound data object and returns the appropriate color. By defining the style in code-behind, developers can create and modify DataGrid styling dynamically at runtime without relying solely on XAML resources.

## xaml

```xml
<ContentPage.BindingContext>
    <local:OrderInfoRepository />
</ContentPage.BindingContext>

<syncfusion:SfDataGrid
    ItemsSource="{Binding OrderInfoCollection}">
</syncfusion:SfDataGrid>
```

The DataGrid is bound to the `OrderInfoCollection` exposed by the `OrderInfoRepository`. All records in the collection are displayed automatically, while the row appearance is customized through a style that is added programmatically in the page constructor.

## C#

The following code creates a `DataGridRow` style and applies conditional formatting to each row using a converter.

```csharp
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
```

The `BackgroundProperty` of the `DataGridRow` is bound to the current data item using `"."` as the binding source. The `IsDeletedToColorConverter` evaluates the record and returns the appropriate background color based on the business condition. As a result, rows are automatically styled whenever they are rendered in the DataGrid.

## How Conditional Row Styling Works

The styling process consists of the following steps:

1. Create a `Style` targeting `DataGridRow`.
2. Define a setter for the row background property.
3. Bind the setter value to the entire data object.
4. Use a value converter to evaluate record properties.
5. Return different colors based on the condition.
6. Add the style to the page resources so it is automatically applied to all rows.

For example, a converter can return a red background for deleted records and a transparent background for active records.

```csharp
public object Convert(object value, Type targetType,
    object parameter, CultureInfo culture)
{
    var record = value as OrderInfo;

    if (record != null && record.IsDeleted)
        return Colors.LightCoral;

    return Colors.Transparent;
}
```

## Benefits of Code-Behind Styling

- Apply row styles dynamically at runtime.
- Highlight records based on business rules.
- Improve data readability and user experience.
- Separate styling logic through reusable converters.
- Easily support status-based, validation-based, or condition-based formatting.
- Avoid manually styling individual records.

## Common Use Cases

- Highlight deleted or inactive records.
- Indicate high-priority items.
- Display overdue tasks or orders.
- Mark rows with validation errors.
- Color-code records based on status values.
- Emphasize rows that meet specific business conditions.

##### Conclusion

I hope you enjoyed learning about how to apply conditional row styling in code-behind using .NET MAUI DataGrid (SfDataGrid).

You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. 

For current customers, you can check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components.
 
If you have any queries or require clarifications, please let us know in the comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or the feedback portal. We are always happy to assist you!