namespace Java_to_CSharp_Exercise
{
    class Cat : Pet, ITalkable
    {
        private int _mousesKilled;
        public Cat(int mousesKilled, string name) : base(name) {
            _mousesKilled = mousesKilled;
        }

        public int GetMousesKilled() { return _mousesKilled; }
        public void AddMouse() { _mousesKilled++; }

        public string Talk() { return "Meow"; }
        override public string ToString() { return $"Cat: name={name} mousesKilled={_mousesKilled}"; }
    }
}
