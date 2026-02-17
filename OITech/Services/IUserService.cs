using OITech.Models.Request;
using OITech.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OITech.Services
{
    public interface IUserService
    {
        UserResponse Auth(AuthRequest model); 
    }
}
