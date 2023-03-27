using InterfacesWPU221;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace InterfacesWPU221
{
    class StudentCard
    {
        public int Number { get; set; }
        public string Series { get; set; }
        public override string ToString()
        {
            return $"Студенческий билет: {Series} {Number}\n";
        }
    }

    class Student : IComparable
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime birthDate { get; set; }
        public string group { get; set; }
        public int points { get; set; }
        public StudentCard StudentCard { get; set; }

        public override string ToString()
        {
            return $"Имя: {firstName}\nФамилия: {lastName}\nДата рождения: {birthDate.ToLongDateString()}\nФакультет: {group}\n" + StudentCard.ToString();
        }

        public int CompareTo(object obj)
        {
            if (obj is Student)
            {
                return lastName.CompareTo((obj as Student).lastName);
            }
            throw new NotImplementedException();
        }
        public int CompareTo(points)
        {
            return lastName.CompareTo(points);

        }
    }

    class Auditory : IEnumerable
    {
        Student[] students =
        {
            new Student
            {
                firstName="Harry",
                lastName="Potter",
                birthDate=new DateTime(1981,07,31),
                group="Griffindor",
                StudentCard=new StudentCard
                {
                    Number=19810731,
                    Series="HP"
                }
                points = 100;
    },
            new Student
            {
                firstName="Drako",
                lastName="Malfoy",
                birthDate=new DateTime(1981,10,23),
                group="Slitherin",
                StudentCard=new StudentCard
                {
                    Number=19811023,
                    Series="DM"
                }
points = 105;
            },
            new Student
            {
                firstName = "Polumna",
                lastName = "Lovegood",
                birthDate = new DateTime(1985, 03, 15),
                group = "Hufflepuff",
                StudentCard = new StudentCard
                {
                    Number = 19850315,
                    Series = "PL"
                }
                points = 99;
            },
            new Student
            {
                firstName = "Cedrick",
                lastName = "Diggory",
                birthDate = new DateTime(1980, 09, 25),
                group = "Ravenclaw",
                StudentCard = new StudentCard
                {
                    Number = 19800925,
                    Series = "CD"
                }
                points = 0;
            },
            new Student
            {
                firstName = "Severus";
                 lastName = "Snape";
                birthDate = new DateTime(1960, 01, 09);
                 group = "Slytherin";
                 StudentCard = new StudentCard
                 {
                     Number = 19600109;
                      Series = "SS";
                {
                      points = 50;
                 },


                new Student
                {
                    firstName = "Hermione",
                    lastName = "Granger",
                    birthDate = new DateTime(1990, 08, 24),
                    group = "Griffindor",
                    StudentCard = new StudentCard
                    {
                        Number = 19900824,
                        Series = "HG"
                    }
                points = 200;
                 },
                new Student
                {
                    firstName = "Ron",
                    lastName = "Wisly",
                    birthDate = new DateTime(1990, 06, 12),
                    group = "Griffindor",
                    StudentCard = new StudentCard
                    {
                        Number = 19900612,
                        Series = "RW"
                    }
                           points = 100;
                       },

                new Student
                {
                    firstName = "Belatrisa",
                    lastName = "Lastrange",
                    birthDate = new DateTime(1960, 04, 12),
                    group = "Slitherin",
                    StudentCard = new StudentCard
                    {
                        Number = 19600412;,
                        Series = "BL"
                    }
         points = 0;
     },
                new Student
                {
                    firstName = "Tom",
                    lastName = "Volan-de-Mor",
                    birthDate = new DateTime(1950, 06, 12),
                    group = "slitherin",
                    StudentCard = new StudentCard
                    {
                        Number = 19900612,
                        Series = "RW"
                    }
     points = 200;
 },
                new Student
                {
                    firstName = "Dolores",
                    lastName = "Ambridge",
                    birthDate = new DateTime(1940, 11, 01),
                    group = "Magic Ministery",
                    StudentCard = new StudentCard
                    {
                        Number = 19401101,
                        Series = "MM"
                    }
     points = 0;
 },

            };

public void Sort()
{
    Array.Sort(students);
}

public void Sort(IComparer comparer)
{
    Array.Sort(students, comparer);
}

IEnumerator IEnumerable.GetEnumerator()
        {
    return students.GetEnumerator();
}
    }

    class DataComparer : IComparer
{
    public int Compare(object x, object y)
    {
        if (x is Student && y is Student)
        {
            return DateTime.Compare((x as Student).birthDate, (y as Student).birthDate);
        }
        throw new NotImplementedException();
    }
}
class GroupComparer : IComparer
{
    public int compare(object k, object v)
    {
        if (k is Student && v is Student)
        {
            return GroupComparer((k as Student).group, (v as Student).group);

        }
        throw new NotImplementedException();
    }
}
class pointsComparer : IComparer
{
    public int compare(object u, object w)
    {
        if (u is Student && w is Student)
        {
            return pointsComparer((u as Student).age, (w as Student).age);
        }
        throw new NoImplementException();
    }
}

class Interfaces
{
    static void Main(string[] args)
    {
        Auditory auditory = new Auditory();
        WriteLine("************Список студентов*****************");
        WriteLine();
        foreach (Student student in auditory)
        {
            WriteLine(student);
        }
        WriteLine("***********Сортировка по фамилии************");
        WriteLine();
        auditory.Sort();
        foreach (Student student in auditory)
        {
            WriteLine(student);
        }

        WriteLine("***********Сортировка по дате рождения************");
        WriteLine();
        auditory.Sort(new DataComparer());
        foreach (Student student in auditory)
        {
            WriteLine(student);
        }
        WriteLine("****************Сортировка по факультету****************");
        WriteLine();
        auditory.Sort(new GroupComparer());
        foreach (Student student in auditory)
        {
            WriteLine(student);
        }
        WriteLine("****************Сортировка по  баллам****************");
        WriteLine();
        auditory.Sort(new pointsComparer());
        foreach (student in auditory)
        {
            WriteLine(student);
        }

    }
}
}

