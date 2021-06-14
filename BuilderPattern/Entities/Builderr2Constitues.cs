using BuilderPattern.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Entities
{
    class Builderr2Constitues : Builders
    {
        private Ground _Ground = new Ground("Rounded");


        public override void BuildAudience()
        {
            _Ground.AddConstitute("Audience Constitue of builder 2");
        }

        public override void BuildGallery()
        {
            _Ground.AddConstitute("Gallery Constitue of builder 2");

        }

        public override void BuildGroundSurface()
        {
            _Ground.AddConstitute("Ground Surface Constitue of builder 2");
        }


        public override Ground GetGround()
        {
            return _Ground;
        }
    }
}
