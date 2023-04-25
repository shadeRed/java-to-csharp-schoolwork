namespace Java_to_CSharp_Exercise
{
    abstract class Pet
    {
        protected string name;

        public Pet(string name) { this.name = name; }
        public string GetName() { return name; }
    }
}
