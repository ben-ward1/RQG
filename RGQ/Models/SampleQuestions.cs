using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RGQ.Models
{
    public class SampleQuestions
    {
        public Question[] Samples { get; set; }
        
        public SampleQuestions()
        {
            this.Samples = new Question[]
            {
                new Question
                {
                    Description = "This interface requires a class to implement the Dispose() method.",
                    Answer = "IDisposable"
                },
                new Question
                {
                    Description = "The four principles of object-oriented programming are:",
                    Answer = "Encapsulation, Abstraction, Inheritance, Polymorphism"
                },
                new Question
                {
                    Description = "Tables that have a primary key and only a single value to each attribute" +
                    "with non-key attributes depending on the primary key are said to be in this normal form.",
                    Answer = "First normal form"
                },
                new Question
                {
                    Description = "Tables where the non-key attributes depend on the entire composite key are" +
                    "said to be in this form.",
                    Answer = "Second normal form (IF table also meets 1NF)   (Note: Tables that meet 1NF whose" +
                    "key is composed of a single attribute are automatically meet 2NF)"
                },
                new Question
                {
                    Description = "A table where all attributes depend on the candidate keys and no other non-key" +
                    "attributes are said to be in this form.",
                    Answer = "Third normal form (if the table also meets 2NF)"
                }
            };
        }

    }
}
