
namespace LinkedListLibrary
{
    class ListNodeString
    {

        public string Data { get; private set; }

        public ListNodeString Next { get; set; }

        public ListNodeString(string dataValue) : this(dataValue, null) { }

        public ListNodeString(string dataValue, ListNodeString nextNode)
        {
            Data = dataValue;
            Next = nextNode;
        }
    }
}
