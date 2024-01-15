using Project.BLL.Abstract;
using Project.DAL.Abstract;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Concretes
{
    public class ImageManager:BaseManager<Image>,IImageManager
    {
        IImageRepositoryDal _imageRep;

        public ImageManager(IImageRepositoryDal imageRep) :base(imageRep) 
        {
           _imageRep = imageRep;
        }
    }
}
