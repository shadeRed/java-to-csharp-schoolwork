namespace Java_to_CSharp_Exercise
{
    abstract class Person
    {
        protected string name;

        public string GetName() { return name; }
        public void SetName(string name) { this.name = name; }
    }
}
