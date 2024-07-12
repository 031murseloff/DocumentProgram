using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;

namespace DocumentApp;

public  class DocumentProgram
{

    public void OpenDocument()
    {
        Console.WriteLine("Document Opened");
    }

    public virtual void EditDocument()
    {
        Console.WriteLine("Can Edit in Pro and Expert versions");
    }

    public virtual void SaveDocument()
    {
        Console.WriteLine("Can Save in Pro and Expert versions");
    }
 


}
