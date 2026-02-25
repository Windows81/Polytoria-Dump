namespace System.Net.Configuration;

[ConfigurationCollection(typeof(WebRequestModuleElement))]
[DefaultMember("Item")]
[Token(Token = "0x2000337")]
public sealed class WebRequestModuleElementCollection : ConfigurationElementCollection
{

	[Address(RVA = "0x1731A00", Offset = "0x1730C00", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x6001435")]
	public WebRequestModuleElementCollection() { }

}

