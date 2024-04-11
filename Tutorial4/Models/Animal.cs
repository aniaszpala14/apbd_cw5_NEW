namespace Tutorial4.Models;

public class Animal
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string Category { get; set; }
    public double Weight { get; set; }
    public string FurColour { get; set; }
   private static int idcount = 0;

   public Animal(string firstName, string category, double weight, string furColour)
  {
    this.Id = idcount++;
    this.FirstName = firstName;
    this.Category = category;
    this.Weight = weight;
    this.FurColour = furColour;
   }
}