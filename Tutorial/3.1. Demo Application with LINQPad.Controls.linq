<Query Kind="Program">
  <Namespace>LINQPad.Controls</Namespace>
</Query>

/// <summary>
///     The following application acts as a simple file browser, allowing you to browse between folders and view files within LINQPad's dump window.
///     The following application uses LINQPad's built-in UI Controls namespace.
/// </summary>

string currentDirectory = string.Empty;
Label currentDirLabel = new Label();
SelectBox directoryList = new SelectBox(SelectBoxKind.ListBox);
DumpContainer fileVisualizer = new DumpContainer();
Button viewButton = new Button("View File");
volatile FieldSet errorSet = new FieldSet("Error", new Label("Can only visualize files."));

void Main()
{
    WireUpUI();
    
    errorSet.Visible = false;
    new WrapPanel(directoryList, fileVisualizer).Dump();
    new WrapPanel(new FieldSet("Controls", viewButton, currentDirLabel)).Dump();
    new WrapPanel(errorSet).Dump();
}

void WireUpUI()
{
    var startingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
    
    directoryList.SelectionChanged += HandleDirectoryTraversal;
    PopulateListWithDirectory(startingDirectory);
    
    viewButton.Click += HandleViewButton;
}

void HandleDirectoryTraversal(object sender, EventArgs e)
{
    string option = (string)directoryList.SelectedOption;
    if (option == "..")
    {
        PopulateListWithDirectory(Path.GetFullPath(Path.Combine(currentDirectory, "..")));
        return;
    }
    
    if (Directory.Exists(option))
    {
        PopulateListWithDirectory(option);
    }
}

void HandleViewButton(object sender, EventArgs e)
{
	if (directoryList.SelectedOption == null)
	{
		return;
	}
	
    var selectedFilePath = directoryList.SelectedOption.ToString();
    
    if (File.Exists(selectedFilePath))
    {
        var fileContent = File.ReadAllBytes(selectedFilePath);
        var fileString = Encoding.Default.GetString(fileContent);
        fileVisualizer.Content = new TextArea(fileString);
    }
    else
    {
        errorSet.Visible = true;

        new Thread(() => {
            Thread.Sleep(2500);
            errorSet.Visible = false;
        }).Start();
    }
}

void PopulateListWithDirectory(string directory)
{
    currentDirectory = directory;
    currentDirLabel.Text = $"Current Directory: {currentDirectory}";
    directoryList.Options = new[] {".."}.Concat(Directory.EnumerateFileSystemEntries(directory)).ToArray();
}

