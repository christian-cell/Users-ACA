using UsersACA.Services.Abstractions;

namespace UsersACA.Services.Services
{
    public class UsersService: IUsersService
    {
        public string GreatPeople()
        {
            return "hola que asee desde el servicio";
        }
    }
};

