using Kiddypi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiddypi.Firebase
{
   public  class GetImages
    {

        public List<Images> GetImage()
        {

            var List = new List<Images>()
            { new Images
            { ImageName="Image1",
                ImageUrl ="URL",
              },
                new Images{
                ImageName ="Image1",
                ImageUrl ="URL" } };

            return List;
        }

    }
}
