# Microsoft.VisualBasic.Devices

``` diff
+namespace Microsoft.VisualBasic.Devices {
+    public class Audio {
+        public Audio();
+        public void Play(byte[] data, AudioPlayMode playMode);
+        public void Play(Stream stream, AudioPlayMode playMode);
+        public void Play(string location);
+        public void Play(string location, AudioPlayMode playMode);
+        public void PlaySystemSound(SystemSound systemSound);
+        public void Stop();
+    }
+    public class Clock {
+        public Clock();
+        public DateTime GmtTime { get; }
+        public DateTime LocalTime { get; }
+        public int TickCount { get; }
+    }
+    public class Computer : ServerComputer {
+        public Computer();
+        public Audio Audio { get; }
+        public ClipboardProxy Clipboard { get; }
+        public Keyboard Keyboard { get; }
+        public Mouse Mouse { get; }
+        public Ports Ports { get; }
+        public Screen Screen { get; }
+    }
+    public class ComputerInfo {
+        public ComputerInfo();
+        public ulong AvailablePhysicalMemory { get; }
+        public ulong AvailableVirtualMemory { get; }
+        public CultureInfo InstalledUICulture { get; }
+        public string OSFullName { get; }
+        public string OSPlatform { get; }
+        public string OSVersion { get; }
+        public ulong TotalPhysicalMemory { get; }
+        public ulong TotalVirtualMemory { get; }
+    }
+    public class Keyboard {
+        public Keyboard();
+        public bool AltKeyDown { get; }
+        public bool CapsLock { get; }
+        public bool CtrlKeyDown { get; }
+        public bool NumLock { get; }
+        public bool ScrollLock { get; }
+        public bool ShiftKeyDown { get; }
+        public void SendKeys(string keys);
+        public void SendKeys(string keys, bool wait);
+    }
+    public class Mouse {
+        public Mouse();
+        public bool ButtonsSwapped { get; }
+        public bool WheelExists { get; }
+        public int WheelScrollLines { get; }
+    }
+    public class Network {
+        public Network();
+        public bool IsAvailable { get; }
+        public event NetworkAvailableEventHandler NetworkAvailabilityChanged;
+        public void DownloadFile(string address, string destinationFileName);
+        public void DownloadFile(string address, string destinationFileName, string userName, string password);
+        public void DownloadFile(string address, string destinationFileName, string userName, string password, bool showUI, int connectionTimeout, bool overwrite);
+        public void DownloadFile(string address, string destinationFileName, string userName, string password, bool showUI, int connectionTimeout, bool overwrite, UICancelOption onUserCancel);
+        public void DownloadFile(Uri address, string destinationFileName);
+        public void DownloadFile(Uri address, string destinationFileName, ICredentials networkCredentials, bool showUI, int connectionTimeout, bool overwrite);
+        public void DownloadFile(Uri address, string destinationFileName, ICredentials networkCredentials, bool showUI, int connectionTimeout, bool overwrite, UICancelOption onUserCancel);
+        public void DownloadFile(Uri address, string destinationFileName, string userName, string password);
+        public void DownloadFile(Uri address, string destinationFileName, string userName, string password, bool showUI, int connectionTimeout, bool overwrite);
+        public void DownloadFile(Uri address, string destinationFileName, string userName, string password, bool showUI, int connectionTimeout, bool overwrite, UICancelOption onUserCancel);
+        public bool Ping(string hostNameOrAddress);
+        public bool Ping(string hostNameOrAddress, int timeout);
+        public bool Ping(Uri address);
+        public bool Ping(Uri address, int timeout);
+        public void UploadFile(string sourceFileName, string address);
+        public void UploadFile(string sourceFileName, string address, string userName, string password);
+        public void UploadFile(string sourceFileName, string address, string userName, string password, bool showUI, int connectionTimeout);
+        public void UploadFile(string sourceFileName, string address, string userName, string password, bool showUI, int connectionTimeout, UICancelOption onUserCancel);
+        public void UploadFile(string sourceFileName, Uri address);
+        public void UploadFile(string sourceFileName, Uri address, ICredentials networkCredentials, bool showUI, int connectionTimeout);
+        public void UploadFile(string sourceFileName, Uri address, ICredentials networkCredentials, bool showUI, int connectionTimeout, UICancelOption onUserCancel);
+        public void UploadFile(string sourceFileName, Uri address, string userName, string password);
+        public void UploadFile(string sourceFileName, Uri address, string userName, string password, bool showUI, int connectionTimeout);
+        public void UploadFile(string sourceFileName, Uri address, string userName, string password, bool showUI, int connectionTimeout, UICancelOption onUserCancel);
+    }
+    public class NetworkAvailableEventArgs : EventArgs {
+        public NetworkAvailableEventArgs(bool networkAvailable);
+        public bool IsNetworkAvailable { get; }
+    }
+    public delegate void NetworkAvailableEventHandler(object sender, NetworkAvailableEventArgs e);
+    public class Ports {
+        public Ports();
+        public ReadOnlyCollection<string> SerialPortNames { get; }
+        public SerialPort OpenSerialPort(string portName);
+        public SerialPort OpenSerialPort(string portName, int baudRate);
+        public SerialPort OpenSerialPort(string portName, int baudRate, Parity parity);
+        public SerialPort OpenSerialPort(string portName, int baudRate, Parity parity, int dataBits);
+        public SerialPort OpenSerialPort(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits);
+    }
+    public class ServerComputer {
+        public ServerComputer();
+        public Clock Clock { get; }
+        public FileSystemProxy FileSystem { get; }
+        public ComputerInfo Info { get; }
+        public string Name { get; }
+        public Network Network { get; }
+        public RegistryProxy Registry { get; }
+    }
+}
```

