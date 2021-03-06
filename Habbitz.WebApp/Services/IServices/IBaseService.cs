using Habbitz.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Habbitz.WebApp.Services.IServices
{
    public interface IBaseService : IDisposable
    {
        ResponseDto responseModel { get; set; }
        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}
