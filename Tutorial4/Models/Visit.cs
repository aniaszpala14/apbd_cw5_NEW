using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;

namespace Tutorial4.Models;

public class Visit
{
    
    public int Id { get;}
    [Required]
    public int AnimalClientId { get; set; }
    
    [MaxLength(200)]
    public string ShortDescription { get; set; }
   
    public DateTime Date { get; set; }
    public double Cost { get; set; }
    private static int countvisits=0;

    public Visit(int animalClientId, string shortDescription,DateTime date,double cost)
    {
        countvisits += 1;
        this.Id = countvisits;
        this.AnimalClientId = animalClientId;
        this.ShortDescription = shortDescription;
        this.Date = date;
        this.Cost = cost;
    }
}