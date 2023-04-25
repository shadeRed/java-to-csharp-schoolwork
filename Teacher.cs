namespace Java_to_CSharp_Exercise
{
    class Teacher : Person, ITalkable
    {
        private int _age;
        public Teacher(int age, string name) {
            SetAge(age);
            SetName(name);
        }

        public int GetAge() { return _age; }
        public void SetAge(int age) { _age = age; }
        public string Talk() { return "Don't forget to do the assigned reading!"; }
    }
}
