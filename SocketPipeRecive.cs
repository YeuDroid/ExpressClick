// SocketPipeRecive

using System.IO;
using System.Net;
using System.Net.Sockets;

public class SocketPipeRecive
{
    public SocketPipeRecive()
    {
    }

    //public SocketPipeRecive(string nameHost, string port)
    //{
    //    ValueNet.nameServer = nameHost;
    //    ValueNet.port = int.Parse(port);
    //}

    public IPAddress getIp4Adreess()
    {
        IPAddress[] addressList = Dns.GetHostEntry(ValueNet.nameServer).AddressList;
        foreach (IPAddress iPAddress in addressList)
        {
            if (iPAddress.AddressFamily == AddressFamily.InterNetwork)
            {
                ValueNet.adrress = iPAddress.ToString();
                return iPAddress;
            }
        }
        return null;
    }

    public string ScanForValue()
    {
        TcpListener tcpListener = new TcpListener(IPAddress.Any, ValueNet.port);
        tcpListener.Start();
        string result = "NULL";
        using (TcpClient tcpClient = tcpListener.AcceptTcpClient())
        {
            using (NetworkStream input = tcpClient.GetStream())
            {
                result = new BinaryReader(input).ReadString();
            }
        }
        tcpListener.Stop();
        return result;
    }
}
