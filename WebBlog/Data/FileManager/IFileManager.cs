using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace WebBlog.Data.FileManager
{
    public interface IFileManager
    {
        Task<string> SaveImage(IFormFile image);
    }
}
