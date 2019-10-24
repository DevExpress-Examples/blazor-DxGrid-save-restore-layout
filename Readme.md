<!-- default file list -->
*Files to look at*:

* [Index.razor](./CS/SaveRestoreDataGridLayout/Pages/Index.razor)
* [UserLayoutManager.cs](./CS/SaveRestoreDataGridLayout/Data/UserLayoutManager.cs)
<!-- default file list end -->

### Blazor Data Grid - How to save/load a grid's layout information

This example illustrates how to use the [LayoutChanged](link), [LayoutRestoring](link) events and the [SaveLayout](link) and [LoadLayout](link) methods to save layout information to some storage. After that this information can be restored and applied to DxDataGrid.

*Note: as this example illustrates a general approach, layout information is stored in the [UserLayoutManager](./CS/SaveRestoreDataGridLayout/Data/UserLayoutManager.cs) singleton service. This service doesn't identify the current end user.*

The [Index.razor](./CS/SaveRestoreDataGridLayout/Pages/Index.razor) page contains two DxDataGrids.

* The first grid handles the [LayoutChanged](link) and [LayoutRestoring](link) events. The current layout information is stored in the singleton service and is restored from this service inside these event handlers. So end-user modifications (paging/sorting/grouping/filtering) will be restored automatically after a page reload.
* The second grid saves and loads layout information using external buttons where the [SaveLayout](link) and [LoadLayout](link) methods are called. Click the "Save current layout" button to save the current layout information. The corresponding item will be created in the external list box. Then select any item in this list box and click the "Load layout" button to load the corresponding layout information.