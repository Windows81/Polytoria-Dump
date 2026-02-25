namespace System.Configuration;

[DefaultMember("Item")]
[Token(Token = "0x2000002")]
public abstract class ConfigurationElement
{

	[Token(Token = "0x17000001")]
	protected private override ConfigurationPropertyCollection Properties
	{
		[Address(RVA = "0x156A850", Offset = "0x1569A50", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
		[Token(Token = "0x6000001")]
		private get { } //Length: 44
	}

	[Address(RVA = "0x156A850", Offset = "0x1569A50", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x6000001")]
	protected private override ConfigurationPropertyCollection get_Properties() { }

	[Address(RVA = "0x156A7C0", Offset = "0x15699C0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x6000002")]
	protected private override bool IsModified() { }

	[Address(RVA = "0x156A820", Offset = "0x1569A20", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x6000003")]
	protected private override void Reset(ConfigurationElement parentElement) { }

	[Address(RVA = "0x156A7F0", Offset = "0x15699F0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x6000004")]
	protected private override void ResetModified() { }

}

