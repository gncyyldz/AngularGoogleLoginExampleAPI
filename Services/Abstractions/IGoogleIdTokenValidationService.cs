using AngularGoogleLoginExampleAPI.ViewModels;

namespace AngularGoogleLoginExampleAPI.Services.Abstractions
{
    public interface IGoogleIdTokenValidationService
    {
        public Task<Token> ValidateIdTokenAsync(GoogleLoginVM model);
    }
}
