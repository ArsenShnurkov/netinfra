namespace Network
{
	using System;

	public class NetworkAddressIPv4
	{
		byte B0 = 0;
		byte B1 = 0;
		byte B2 = 0;
		byte B3 = 0;
		public NetworkAddressIPv4(string addressString)
		{
			Parse(addressString);
		}
		protected NetworkAddressIPv4()
		{
		}
		public static NetworkAddressIPv4 FromString(string addressString)
		{
			NetworkAddressIPv4 addr = new NetworkAddressIPv4();
			addr.Parse(addressString);
			return addr;
		}
		public override string ToString()
		{
			string res = string.Format($"{B0}.{B1}.{B2}.{B3}", B0, B1, B2, B3);
			return res;
		}
		public void Parse(string addressString)
		{
			throw new NotImplementedException(); // mscorlib.dll в .Net или System.Runtime.dll в Core, namespace System
		}
	}
}
