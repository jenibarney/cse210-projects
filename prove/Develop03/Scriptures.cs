using System.Transactions;

public class Scripture
{
    private Reference _reference = new Reference("John", "3", "16");

    public void CreateNewReference(string book, string chapter, string verse)
    {
        Reference reference1 = new Reference(book, chapter, verse);

    }


}
