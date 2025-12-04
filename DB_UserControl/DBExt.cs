
namespace DB_UserControl
{
    partial class Subject
    {
        public override string ToString()
        {
            return $"{this.Name} - {this.Hours}h ({Teacher})";
        }
    }

    partial class Teacher
    {
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}";
        }
    }
}