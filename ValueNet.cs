// ValueNet
public class ValueNet
{
    public static string nameServer
    {
        get
        {
            try
            {
                return System.IO.File.ReadAllLines("server.txt")[0];
            }
            catch (System.IO.IOException)
            {
                var txt = "DESKTOP - MDNFF9R";
                System.IO.File.WriteAllText("server.txt", txt);
                return "DESKTOP - MDNFF9R";
            }
        }
            
    }  

    public static int port
    { //        12347;
        get
        {
            return 12347;
        }
    }
    

    public static string adrress = "NULLERROR";
}
