namespace xopS.Services;

public interface IDeviceService
{
    IEnumerable<Device> GetDevicesPage(int page);
    void Add(Device device);
    void Remove(int id);

    int Pages();

    IEnumerable<Device> SearchByName(string name);
    int Pages(string name);
    IEnumerable<Device> SearchByName(String name,int page);
}