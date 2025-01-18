namespace IdelPogFrontend.Source
{
    public abstract class Launcher
    {
        public static void Main()
        {
            IdelPog idelPog = new();
            idelPog.Run();
        }
    }
}

