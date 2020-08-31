using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementApp.Application.Common.Interfaces
{
    public interface ICurrentUserService
    {
        public string UserId { get; }
    }
}
