using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicBall
{
    public static string GetOneRandom()
    {
        Random rnd = new Random();
        int i = rnd.Next(0, 19);
        int i = rnd.Next(0, (int)Answers.LongCount());
        return Answers[i];
    }
}
