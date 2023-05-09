using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*
Примітки до завдання їжачок:
1.	Потрібно звести проміжні кольори до рівної кількості(5-5, 7-7)
2.	Щоб звести два види кольорових їжаків, потрібно мати різницю в три їжаки між цими кольорами
3.	Звести до одного кольору два інші можливо, якщо між одиницями кольорів(що зводяться) різниця кратна трьом. 
В цьому випадку найменша кількість інтерацій розраховується за формулою. 
(Різниця між кольорами розміну) / 3 + (кількість одного кольору для зведення, якщо кількість кольорів відповідає пункту 1).
*/

namespace Hedgehogtask
{
    public class Hedgehog
    {
        public static int StepCounter(byte targetColor, uint[] hedgehogs)
        {
            //setting only temporary color, for more convnient data
            uint[] _hedgehogs = new uint[2];
            if(targetColor == 0)
            {
                //if target already done will return -1
                if(hedgehogs[1] == 0 & hedgehogs[2] == 0) return -1;

                _hedgehogs = new uint[]{hedgehogs[1], hedgehogs[2]};

            }
            else if(targetColor == 1)
            {
                if(hedgehogs[0] == 0 & hedgehogs[2] == 0) return -1;

                _hedgehogs = new uint[]{hedgehogs[0], hedgehogs[2]};
            }
            else
            {
                if(hedgehogs[0] == 0 & hedgehogs[1] == 0) return -1;

                _hedgehogs = new uint[]{hedgehogs[0], hedgehogs[1]};
            }
            // check that we can set one color for each hedgehogs
            if(!ColorsFit(hedgehogs[targetColor],_hedgehogs))
            {
                return -1;
            }
            // calculating amount of steps
            else
            {
                //if temporary colors are the same, amount of steps equals to one of they
                if(_hedgehogs[0] == _hedgehogs[1])
                {
                    return (int)_hedgehogs[0];
                }
                // the following code return value if different between colors is able to divide by three
                else
                {
                    return (int) Math.Max((_hedgehogs[0]), _hedgehogs[1]);
                }
            }
        }

        static bool ColorsFit(uint targetHedgehogs, uint[] hedgehogs)
        {
            return Math.Abs((int)hedgehogs[0] - (int)hedgehogs[1]) == 0 || 
                Math.Abs((int)hedgehogs[0] - (int)hedgehogs[1]) % 3 == 0 &&
                ((int)Math.Abs((int)hedgehogs[0] - (int)hedgehogs[1]) / 3) <= targetHedgehogs;
        }
    }
}