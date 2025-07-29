using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Referencia.MonstruoMon
{
    public static class MonstruomonService
    {
        public static List<Attack> getAttacksFromNames(string[] attackNames)
        {
            List<Attack> attacks = new List<Attack>();
            List<Attack> fulListattacks = RepoAttack.getAttackList();

            foreach (string attackName in attackNames)
            {
               foreach (Attack attack in fulListattacks)
                {
                    if (attack.getName() == attackName)
                    {
                        attacks.Add(attack);
                        break;
                    }
                }
            }
            return attacks;
        }

        public static List<Monstruomon> getMonstruomonList()
        {
            return RepoMonsterMon.geMonstruomonList();
        }

        public static string[] getMonsterStringList()
        {
            List<Monstruomon> monstruomons = getMonstruomonList();
            string[] monstruomonStringArr = new string[monstruomons.Count()];
            for (int i = 0; i < monstruomonStringArr.Length; i++)
            {
                monstruomonStringArr[i] = monstruomons[i].ToString();
            }

            return monstruomonStringArr;
        }
    }
}
