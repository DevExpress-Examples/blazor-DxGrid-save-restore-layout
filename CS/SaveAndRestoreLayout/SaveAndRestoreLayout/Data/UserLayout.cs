using DevExpress.Blazor;

namespace SaveAndRestoreLayout.Data {
    public class UserLayout {
        public string LayoutKey { get; set; }
        public GridPersistentLayout Layout { get; set; }
    }
}
