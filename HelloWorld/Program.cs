namespace HelloWorld
{
    public class HelloWorldMainLauncherClass()
    {
        public HelloWorldMainLauncherClass(int foo) : this()
        {
            this.foo = foo;
        }

        private int foo = 0;

        public void SongRefrain()
        {
            for (int i = 0; i < foo; i++)
            {
                Console.WriteLine("Hello World!");
            }

            int pippo = 0;
            while (pippo < foo)
            {
                Console.WriteLine("Hello World!");
                pippo++;
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World Programmer Start!");
            HelloWorldMainLauncherClass tizio = new HelloWorldMainLauncherClass(2);
            tizio.SongRefrain();
            Console.WriteLine("Program Finished!");
            tizio.falseMethod();
        }

        /*
         * If I may introduce a bug, the CIL will manage it for me
         * ensuring both security and portability
         * Then I'll write my code once, and run it everywhere!
         * With Static and Strong Typing, will let my programs be type safe!
         */

        public void falseMethod()
        {
            bool metal = false;
            if (metal == false)
            {
                string joeyDeCaio = null;
                int length = joeyDeCaio.Length;
            }
        }
    }
}