namespace LinQExample.Entities
{
    public class Student{
        [DatabaseGenerated(DatabaseGeneratedOprtion.Identify)]
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int ClassId { get; set; }
    }
}