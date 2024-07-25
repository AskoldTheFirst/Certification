using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        // Add any initials here.
        public static void Initialize(CertificationContext ctx)
        {
            if (ctx.Questions.Any()) return;

            var questions = new List<Question>()
            {
                new Question
                {
                    Text = "Hundreds of the nation's top athletes are headed to Paris as part of Team USA in the 2024 Olympics.",
                    Answer1 = "aaa",
                    Answer2 = "bbb",
                    Answer3 = "ccc",
                    Answer4 = "ddd",
                    RightNumber = 2
                },

                new Question
                {
                    Text = "President Biden is meeting with Israeli Prime Minister Benjamin Netanyahu at the White House Thursday.",
                    Answer1 = "qqq",
                    Answer2 = "rrf",
                    Answer3 = "ttt",
                    Answer4 = "jjj",
                    RightNumber = 3
                },

                new Question
                {
                    Text = @"Vice President Harris has fought alongside Joe Biden to deliver historic accomplishments
                                and create a better life for A 10-year-old boy died Wednesday in a drone attack
                                targeting soldiers in Colombia, the first death of its kind in the country that has struggled to rein in guerrilla violence.",
                    Answer1 = "ccc",
                    Answer2 = "uuu",
                    Answer3 = "mmm",
                    Answer4 = "zzz",
                    RightNumber = 4
                }
            };

            ctx.Questions.AddRange(questions);
            ctx.SaveChanges();
        }
    }
}