
using DocumentApp;
using DocumentApp.CustomerException;






    class Program
    {

    delegate void OpenDocumentDelegate();
    delegate void EditDocumentDelegate();
    delegate void SaveDocumentDelegate();
    static void Main(string[] args)
        {
            Console.Write("Enter the keyword:\n 1. Basic\n 2. Pro\n 3. Expert\n Keyword: ");
            int keyWord = int.Parse(Console.ReadLine());
           

            DocumentProgram docProgram;

            switch (keyWord)
            {
                case 1:
                    docProgram = new DocumentProgram();
                    break;
                case 2:
                    docProgram = new ProDocumentProgram();
                    break;
                case 3:
                    docProgram = new ExpertDocumentProgram();
                    break;
                default:
                    Console.WriteLine("Invalid keyword");
                    return;
            }

       
        OpenDocumentDelegate openDelegate= new OpenDocumentDelegate(docProgram.OpenDocument);
        EditDocumentDelegate editDelegate = new EditDocumentDelegate(docProgram.EditDocument);
        SaveDocumentDelegate saveDelegate = new SaveDocumentDelegate(docProgram.SaveDocument);

            
            openDelegate();
            editDelegate();
            saveDelegate();
        }
      



}