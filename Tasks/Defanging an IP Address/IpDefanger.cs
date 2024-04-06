namespace Defanging_an_IP_Address;

public static class IpDefanger
{
	public static string defangIPaddr(string address)
	{
		string output = address.Replace(".", "[.]");
		return output;
	}
}