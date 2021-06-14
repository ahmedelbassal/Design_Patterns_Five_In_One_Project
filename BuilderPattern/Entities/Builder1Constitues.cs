using BuilderPattern.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Entities
{
    
    class Builder1Constitues : Builders
    {
        private Ground _Ground = new Ground("Flat");


        public override void BuildAudience()
        {
            _Ground.AddConstitute("Audience Constitue of builder 1");
        }

        public override void BuildGallery()
        {
            _Ground.AddConstitute("Gallery Constitue of builder 1");

        }

        public override void BuildGroundSurface()
        {
            _Ground.AddConstitute("Ground Surface Constitue of builder 1");
        }

        public override Ground GetGround()
        {
            return _Ground;
        }
    }
}
