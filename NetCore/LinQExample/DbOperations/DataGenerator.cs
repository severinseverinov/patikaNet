using System.Linq;
namespace LinQExample.DbOperations{
    public class DataGenerator{
        public static void Initialize(){
            using(var context=new LinQDbContext()){
                if(context.Students.Any()){
                    return;
                }
                context.Students.AddRange(
                    new Student(){
                        //StudentId=1,
                        Name="Sevgin",
                        Surname="Serbest",
                        ClassId=2
                    },
                    new Student(){
                        //StudentId=2,
                        Name="Elif",
                        Surname="Serbest",
                        ClassId=3
                    },new Student(){
                        //StudentId=3,
                        Name="Cihangir",
                        Surname="Serbest",
                        ClassId=1
                    },new Student(){
                        //sStudentId=1,
                        Name="Nil Nisa",
                        Surname="Serbest",
                        ClassId=4
                    }
                );
                context.SaveChanges(); 
            }
        }
    }
}