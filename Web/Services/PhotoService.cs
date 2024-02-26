namespace Web.Services;

public interface IPhotoService
{
    public string Test();
}

public class PhotoService : IPhotoService
{
    public string Test()
    {
        return "TODO: load photos";
    }
}
