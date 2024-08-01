namespace BlazorDapp.Services.Services;

public class MyService : IMyService
{
   public List<string> Names { get; set; } = new();
    public void AddName(string name)
    { 
        Names.Add(name); 
    }

    public MyService() 
    {  
        AddName("Adeola Tolu");
        AddName("Philip Brook");
        AddName("Nerve Jonas");
    }

}


