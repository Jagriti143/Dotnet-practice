using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Registration_System
{
    // =========================
    // University System Class
    // =========================
    public class UniversitySystem
    {
        public Dictionary<string, Course> AvailableCourses { get; private set; }
        public Dictionary<string, Student> Students { get; private set; }

        public UniversitySystem()
        {
            AvailableCourses = new Dictionary<string, Course>();
            Students = new Dictionary<string, Student>();
        }

        public void AddCourse(string code, string name, int credits, int maxCapacity = 50, List<string> prerequisites = null)
        {
            // TODO:
            // 1. Throw ArgumentException if course code exists
            // 2. Create Course object
            // 3. Add to AvailableCourses
            if (AvailableCourses.ContainsKey(code))
            throw new ArgumentException("Course already exists.");

            Course c = new Course(code, name, credits, maxCapacity, prerequisites);
            AvailableCourses.Add(code, c);
        }

        public void AddStudent(string id, string name, string major, int maxCredits = 18, List<string> completedCourses = null)
        {
            // TODO:
            // 1. Throw ArgumentException if student ID exists
            // 2. Create Student object
            // 3. Add to Students dictionary
            if (Students.ContainsKey(id))
            throw new ArgumentException("Student already exists.");

        Student s = new Student(id, name, major, maxCredits, completedCourses);
        Students.Add(id, s);
        }

        public bool RegisterStudentForCourse(string studentId, string courseCode)
        {
            // TODO:
            // 1. Validate student and course existence
            // 2. Call student.AddCourse(course)
            // 3. Display meaningful messages
            if (!Students.ContainsKey(studentId))
        {
            Console.WriteLine("Student not found.");
            return false;
        }

        if (!AvailableCourses.ContainsKey(courseCode))
        {
            Console.WriteLine("Course not found.");
            return false;
        }

        if (Students[studentId].AddCourse(AvailableCourses[courseCode]))
        {
            Console.WriteLine($"Registration successful! Total credits: " +$"{Students[studentId].GetTotalCredits()}/{Students[studentId].MaxCredits}.");
            return true;
        }

        Console.WriteLine("Registration failed. Check prerequisites, credit limit, or capacity.");
        return false;
        }

        public bool DropStudentFromCourse(string studentId, string courseCode)
        {
            // TODO:
            // 1. Validate student existence
            // 2. Call student.DropCourse(courseCode)
            if (!Students.ContainsKey(studentId))
        {
            Console.WriteLine("Student not found.");
            return false;
        }

        if (Students[studentId].DropCourse(courseCode))
        {
            Console.WriteLine("Course dropped successfully.");
            return true;
        }

        Console.WriteLine("Student not registered in this course.");
        return false;
        }

        public void DisplayAllCourses()
        {
            // TODO:
            // Display course code, name, credits, enrollment info
            Console.WriteLine("Available Courses:");
            foreach (Course c in AvailableCourses.Values)
            {
                Console.WriteLine($"{c.CourseCode} | {c.CourseName} | {c.Credits} | {c.GetEnrollmentInfo()}");
            }
        }

        public void DisplayStudentSchedule(string studentId)
        {
            if (!Students.ContainsKey(studentId))
            {
                Console.WriteLine("Student not found.");
                return;
            }

            Students[studentId].DisplaySchedule();
        }

        public void DisplaySystemSummary()
        {
            Console.WriteLine("System Summary: ");
            Console.WriteLine($"-Total Students: {Students.Count}");
            Console.WriteLine($"-Total Courses: {AvailableCourses.Count}");

            if (AvailableCourses.Count > 0)
            {
                double avg = AvailableCourses.Values
                            .Average(c => int.Parse(c.GetEnrollmentInfo().Split('/')[0]));

                Console.WriteLine($"-Average Enrollment: {avg:F1}");
            }
        }
    }
}