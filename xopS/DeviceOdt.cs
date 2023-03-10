using System.Text.Json.Serialization;

namespace xopS;

public class DeviceOdt
{
    public string OSVersion { get; set; }
    public string MachineName { get; set; }
    public string UserName { get; set; }
    public DateTime Time { get; set; }

    [JsonConstructor]
    public DeviceOdt(string osVersion, string machineName, string userName , DateTime time)
    {
        OSVersion = osVersion;
        MachineName = machineName;
        UserName = userName;
        Time = time;
    }

    public DeviceOdt(string osVersion, string machineName, string userName)
    {
        OSVersion = osVersion;
        MachineName = machineName;
        UserName = userName;
        Time = DateTime.Now;
    }

    public DeviceOdt(Device device)
    {
        OSVersion = device.OSVersion;
        MachineName = device.MachineName;
        UserName = device.UserName;
        Time = device.Time;
    }
    

    public override string ToString()
    {
        return $"""
                    osVersion = {OSVersion};
                    machineName = {MachineName};
                    userName = {UserName};
                    time = {Time.ToShortTimeString()};
                """;
    }
}