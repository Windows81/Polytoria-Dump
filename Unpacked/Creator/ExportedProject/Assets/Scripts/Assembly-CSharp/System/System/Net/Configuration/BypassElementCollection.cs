namespace System.Net.Configuration;

[ConfigurationCollection(typeof(BypassElement))]
[DefaultMember("Item")]
[Token(Token = "0x2000328")]
public sealed class BypassElementCollection : ConfigurationElementCollection
{

	[Address(RVA = "0x1717F00", Offset = "0x1717100", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x600141B")]
	public BypassElementCollection() { }

}

