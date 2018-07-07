using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Employee : Person, IQuittable

    {
        public override void SayName()
        {
            Console.WriteLine($"Name: [{FirstName} {LastName}]");
        }

        void IQuittable.Quit()
        {
            throw new NotImplementedException();
        }
        public string IQuittable();
        {
            Console.ReadLine(IQuittable);
        }
    }

}