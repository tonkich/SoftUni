using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndAbstraction
{
    class PrintHumans
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            Student Anton = new Student("Anton", "Kolev", "234546"); students.Add(Anton);
            Student Penka = new Student("Penka", "Peneva", "817463"); students.Add(Penka);
            Student Gosho = new Student("Gosho", "Goshov", "3123567"); students.Add(Gosho);
            Student Marina = new Student("Marina", "Stoqnova", "423467"); students.Add(Marina);
            Student Neshto = new Student("Neshto", "Neshtovo", "133567"); students.Add(Neshto);
            Student Nqkoi = new Student("Nqkoi", "Nqkoev", "4346899"); students.Add(Nqkoi);
            Student Vladimir = new Student("Vladimir", "Putin", "627842"); students.Add(Vladimir);
            Student Kim = new Student("Kim", "Jong", "423423"); students.Add(Kim);
            Student Angela = new Student("Angela", "Merkel", "666666"); students.Add(Angela);
            Student Tom = new Student("Tom", "Bombadil", "5682467"); students.Add(Tom);
            var sortedStudents =
                students
                .OrderBy(student => student.FacultyNumber);

            foreach (Student student in sortedStudents)
            {
                Console.WriteLine("Name: {0} {1}, Faculty Number: {2}",
                    student.FirstName, student.LastName, student.FacultyNumber);
            }
            List<Worker> workers = new List<Worker>();
            
                Worker Anton1 = new Worker("Anton", "Kolev", 34556, 7 ); workers.Add(Anton1);
                Worker Penka1 = new Worker("Penka", "Peneva", 817463, 5); workers.Add(Penka1);
                Worker Gosho1 = new Worker("Gosho", "Goshov", 3123567, 6); workers.Add(Gosho1);
                Worker Marina1 = new Worker("Marina", "Stoqnova", 423467, 4); workers.Add(Marina1);
                Worker Neshto1 = new Worker("Neshto", "Neshtovo", 133567, 9); workers.Add(Neshto1);
                Worker Nqkoi1 = new Worker("Nqkoi", "Nqkoev", 4346899, 6); workers.Add(Nqkoi1);
                Worker Vladimir1 = new Worker("Vladimir", "Putin", 627842, 7); workers.Add(Vladimir1);
                Worker Kim1 = new Worker("Kim", "Jong", 423423, 8); workers.Add(Kim1);
                Worker Angela1 = new Worker("Angela", "Merkel", 666666, 3); workers.Add(Angela1);
                Worker Tom1 = new Worker("Tom", "Bombadil", 5682467, 5); workers.Add(Tom1);
                var sortedWorkers =
                    workers
                    .OrderByDescending(worker => worker.MoneyPerHour());

                foreach (Worker worker in sortedWorkers)
                {
                    Console.WriteLine("Name: {0} {1}, Week Salary: {2}, Work Hours Per Day: {3}",
                        worker.FirstName, worker.LastName, worker.WeekSalary, worker.WorkHoursPerDay);
                }
                List<Human> humans = new List<Human>();
                humans.AddRange(students);
                humans.AddRange(workers);

                var sortedHumans =
                    humans
                    .OrderBy(human => human.FirstName)
                    .ThenBy(human => human.LastName);

                foreach (Human human in sortedHumans)
                {
                    Console.WriteLine("Name: {0} {1}", human.FirstName, human.LastName);
                }
        }
    }
}
