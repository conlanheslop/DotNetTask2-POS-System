using POS_System;
using System;
using System.Windows.Forms;

static class Program
{
    [STAThread]
    static void Main()
    {
        // create the database, if it doesn't already exist.
        using (var context = new AppDbContext())
        {
            context.Database.EnsureCreated();
        }

        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new LoginScreen());
    }
}
