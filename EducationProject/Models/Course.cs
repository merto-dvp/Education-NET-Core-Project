using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EducationProject.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Duration { get; set; }
        public string ThumbnailUrl { get; set; }
        public string VideoUrl { get; set; }
        public string Description { get; set; }
        public string Trainer { get; set; }
        public string DetailDescription { get; set; }
        public string VidCategory { get; set; }
        public bool IsDeleted { get; set; }
       


        //public int rating { get; set; }
        public interface IFormFile
        {
            string ContentType { get; }
            string ContentDisposition { get; }
            IHeaderDictionary Headers { get; }
            long Length { get; }
            string Name { get; }
            string FileName { get; }
            Stream OpenReadStream();
            void CopyTo(Stream target);
            Task CopyToAsync(Stream target);
        }
        
       
        [NotMapped]
        public bool IsDele { get; set; }
        [NotMapped]
        public bool IsPurchased { get; set; }




    }
   
    
}
