using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaveRestoreDataGridLayout.Data
{
    public class UserLayoutManager
    {
        protected string CurrentLayout { get; set; } = string.Empty;
        readonly Dictionary<string, string> _layoutsDictionary = new Dictionary<string, string>();
        public string GetCurrentLayout() => CurrentLayout;
        public void UpdateCurrentLayout(string layout) {
            if (CurrentLayout != layout) {
                CurrentLayout = layout;
            }
        }
        public IEnumerable<string> GetKeyList() => _layoutsDictionary.Keys;
        public string GetLayoutByKey(string key) => _layoutsDictionary.GetValueOrDefault(key);
        public void AddLayout(string layout, string key) => _layoutsDictionary.Add(key, layout);
        public void RemoveLayout(string key) => _layoutsDictionary.Remove(key);
    }
}
