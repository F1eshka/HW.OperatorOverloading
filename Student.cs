using System;
using System.Collections.Generic;

namespace HW.Student;

class Student
{
    internal string name;
    internal string surname;
    internal string papaname;
    internal string adress;
    internal long number;
    internal static Random random = new Random();
    internal DateTime birthday;
    internal List<int> homeworks = new List<int>();
    internal List<int> courseWorks = new List<int>();
    public List<int> exams = new List<int>();

    public List<int> GetExams()
    {
        return exams;
    }

    public void GenericHomeworks()
    {
        for (int i = 0; i <= 12; i++)
        {
            int randomHomework = random.Next(1, 13); 
            homeworks.Add(randomHomework);
        }
        //Console.Write("Homeworks: ");
        //foreach (int el in homeworks)
        //{
        //    Console.Write(el + ". ");
        //}
    }

    public void GenericCoursWorks()
    {
        for (int i = 0; i <= 3; i++)
        {
            int randomCoursWork = random.Next(1, 13); 
            courseWorks.Add(randomCoursWork);
        }
        //Console.WriteLine(" ");
        //Console.Write("Course works: ");
        //foreach (int el in courseWorks)
        //{
        //    Console.Write(el + ". ");
        //}
    }

    public void GenericExams()
    {
        for (int i = 0; i <= 1; i++)
        {
            int randomExams = random.Next(1, 13); 
            exams.Add(randomExams);
        }
        //Console.WriteLine(" ");
        //Console.Write("Exams: ");
        //foreach (int el in exams)
        //{
        //    Console.Write(el + ". ");
        //}
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }
    public void SetSurname(string surname)
    {
        this.surname = surname;
    }

    public string GetSurname()
    {
        return surname;
    }
    public void SetPapaname(string papaname)
    {
        this.papaname = papaname;
    }

    public string GetPapaname()
    {
        return papaname;
    }

    public void SetAdress(string adress)
    {
        this.adress = adress;
    }

    public string GetAdress()
    {
        return adress;
    }
    public void SetNumber(long number)
    {
        this.number = number;
    }

    public long GetNumber()
    {
        return number;
    }
    public DateTime GetDateTime()
    {
        return birthday;
    }

    public Student()
    {
       
    }

    public Student(string _name, string _surname, string _papaname, string _adress, long _number)
    {
        //birthday = new DateTime(new Random().Next(1980, 2015) , new Random().Next(1, 12), new Random().Next(1, 28));
        birthday = GenerateRandomDate(1980, 2015);
        SetName(_name);
        SetSurname(_surname);
        SetPapaname(_papaname);
        SetAdress(_adress);
        SetNumber(_number);

        //Print();


    }

    public Student(Student student)
    {
    }

    private DateTime GenerateRandomDate(int startYear, int endYear)
    {
        int year = random.Next(startYear, endYear + 1);
        int month = random.Next(1, 13);
        int day = random.Next(1, DateTime.DaysInMonth(year, month) + 1); 
        return new DateTime(year, month, day);
    }

    public static bool operator true(Student student)
    {
        foreach (int mark in student.exams)
        {
            if (mark >= 6)
            {
                return true; 
            }
        }
        return false;
    }


    public static bool operator false(Student student)
    {
        foreach (int mark in student.exams)
        {
            if (mark >= 6)
            {
                return false; 
            }
        }
        return true; 
    }

    public static bool operator ==(Student a, Student b)
    {

        return a.number == b.number;
    }

    public static bool operator !=(Student a, Student b)
    {
        return !(a == b); 
    }

    public double GetAverageMark()
    {
        double totalCount = ((GetExams().Sum() / 2) + (homeworks.Sum() / 13) + (courseWorks.Sum() / 4)) / 3;

        return totalCount;
    }


    public static bool operator >(Student a, Student b)
    {

        return a.GetAverageMark() > b.GetAverageMark();
    }

    public static bool operator <(Student a, Student b)
    {
        return a.GetAverageMark() < b.GetAverageMark();
    }






    //public void SetValue(string name, string surname, string papaname, string adress, long number)
    //{
    //    this.name = name;
    //    this.surname = surname; 
    //    this.papaname = papaname;
    //    this.adress = adress;
    //    this.number = number;
    //}



    //public void Print()
    //{
    ////    Console.WriteLine("Surname: " + surname);
    ////    Console.WriteLine("Name: " + name);
    ////    Console.WriteLine("Papaname: " + papaname);
    //    Console.WriteLine("Адрес: " + adress);
    //    Console.WriteLine("Номер телефона: " + number);
    //    Console.WriteLine($"День рождения:  {birthday.ToString("dd.MM.yyyy")}");
    //    GenericHomeworks();
    //    GenericCoursWorks();
    //    GenericExams();

    //}



}

