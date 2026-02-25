namespace System.Net.Configuration;

[ConfigurationCollection(typeof(ConnectionManagementElement))]
[DefaultMember("Item")]
[Token(Token = "0x200032A")]
public sealed class ConnectionManagementElementCollection : ConfigurationElementCollection
{

	[Address(RVA = "0x1718430", Offset = "0x1717630", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x600141C")]
	public ConnectionManagementElementCollection() { }

}

