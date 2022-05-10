using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace sample_1_17 {
  public abstract class ChangeableBase : INotifyPropertyChanged {
    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged(string propertyName) =>
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    protected void SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null,
      IList<string> extraProps = null) {
      if (EqualityComparer<T>.Default.Equals(field, value)) return;
      field = value;
      OnPropertyChanged(propertyName);
      if (extraProps != null)
        foreach (var p in extraProps)
          OnPropertyChanged(p);
    }
  }
}
