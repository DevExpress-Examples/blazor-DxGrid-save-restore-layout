<!-- default file list -->
*Files to look at*:

* [Index.razor](./CS/SaveRestoreDataGridLayout/Pages/Index.razor)
* [UserLayoutManager.cs](./CS/SaveRestoreDataGridLayout/Data/UserLayoutManager.cs)
<!-- default file list end -->

### Blazor Data Grid - How to save/load a grid's layout information

This example illustrates how to use the [LayoutChanged][0], [LayoutRestoring][1] events and the [SaveLayout][2] and [LoadLayout][3] methods to save layout information to some storage. After that this information can be restored and applied to DxDataGrid

*Note: as this example illustrates a general approach, layout information is stored in the [UserLayoutManager](./CS/SaveRestoreDataGridLayout/Data/UserLayoutManager.cs) singleton service. This service doesn't identify the current end user.*

The [Index.razor](./CS/SaveRestoreDataGridLayout/Pages/Index.razor) page contains two DxDataGrids.

* The first grid handles the [LayoutChanged][0] and [LayoutRestoring][1] events. The current layout information is stored in the singleton service and is restored from this service inside these event handlers. So end-user modifications (paging/sorting/grouping/filtering) will be restored automatically after a page reload.
* The second grid saves and loads layout information using external buttons where the [SaveLayout][2] and [LoadLayout][3] methods are called. Click the "Save current layout" button to save the current layout information. The corresponding item will be created in the external list box. Then select any item in this list box and click the "Load layout" button to load the corresponding layout information.

[0]: https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.LayoutChanged
[1]: https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.LayoutRestoring
[2]: https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.SaveLayout
[3]: https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.LoadLayout(System.String)
