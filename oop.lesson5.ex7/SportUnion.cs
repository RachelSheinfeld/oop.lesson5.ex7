using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.lesson5.ex7
{
    internal class SportUnion
    {
        string unionName;
        SportClube[] s1 = new SportClube[100];
        int numOfUnion;
        #region get and set
        public int getNumOfUnion()
        {
            return numOfUnion;
        }
        public SportClube[] getuniondata()
        {
            return s1 ;
        }
        public string getunionName() { return unionName; }  
        #endregion
        #region function
        public bool joinClub(SportClube club)
        {
            for (int i = 0; i < s1.Length; i++)
                if (club.GetName() == s1[i].GetName() && club.GetCity() == s1[i].GetCity() && club.GetsportName() == s1[i].GetsportName())
                    return false;
            s1[numOfUnion] = club;
            return true;
        }

        public string maxCoach()
        {
            int max = s1[0].GetCountOfCoach();
            string nameMax = s1[0].GetName();
            for (int i = 1; i < s1.Length; i++)
            {
                if (s1[i].GetCountOfCoach() > max)
                {
                    max = s1[i].GetCountOfCoach();
                    nameMax = s1[i].GetName();
                }
            }
            return nameMax;


        }
        #endregion
    }
}
