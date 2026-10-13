public class Person
{
   public string Firstname;
   public string Lastname;
   public string Adrres;
   public int age;
   public string GetFullname()
    {
        return $"{Firstname} {Lastname}";
    }
    public int GetBirth()
    {
        return 2026-age;
    }
}