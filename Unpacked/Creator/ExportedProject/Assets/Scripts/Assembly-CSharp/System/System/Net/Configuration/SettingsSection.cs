namespace System.Net.Configuration;

[Token(Token = "0x2000331")]
public sealed class SettingsSection : ConfigurationSection
{

	[Token(Token = "0x17000441")]
	protected virtual ConfigurationPropertyCollection Properties
	{
		[Address(RVA = "0x171C940", Offset = "0x171BB40", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
		[Token(Token = "0x600142A")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x171C910", Offset = "0x171BB10", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x6001429")]
	public SettingsSection() { }

	[Address(RVA = "0x171C940", Offset = "0x171BB40", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x600142A")]
	protected virtual ConfigurationPropertyCollection get_Properties() { }

}

