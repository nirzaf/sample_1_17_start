namespace sample_1_17 {
  public class ListItem : ChangeableBase {
    string name;
    public string Name { get => name; set => SetProperty(ref name, value); }
    string category;
    public string Category { get => category; set => SetProperty(ref category, value); }
  }
}
