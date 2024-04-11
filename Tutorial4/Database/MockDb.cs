using System.Runtime.InteropServices.JavaScript;
using Tutorial4.Models;

namespace Tutorial4.Database;

public class MockDb
{
    public List<Animal> Animals { get; set; } = new List<Animal>();
    public List<Visit> Visits { get; set; } = new List<Visit>();
    private static MockDb instance;

    public MockDb()
    {
       
        Animals.Add(new Animal("Filo","Cat",3.5,"black"));
        Animals.Add(new Animal("Felcia","Cat",2.5,"grey"));
        Animals.Add(new Animal("Eden","Dog",24.5,"black&brown"));
        Animals.Add(new Animal("Kreska","Dog",22.0,"beige"));
        
        Visits.Add(new Visit(1, "Casual Check", new DateTime(2022, 03, 04), 120.0));
        Visits.Add(new Visit(2, "Injection", new DateTime(2013, 12, 23), 100.0));
        Visits.Add(new Visit(2, "Injection2", new DateTime(2013, 12, 24), 100.0));
        Visits.Add(new Visit(3, "Tumor removal", new DateTime(2023, 06, 11), 330.0));
    }

    public static MockDb getInstance()
    {
        if (instance == null)
        {
            instance = new MockDb();
        }

        return instance;
    }
}