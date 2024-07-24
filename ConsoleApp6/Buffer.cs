namespace ConsoleApp6
{
    public struct Buffer
    {
        private int[] _elements; // Array to hold elements

        // Constructor to initialize the array
        public Buffer(int size)
        {
            _elements = new int[size];
        }

        // Indexer to access elements
        public int this[int index]
        {
            get { return _elements[index]; }
            set { _elements[index] = value; }
        }
    }
