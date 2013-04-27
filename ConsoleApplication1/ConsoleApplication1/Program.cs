using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ConsoleApplication37
{
    public interface Iinferior
    {
        bool isWorking { get; }
        object Work();
    }

    public interface IManager
    {
        void Organize();
        void Plane();
        void Motivate();
           
    }
   
    class Human
    {
        protected string Fullname;
        protected string LastName;
        protected string MiddleName;
        protected DateTime birthday;
        public string FULLNAME { get { return this.Fullname; } set { this.Fullname = value; } }
        public string LASTNAME { get { return this.LastName; } set { this.LastName = value; } }
        public string MIDDLENAME { get { return this.MiddleName; } set { this.MiddleName = value; } }
        public DateTime BirthDay { get { return this.birthday; } set { this.birthday = value; } }
        public Human()
        {
        }
        public Human(string fName, DateTime day)
        {
            Fullname = fName;
            birthday = day;
        }
        public Human(string fName)
        {
            Fullname = fName;
        }
        public virtual void Work()
        {
            Console.WriteLine("I am Working");
        }
        public virtual void Rest()
        {
            Console.WriteLine("I am Resting");
        }
    }
    abstract class Learner : Human
    {
        bool isWork = false;
        public void Work()
        {
        }
        public void Study()
        {
        }
    }
    class Tutor : Human
    {
        List<Learner> l;
        public List<Learner> LEARNER
        {
            get { return l; }
            set { this.l = value; }
        }
    }
    class Student : Learner
    {
        public string FULLNAME { get { return this.Fullname; } set { this.Fullname = value; } }
        public string LASTNAME { get { return this.LastName; } set { this.LastName = value; } }
        public string MIDDLENAME { get { return this.MiddleName; } set { this.MiddleName = value; } }
        public DateTime BirthDay { get { return this.birthday; } set { this.birthday = value; } }
    }
    class SchoolBoy : Learner
    {
        public string FULLNAME { get { return this.Fullname; } set { this.Fullname = value; } }
        public string LASTNAME { get { return this.LastName; } set { this.LastName = value; } }
        public string MIDDLENAME { get { return this.MiddleName; } set { this.MiddleName = value; } }
        public DateTime BirthDay { get { return this.birthday; } set { this.birthday = value; } }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
