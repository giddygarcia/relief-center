using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarciaFinalProj
{
    class ReliefGood {
        string nameReliefGood;
        int releaseRate;
        string unitOfMeasurement;
        int supply;

        public ReliefGood(string n, int r, string u) {
            nameReliefGood = n;
            releaseRate = r;
            unitOfMeasurement = u;
        }

        public void AddGoods(int num) {
            supply += num;
        }

        public string GetName() {
            return nameReliefGood;
        }

        public int GetReleaseRate() {
            return releaseRate;
        }

        public string GetUnit() {
            return unitOfMeasurement;
        }

        public int GetUnitsLeft() {
            return supply;
        }

        public void ReleaseGoods() {
            supply -= releaseRate;
        }
    }
}