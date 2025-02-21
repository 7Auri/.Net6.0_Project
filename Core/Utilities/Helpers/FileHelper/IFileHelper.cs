﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helpers.FileHelper
{
   public interface IFileHelper
    {
        string Add(IFormFile file);
        string Update(IFormFile file, string oldFilePath);
        void Delete(string filePath);

    }
}
