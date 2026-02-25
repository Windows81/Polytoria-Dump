namespace System.Diagnostics;

[Obsolete("This class has been deprecated.  http://go.microsoft.com/fwlink/?linkid=14202")]
[Token(Token = "0x2000339")]
public class DiagnosticsConfigurationHandler : IConfigurationSectionHandler
{

	[Address(RVA = "0x1718580", Offset = "0x1717780", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x6001436")]
	public DiagnosticsConfigurationHandler() { }

	[Address(RVA = "0x1718550", Offset = "0x1717750", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x6001437")]
	public override object Create(object parent, object configContext, XmlNode section) { }

}

