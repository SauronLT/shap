using Fashion.Contexts;
using Fashion.Exceptions;
using Fashion.Models;

namespace Fashion.Services;

public class MalServic
{
    private readonly AppDbContext _DbContext;
    public MalServic()
    {
        _DbContext = new AppDbContext();
    }

    public List<Mal> GetAllMals()
    {
        List<Mal> Mals = _DbContext.Mals.ToList();
        return Mals;
    }
    public Mal GetMalById(int id)
    {
        Mal mal = _DbContext.Mals.Find(id);
        if (mal is not null)
        { return mal; }
        throw new MalException($"adam ol ae {id}- nedi");


    }
    public void CreateMal(Mal mal)
    {
        _DbContext.Mals.Add(mal);
        _DbContext.SaveChanges();
    }
    public void updateMal(int Id, Mal mal)
    {
        if(Id != mal.Id)
        { throw new MalException($"adam ol ae {Id}- nedi"); }
        Mal? mall = _DbContext.Mals.Find(mal.Id);
        if (mall is null)
        
            mall.Name = mal.Name;
            mall.ImageUrl = mal.ImageUrl;
            mall.Price = mal.Price;
            _DbContext.SaveChanges();
        
        
       
    }
    public void DeleteMal(int Id)
    {
        Mal? mal = _DbContext.Mals.Find(Id);
        if (mal is null)
        { throw new MalException($"adam ol ae {Id}- nedi"); }
        _DbContext.Mals.Remove(mal);
        _DbContext.SaveChanges();
    }
}
