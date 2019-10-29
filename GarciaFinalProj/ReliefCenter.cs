using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarciaFinalProj
{
    class ReliefCenter {
        string nameReliefCenter;
        int packsReleased;
        List<ReliefGood> goods = new List<ReliefGood>();

        public ReliefCenter(string n) {
            nameReliefCenter = n;
        }

        public string AddNewGood(string n, int r, string u) {
            string output = "";

            if (FindGood(n) == null)
            {
                goods.Add(new ReliefGood(n,r,u));
                output = "Now accepting " + n + " at the rate of " + r + " " + u + " / pack. \n ------------------------------------------------------------------------------------------------------- \n";
            }

            else
                output = n + " already accepted. Cannot overwrite / duplicate. \n ------------------------------------------------------------------------------------------------------- \n";

            return output;
        }

        public ReliefGood FindGood(string g) {
            foreach (var item in goods)
            {
                if (item.GetName() == g)
                    return item;
            }
            return null;
        }

        public string GetName() {
            return nameReliefCenter;
        }

        public int GetPackCount() {
            return packsReleased;
        }        

        public string PrintInventory() {
            string output = "......... INVENTORY .........\n";
            output += "\nPacks Released: " + packsReleased + "\n";
            output += "\n ------------------------------------------------------------------------------------------------------- \n";

            foreach (var item in goods)
            {
                output += item.GetName() + ":   " + item.GetUnitsLeft() + " " + item.GetUnit() + "\n";
            }
            output += " ------------------------------------------------------------------------------------------------------- \n";
            return output;
        }

        public string RecieveGoods(string good, int num) {
            string output = "";

            foreach (var item in goods)
            {
                if (item.GetName() == good)
                {
                    item.AddGoods(num);
                    output = "Donation of " + num + " " + item.GetUnit() + " of " + good + " was recieved and much appreciated. \n ------------------------------------------------------------------------------------------------------- \n";
                    break;
                }

                else
                    output = good + " is not accepted. Please try another. \n ------------------------------------------------------------------------------------------------------- \n";
            }
            return output;
        }

        public string ReleasePacks(int num) {
            string output = "";

            bool enough = false;

            foreach (var item in goods)
            {
                if (item.GetUnitsLeft() < item.GetReleaseRate() * num)
                {
                    enough = false;
                    break;
                }

                else
                    enough = true;
            }

            if (enough == true)
            {
                foreach (var item in goods)
                {
                    for (int i = 0; i < num; i++)
                    {
                        item.ReleaseGoods();
                    }
                }
                output = "Successfully released " + num + " pack(s) \n ------------------------------------------------------------------------------------------------------- \n";
                packsReleased += num;
            }

            else
                output = "Insufficient supply. Click 'Print Inventory' to check. \n ------------------------------------------------------------------------------------------------------- \n";

            return output;
        }        
    }
}