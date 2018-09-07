// SocketPipeSender
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;

public class SocketPipeSender
{
    public SocketPipeSender()
    {
    }

    //public SocketPipeSender(string nameHost, string port)
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

    public void SendValue(string value)
    {

        PlayCantico(value);
        return;
        using (TcpClient tcpClient = new TcpClient(getIp4Adreess().ToString(), ValueNet.port))
        {
            using (NetworkStream output = tcpClient.GetStream())
            {
                BinaryWriter binaryWriter = new BinaryWriter(output);
                binaryWriter.Write(value);
                binaryWriter.Flush();
                binaryWriter.Close();
                tcpClient.Close();
            }
        }
    }

    ///

    public static void PlayCantico(string cantico)
    {
        try
        {
            Process[] processesByName = Process.GetProcessesByName("vlc");
            foreach (Process process in processesByName)
            {
                process.Kill();
            }
            Process process2 = new Process();
            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.FileName = "C:\\Program Files\\VideoLAN\\VLC\\vlc.exe";
            processStartInfo.Arguments = "C:\\CANTICOSVIDEO\\" + cantico + ".mp4";
            processStartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            process2.StartInfo = processStartInfo;
            process2.Start();
        }
        catch (Exception)
        {
        }
    }
    ///
}
