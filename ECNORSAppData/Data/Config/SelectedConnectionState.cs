namespace ECNORSAppData.Data.Config;

public class SelectedConnectionState
{
    public string? SelectedName { get; private set; }

    public string? GetSelectedName() => SelectedName;

    public void SetSelectedName(string name) => SelectedName = name;
}
