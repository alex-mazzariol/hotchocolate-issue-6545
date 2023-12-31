namespace HCSample;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public ICollection<Address> Addresses { get; set; } = default!;

    public User(int id, string name, string email)
    {
        Id = id;
        Name = name;
        Email = email;
    }
}

