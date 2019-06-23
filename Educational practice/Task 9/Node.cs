namespace Task_9
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int data)
        {
            Data = data;
        }
        public Node() { }

        public override string ToString()
        {
            return $"{Data}";
        }
    }
}
