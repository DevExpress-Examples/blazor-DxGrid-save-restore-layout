<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/217318326/23.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T826240)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Grid for Blazor - Save and load layout information

The DevExpress Blazor [Grid](https://docs.devexpress.com/Blazor/403143/grid) allows you to save layout information between application sessions. This example demonstrates two different approaches to how to save and restore a grid layout:


* Handle the Grid's [LayoutAutoSaving](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.LayoutAutoSaving) and [LayoutAutoLoading](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.LayoutAutoLoading) events to automatically save and restore the grid layout. On the [Auto.razor](./CS/SaveAndRestoreLayout/SaveAndRestoreLayout/Pages/Auto.razor) page, the Grid saves the current layout information to the [local storage](https://developer.mozilla.org/en-US/docs/Web/API/Window/localStorage) once the layout changes. When the page reloads, the Grid restores the saved layout.

    ![The Auto.razor page](images/save-restore-layout-automatically.gif)

* Call the Grid's [SaveLayout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SaveLayout) and [LoadLayout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.LoadLayout(DevExpress.Blazor.GridPersistentLayout)) methods to save and restore the grid layout on demand. On the [API.razor](./CS/SaveAndRestoreLayout/SaveAndRestoreLayout/Pages/API.razor) page, the Grid saves the current layout information after a user clicks the **Save current layout** button. A List Box to the right of the Grid displays all saved layout items. When a user selects an item in the List Box and clicks the **Load layout** button, the Grid restores the selected layout.

    ![The API.razor page](images/save-restore-layout-manually.gif)

## Files to Review

- [Auto.razor](./CS/SaveAndRestoreLayout/SaveAndRestoreLayout/Pages/Auto.razor)
- [API.razor](./CS/SaveAndRestoreLayout/SaveAndRestoreLayout/Pages/API.razor)

## Documentation

* [GridPersistentLayout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.LoadLayout(DevExpress.Blazor.GridPersistentLayout))
* [LayoutAutoSaving](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.LayoutAutoSaving)
* [LayoutAutoLoading](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.LayoutAutoLoading)
* [SaveLayout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SaveLayout)
* [LoadLayout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.LoadLayout(DevExpress.Blazor.GridPersistentLayout))
