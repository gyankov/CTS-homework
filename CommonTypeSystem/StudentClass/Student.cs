using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
  internal  class Student: ICloneable, IComparable
    {
       


        public Student(string firstName, string middleName, string lastName, int ssn, string address,
            string phone, int course, Specialty specialty, Universities university, Faculties faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Ssn = ssn;
            this.Address = address;
            this.Phone = phone;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }


        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }
        public int Ssn { get; private set; }
        public string Address { get; private set; }
        public string Phone { get; private set; }
        public int Course { get; private set; }
        public Specialty Specialty { get; private set; }
        public Universities University { get; private set; }
        public Faculties Faculty { get; private set; }

        public override bool Equals(object obj)
        {
            var secondStudent = obj as Student;

            if (secondStudent==null)
            {
                throw new ArgumentException();
            }

            if (this.Ssn==secondStudent.Ssn)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.Append("Name:" + " " + this.FirstName + " " + this.MiddleName + " " + this.LastName + "\n" +
                "SSN:" + " " + this.Ssn + "\n" + "Address: " + this.Address + "\n" + "Phonë: " + this.Phone);
            return result.ToString();
        }

        public override int GetHashCode()
        {
            return this.Ssn.GetHashCode() ^ this.Course.GetHashCode();
        }

        public object Clone()
        {
            // all of the fields of this class are value types so this clone is deep enough :D

            var cloned = this.MemberwiseClone();

            return cloned;
        }

        public int CompareTo(object obj)
        {
            var secondStudent = obj as Student;
            if (secondStudent==null)
            {
                throw new ArgumentException();
            }

            var compareName = this.FirstName.CompareTo(secondStudent.FirstName);
            var compareSsn = this.Ssn.CompareTo(secondStudent.Ssn);

            if (compareName ==1 )
            {
                return 1;
            }
            else if (compareName==-1)
            {
                return -1;
            }
            else
            {
                if (compareSsn==1)
                {
                    return 1;
                }
                else if (compareSsn==-1)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }

        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return Student.Equals(firstStudent, secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !Student.Equals(firstStudent, secondStudent);
        }


    }

    public enum Specialty
    {
        Informatics,
        Geodesy,
        Architecture

    }

    public enum Universities
    {
        UACEG,
        TU,
        SU
        
    }

    public enum Faculties
    {
        first,
        second,
        third
        
    
    }
}
