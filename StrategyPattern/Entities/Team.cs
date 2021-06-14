using StrategyPattern.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Entities
{
    class Team
    {

        TeamStrategy _teamStrategy;

        public Team() { }
        public Team(TeamStrategy teamStrategy) => _teamStrategy = teamStrategy;

        public void SetStrategy(TeamStrategy teamStrategy)
        {
            _teamStrategy = teamStrategy;
        }

        public void PlayGame()
        {
            _teamStrategy.Play();
        }
    }
}
