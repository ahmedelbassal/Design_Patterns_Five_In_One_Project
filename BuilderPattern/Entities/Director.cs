using BuilderPattern.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Entities
{
    class Director
    {
        public void Construct(Builders builder)
        {
            builder.BuildGallery();
            builder.BuildGroundSurface();
            builder.BuildAudience();
        }
    }
}
