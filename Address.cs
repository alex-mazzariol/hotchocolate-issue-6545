namespace HCSample;

public class Address
{
    public int Id { get; set; }
    public string CityName { get; set; }

    public Address(int id, string cityName)
    {
        Id = id;
        CityName = cityName;
    }
}

