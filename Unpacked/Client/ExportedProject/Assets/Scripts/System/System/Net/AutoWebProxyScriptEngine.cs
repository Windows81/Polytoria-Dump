namespace System.Net;

[Token(Token = "0x200026F")]
internal class AutoWebProxyScriptEngine
{

	[Address(RVA = "0x17E9380", Offset = "0x17E8580", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FB8")]
	public bool GetProxies(Uri destination, out IList<String>& proxyList) { }

	[Address(RVA = "0x17E9380", Offset = "0x17E8580", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FB9")]
	public bool GetProxies(Uri destination, out IList<String>& proxyList, ref int syncStatus) { }

}

