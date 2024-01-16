namespace Generic
{
    public class MyList<T, K>
    {
        // public Object Value { get; set; }  // Bad. Don't use

        public T Value { get; set; }

        public K returnK(K k)
        {
            return k;
        }
    }
}
