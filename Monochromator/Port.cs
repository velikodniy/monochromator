using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Monochromator
{
    public class Port : IDisposable
    {
        const int speed = 19200;
        const Parity parity = Parity.None;
        const int dataBits = 8;
        const StopBits stopBits = StopBits.Two;

#if !NOPORT
        SerialPort port;
#endif
        static public string[] GetPortNames()
        {
#if !NOPORT
            return SerialPort.GetPortNames();
#else
            return new[]{ "Test" };
#endif
        }

        public Port(string name)
        {
#if !NOPORT
            port = new SerialPort(name, speed, parity, dataBits, stopBits);
            port.Open();
#else
            MessageBox.Show("Порт открыт");
#endif
        }

        public void Dispose()
        {
#if !NOPORT
            port.Close();
#else
            MessageBox.Show("Порт закрыт");
#endif
        }

        Random rnd = new Random();
        public int GetData()
        {
#if !NOPORT
            var buf = new byte[2];

            for (int i = 0; i < 2; i++)
                port.Read(buf, i, 1);

            var C = buf[0] + (buf[1] << 8);
            var G = (C % 1023) & 3;
            var T = C & 1023;
#else
            var T = rnd.Next(50) + 100;
#endif
            return T;
        }
    }
}
