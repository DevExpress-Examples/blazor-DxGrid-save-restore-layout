<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/217318326/22.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T826240)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->

# Grid for Blazor - Save and load layout information

This example illustrates how to use the [LayoutAutoSaving][0] and [LayoutAutoLoading][1] events, and the [SaveLayout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SaveLayout) and [LoadLayout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.LoadLayout(DevExpress.Blazor.GridPersistentLayout)) methods to save layout information to storage. This information can be restored and applied to the DxGrid component. 

![App sample](images/dxgrid-save-restore-layout.png)

This example also illustrates the capability of the [GridPersistentLayout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.LoadLayout(DevExpress.Blazor.GridPersistentLayout)) class to modify the saved layout.

The [Grid.razor](./SaveAndRestoreLayout/SaveAndRestoreLayout/Pages/Grid.razor) page contains two DxGrid components:

* The first Grid handles the **LayoutAutoSaving** and **LayoutAutoLoading** events. The singleton service stores the current layout information and restores it in event handlers. User modifications (paging, sorting, grouping, and filtering) are restored automatically after a page reload. In the LayoutAutoLoading event, the group index is excluded from the list of saved column layout settings.

* The second Grid saves and loads layout information on button clicks that call the [SaveLayout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SaveLayout) and [LoadLayout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.LoadLayout(DevExpress.Blazor.GridPersistentLayout)) methods. Click the **Save current layout** button to save the current layout information. When the Grid's layout is saved, the column's sort index is excluded from the list of saved column layout settings. The corresponding layout item appears in the external List Box. Select any item in editor box and click the **Load layout** button to load layout information. 

This example illustrates a general approach: layout information stored in the [UserLayoutManager.cs](./SaveAndRestoreLayout/SaveAndRestoreLayout/Data/UserLayoutManager.cs) singleton service does not identify the current user.


## Files to Look At

- [Grid.razor](./SC/SaveAndRestoreLayout/SaveAndRestoreLayout/Pages/Grid.razor)
- [UserLayoutManager.cs](./SC/SaveAndRestoreLayout/SaveAndRestoreLayout/Data/UserLayoutManager.cs) 

## Documentation

* [GridPersistentLayout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.LoadLayout(DevExpress.Blazor.GridPersistentLayout))
* [SaveLayout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SaveLayout)
* [LoadLayout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.LoadLayout(DevExpress.Blazor.GridPersistentLayout))
