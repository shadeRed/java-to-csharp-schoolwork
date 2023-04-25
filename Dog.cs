namespace Java_to_CSharp_Exercise
{
    class Dog : Pet, ITalkable
    {
        private bool _friendly;
        public Dog(bool friendly, string name) : base(name) {
            _friendly = friendly;
        }

        public bool IsFriendly() { return _friendly; }

        public string Talk() { return "Bark"; }
        public override string ToString()
        {
            return $"Dog: name={name} friendly={_friendly}";
        }
    }
}
