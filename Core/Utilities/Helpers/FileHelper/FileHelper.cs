﻿using Core.Constants;
using Core.Exceptions.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;

namespace Core.Utilities.Helpers.FileHelper
{
    public class FileHelper : IFileHelper
    {
        static string _basePath = Directory.GetCurrentDirectory() + "/wwwroot/";
        static string _imageFolder = "images/";
        string _fullPath = _basePath + _imageFolder;

        public string Add(IFormFile file)
        {
            CreateDirectory(_fullPath);

            var fileExtension = Path.GetExtension(file.FileName);
            CheckImage(fileExtension);

            var imagePath = _imageFolder + Guid.NewGuid().ToString() + fileExtension;

            CreateFile(file, _basePath + imagePath);

            return imagePath;
        }

        public void Delete(string filePath)
        {
            File.Delete(_basePath + filePath);
        }

        public string Update(IFormFile file, string oldFilePath)
        {
            Delete(oldFilePath);
            return Add(file);
        }

        private void CheckImage(string extension)
        {
            var extensions = new List<string> { ".jpg", ".png", "jpeg" };

            if (!extensions.Contains(extension))
                throw new FileHelperCustomException(Messages.UnsupportedFileType);
        }

        private void CreateDirectory(string path)
        {
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
        }

        private void CreateFile(IFormFile file, string path)
        {
            using (FileStream fileStream = File.Create(path))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();
            }
        }
    }
}