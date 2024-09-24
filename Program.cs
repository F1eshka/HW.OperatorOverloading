using System;

namespace HW.Student
{
    class Program
    {
        static void Main()
        {
            // Создание группы и вывод информации о группе
            Group group1 = new Group();
            Group group2 = new Group();
            Group group3 = new Group();


            // Создание студентов
            Student Malika = new Student("Малика", "Беноева", "Хасановна", "Глушко 38", 3807340555555);
            Student Pasha = new Student("Паша", "Якубинский", "Андреевич", "Глушко 36", 3807347255555);
            Student Anna = new Student("Анна", "Иванова", "Робертовна", "Глушко 34", 3807348455555);
            Student Ira = new Student("Ирина", "Краснова", "Эдуардовна", "Глушко 3", 3807348455555);
            Student Vasiliy = new Student("Василий", "Пупкин", "Самвелович", "Глушко 2", 3807348455555);
            Student Kiril = new Student("Кирил", "Баландин", "Шахедович", "Глушко 2", 3807348455555);



            // Заполнение оценок
            Malika.GenericHomeworks();
            Malika.GenericCoursWorks();
            Malika.GenericExams();

            Pasha.GenericHomeworks();
            Pasha.GenericCoursWorks();
            Pasha.GenericExams();

            Kiril.GenericHomeworks();
            Kiril.GenericCoursWorks();
            Kiril.GenericExams();

            Vasiliy.GenericHomeworks();
            Vasiliy.GenericCoursWorks();
            Vasiliy.GenericExams();

            Ira.GenericHomeworks();
            Ira.GenericCoursWorks();
            Ira.GenericExams();

            Anna.GenericHomeworks();
            Anna.GenericCoursWorks();
            Anna.GenericExams();

            // Добавляем студентов в группу
            group1.AddStudent(Malika);
            group1.AddStudent(Ira);
            group2.AddStudent(Vasiliy);
            group2.AddStudent(Pasha);
            group3.AddStudent(Anna);
            group3.AddStudent(Kiril);

            // Отображение информации о студентах
            group1.ShowAllStudents();
            group2.ShowAllStudents();
            group3.ShowAllStudents();

            Console.WriteLine("Введите новый номер курса для группы 1 (от 1 до 4):");
            if (int.TryParse(Console.ReadLine(), out int newCourseNumber1) && newCourseNumber1 >= 1 && newCourseNumber1 <= 4)
            {
                group1.EditGroup(newCourseNumber1);
            }
            else
            {
                Console.WriteLine("Некорректный ввод номера курса.");
            }

            // Отображение обновленной информации о группе 1
            Console.WriteLine("\nОбновленная информация о группе 1:");
            group1.ShowAllStudents();

            // Перевод студента в другую группу (создание другой группы для примера)
            Group newGroup = new Group();
            group1.PerevodStudent(newGroup, Malika);
            group3.PerevodStudent(newGroup, Anna);
            newGroup.PrintGroup();


            // Отображение информации о студентах и проверка, сдал ли студент
            foreach (var student in group1.GetStudents())
            {
                Console.WriteLine($"\n{student.GetSurname()} {student.GetName()} {(student ? "сдал" : "не сдал")}");
            }
            foreach (var student in group2.GetStudents())
            {
                Console.WriteLine($"\n{student.GetSurname()} {student.GetName()} {(student ? "сдал" : "не сдал")}");
            }
            foreach (var student in group3.GetStudents())
            {
                Console.WriteLine($"\n {student.GetSurname()} {student.GetName()} {(student ? "сдал" : "не сдал")}");
            }

            if (Anna == Ira)
            {
                Console.WriteLine("\nУ студентов Анна и Ира одинаковые номера");
            }
            else
            {
                Console.WriteLine("\nУ студентов Анна и Ира не одинаковые номера");
            }

            if (Malika != Pasha)
            {
                Console.WriteLine("\nУ студентов Малика и Паша не одинаковые номера");
            }

            if (Malika > Pasha)
            {
                Console.WriteLine("\nМалика имеет лучший средний балл, чем Паша");
            }
            else if (Malika < Pasha)
            {
                Console.WriteLine("\nПаша имеет лучший средний балл, чем Малика");
            }
            else
            {
                Console.WriteLine("\nУ студентов одинаковые средние баллы");
            }

            if (group1 == group2)
            {
                Console.WriteLine("\nГруппы 1 и 2 равны по количеству студентов.");
            }
            else
            {
                Console.WriteLine("\nГруппы 1 и 2 не равны по количеству студентов.");
            }



            Console.WriteLine("\nУдаление студентов с низким средним баллом и самого худшего студента:");
            group1.FailedStudents();
            group1.RemoveWorstStudent();

        

            // Печать информации о группах после перевода
            //Console.WriteLine("\nИнформация о группе после перевода студента:");
            //group1.PrintGroup();
            //group2.PrintGroup();
            //group3.PrintGroup();

            //newGroup.PrintGroup();
        }
    }
}
