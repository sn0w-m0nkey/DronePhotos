using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace Web.Data;

public class IcUserManager : UserManager<ApplicationUser>
{
    public IcUserManager(IUserStore<ApplicationUser> store, 
        IOptions<IdentityOptions> optionsAccessor, 
        IPasswordHasher<ApplicationUser> passwordHasher, 
        IEnumerable<IUserValidator<ApplicationUser>> userValidators, 
        IEnumerable<IPasswordValidator<ApplicationUser>> passwordValidators, 
        ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors, 
        IServiceProvider services, 
        ILogger<UserManager<ApplicationUser>> logger) 
        : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
    {
    }

    public override bool SupportsUserSecurityStamp => false;
}
