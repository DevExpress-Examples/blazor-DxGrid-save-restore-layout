<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/217318326/22.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T826240)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->

# Grid for Blazor - Save and load layout information

The DevExpress [Grid](https://docs.devexpress.com/Blazor/403143/grid) for Blazor allows you to save its layout between application work sessions. This example demonstrates how to save layouts automatically and by API. The [Grid.razor](./SaveAndRestoreLayout/SaveAndRestoreLayout/Pages/Grid.razor) page contains two tab pages with Grid components:

* The first Grid handles the [LayoutAutoSaving][https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.LayoutAutoSaving] and [LayoutAutoLoading][https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.LayoutAutoLoading] events. The current layout information is saved to [local storage](https://developer.mozilla.org/en-US/docs/Web/API/Window/localStorage). User modifications (paging, sorting, grouping, and filtering) are restored automatically after a page reload.

* The second Grid saves and loads layout information on button clicks that call the [SaveLayout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SaveLayout) and [LoadLayout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.LoadLayout(DevExpress.Blazor.GridPersistentLayout)) methods. The **Save current layout** button click saves the current layout information. The corresponding layout item appears in the external List Box. Users can select any item in the editor box and click the **Load layout** button to load layout information. 

![App sample](images/dxgrid-save-restore-layout.png)

## Files to Look At

- [Grid.razor](./CS/SaveAndRestoreLayout/SaveAndRestoreLayout/Pages/Grid.razor)

## Documentation

* [GridPersistentLayout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.LoadLayout(DevExpress.Blazor.GridPersistentLayout))
* [LayoutAutoSaving][https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.LayoutAutoSaving]
* [LayoutAutoLoading][https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.LayoutAutoLoading]
* [SaveLayout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SaveLayout)
* [LoadLayout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.LoadLayout(DevExpress.Blazor.GridPersistentLayout))
