using AngularGoogleLoginExampleAPI.ViewModels;

namespace AngularGoogleLoginExampleAPI.Services.Abstractions
{
    public interface ITokenHandler
    {
        Token CreateAccessToken(int minute);
    }
}
