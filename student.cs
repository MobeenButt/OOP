using System;
using System.Security.Authentication.ExtendedProtection.Configuration;

namespace Constructor
{
    class student
    {
        public student()
        {
            Console.WriteLine("Default Constructor");/// like a default constuctor
        }
        public student(student s)
        {
            sname = s.sname;
            matricMarks = s.matricMarks;
            fscMarks= s.fscMarks;
            ecatMarks = s.ecatMarks;
            aggregate = s.aggregate;

        }
        public string sname;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public float aggregate;

    }
}
