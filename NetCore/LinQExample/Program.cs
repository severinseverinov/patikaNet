namespace LinQExample{
    class Program{
        static void Main(string[] args){
            DataGenerator.Initialize();
            LinQDbContext _context=new LinQDbContext();
            var students=_context.Students.ToList<Student>();


            //Find() => Mevcut id'li veriye erişmeyi sağlar.
            Console.WriteLine("*** Find ***");
            //FirstOrDefault => Bulduğu veriler içerisinden ilkini getir.
            //Aşağıda iki farklı veri bulma yöntemi bulunmaktadır.
            var student1=_context.Students.Where(student=> student.StudentId==1).FirstOrDefault();
            var student2 = _context.Students.Find(1);
            Console.WriteLine(student1.Name);
            Console.WriteLine(student2.Surname);

            //FirstOrDefault() => Gelen verilerden eşlelen ilkini döndürür.
            Console.WriteLine("*** Find ***");
            //FirstOrDefault => Bulduğu veriler içerisinden ilkini getir.
            //Aşağıda iki farklı veri bulma yöntemi bulunmaktadır.
            var student=_context.Students.FirstOrDefault(x=> x.Surname=="Serbest");
           
            Console.WriteLine(student.Name);
            
            //SingleOrDefault() => Bir tane veri dönecek ise kullanılır.
            student=_context.Students.SingleOrDefault(student=> student.Name="Sevgin");
            Console.WriteLine(student.Surname);

            //ToList => Birden fazla veriyi diziye atmak için kullanılır.
            var studentList=_context.Students.Where(student=> student.ClassId==2).ToList();
            Console.WriteLine(studentList.Count);

            //OrderBy => id'lere göre liste elemanlarını artan şekilde sıralar.
            var students=_context.Students.OrderBy(x=> x.StudentId).ToList();

            //OrderByDescending => id'lere göre liste elemanlarını azalan şekilde sıralar.
            var students=_context.Students.OrderByDescending(x=> x.StudentId).ToList();

            //Anonymous Object Result => daha complex yapıda verileri getirmek için kullanılır.(Bir veri tabanı tablosuna benzetilebilir. yada bir objedir.)
            var anonymousObject=_context.Students
                                .Where(x=> x.ClassId==2)
                                .Select(x=> new {
                                    Id=x.StudentId,
                                    FullName=x.Name+" "+x.Surname
                                });

        }
    }
}
