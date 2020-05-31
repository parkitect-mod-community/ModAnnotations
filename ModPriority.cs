namespace PMC.Mod
{
    public class ModPriority : System.Attribute
    {
        public int Priority { get; }

        public ModPriority(int priority)
        {
            Priority = priority;
        }
    }
}
