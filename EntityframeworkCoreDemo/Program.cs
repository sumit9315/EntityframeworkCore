using EntityframeworkCoreDemo.Entities;

namespace EntityframeworkCoreDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var context = new MyDbContext())
                {
                    //context.Database.EnsureCreated();
                    //Console.WriteLine("Database created.");
                
                    Console.WriteLine("Creating Student object and assign data to student property......");


                    var branch1 = new Branch()
                    {
                        BranchName = "Electrical and Electronics Engineering",
                        Description = "BTECH",
                        PhoneNumber = "54678909087",
                        Email = "EEE@beta.edu.in"

                    };

                    var branch2 = new Branch()
                    {
                        BranchName = "Computer Science Engineering",
                        Description = "MTECH",
                        PhoneNumber = "54678909087",
                        Email = "CSEE@beta.edu.in"

                    };

                    context.Branches.Add(branch1);
                    //context.SaveChanges();
                    context.Branches.Add(branch2);
                    context.SaveChanges();



                    Console.WriteLine("Branch 1 details:");
                    Console.WriteLine($"Branch Name : {branch1.BranchName}, Branch Email={branch1.Email}");

                    Console.WriteLine("Branch 2 details:");
                    Console.WriteLine($"Branch Name : {branch2.BranchName}, Branch Email={branch2.Email}");
                    //var eee = context.Branches.Find(t => t.BrancheName);

                    var cse = context.Branches.FirstOrDefault(b => b.BranchName == branch1.BranchName);
                    var eee = context.Branches.FirstOrDefault(b => b.BranchName == branch2.BranchName);

                    //1st way to create object of model and assign value to variable

                    if (cse != null && eee != null)
                    {

                        var Student1 = new Student();
                        {
                            Student1.FirstName = "Sumit";
                            Student1.LastName = "Raj";
                            //DateOfBirth= DateTime.Now
                            Student1.DateOfBirth = new DateTime(1998, 08, 12, 05, 45, 52, 567);
                            Student1.Gender = "Male";
                            Student1.Email = "sumit@alpha.com";
                            Student1.EnrollmentDate = DateTime.Now;
                            Student1.PhoneNumber = "1234567890";
                            Student1.Branch = cse;
                        };

                        //2nd way to create object of model and assign value to variable
                        var Student2 = new Student()
                        {
                            FirstName = "Rahul",
                            LastName = "Sharma",
                            //DateOfBirth= DateTime.Now
                            DateOfBirth = new DateTime(1994, 11, 15, 08, 59, 52, 007),
                            Gender = "Male",
                            Email = "Rsharma@alpha.com",
                            EnrollmentDate = DateTime.Now,
                            Branch = eee

                        };

                        //2nd way to create object of model and assign value to variable
                        var Student3 = new Student()
                        {
                            FirstName = "Preeti",
                            LastName = "Mehra",
                            //DateOfBirth= DateTime.Now
                            DateOfBirth = new DateTime(1995, 01, 5, 12, 41, 12, 034),
                            Gender = "Female",
                            Email = "PreetiM@alpha.com",
                            EnrollmentDate = DateTime.Now,
                            PhoneNumber = "839632739",
                            Branch = eee
                        };



                        Console.WriteLine($"Name : {Student1.FirstName} {Student1.LastName} ,DOB : {Student1.DateOfBirth}, Enrollment Date : {Student1.EnrollmentDate}, Email: {Student1.Email} ");
                        context.Students.Add(Student1);
                        context.SaveChanges();

                        Console.WriteLine($"Name : {Student1.FirstName} {Student1.LastName} ,DOB : {Student1.DateOfBirth}, Enrollment Date : {Student1.EnrollmentDate}, Email: {Student1.Email} ");
                        context.Students.Add(Student2);
                        Console.WriteLine($"Name : {Student2.FirstName} {Student1.LastName} ,DOB : {Student2.DateOfBirth}, Enrollment Date : {Student2.EnrollmentDate}, Email: {Student2.Email} ");
                        context.Students.Add(Student3);
                        context.SaveChanges();
                    }
                    else
                    {
                        Console.WriteLine("Branch Not Found!!!!!!");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error:{ex.Message}");
            }
        }
    }
}

