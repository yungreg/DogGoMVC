using DogGo.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace DogGo.Repositories
{
    public interface IOwnerRepository
    {
        // update to include AddOwner, UpdateOwner and DeleteOwner methods.
        List<Owner> GetAllOwners();
        Owner GetOwnerById(int id);
        //could this be a variable instead of a list?
        public void AddOwner(Owner owner);
 
        //Owner UpdateOwner(Owner owner);

        public void DeleteOwner(int id);

    }

}
