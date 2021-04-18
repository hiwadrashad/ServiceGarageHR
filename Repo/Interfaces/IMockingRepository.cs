using Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repo.Interfaces
{
    public interface IMockingRepository
    {
        List<ServiceModel> ReturnValues();
        bool AddValue(ServiceModel model);
        bool Empty();
    }
}
