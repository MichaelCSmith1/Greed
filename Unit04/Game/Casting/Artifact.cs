namespace Unit04.Game.Casting{
        /// <summary>
        /// <para>An item of cultural or historical interest.</para>
        /// <para>
        /// The responsibility of an Artifact is to provide a message about itself.
        /// </para>
        /// </summary>
    class Artifact : Actor{
        private string _artifact;
        private int _value;
        /// <summary>
        /// Constructs a new instance of Artifact.
        /// </summary>
        public Artifact(){
            _artifact = "artifact";
        }

        public void SetValue(int value)
        {
            _value = value;
        }

        public int GetValue()
        {
            return _value;
        }
    }
}
