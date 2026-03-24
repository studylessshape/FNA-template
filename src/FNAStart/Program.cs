using Microsoft.Xna.Framework;

class Program
{
    [STAThread]
    static void Main(string[] args)
    {
        using (Game g = new Game())
        {
            new GraphicsDeviceManager(g);
            g.Run();
        }
    }
}