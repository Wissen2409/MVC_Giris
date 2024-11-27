
// modal olarak bir öğrenci nesnesi belirledik!!
public class Ogrenci
{

    public int Id { get; set; }
    public string Name { get; set; }
}
public class Ogretmen{

    public int Id { get; set; }
    public string Name { get; set; }
}

public class GeneralModel{

    public List<Ogrenci> Ogrenci { get; set; }
    public List<Ogretmen> Ogretmen{ get; set; }

}