namespace System.Configuration;

[Token(Token = "0x2000009")]
public sealed class IgnoreSection : ConfigurationSection
{

	[Token(Token = "0x17000002")]
	protected private virtual ConfigurationPropertyCollection Properties
	{
		[Address(RVA = "0x156AA60", Offset = "0x1569C60", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
		[Token(Token = "0x600000B")]
		private get { } //Length: 44
	}

	[Address(RVA = "0x156AA30", Offset = "0x1569C30", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x600000A")]
	public IgnoreSection() { }

	[Address(RVA = "0x156A940", Offset = "0x1569B40", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x600000C")]
	protected private virtual void DeserializeSection(XmlReader xmlReader) { }

	[Address(RVA = "0x156AA60", Offset = "0x1569C60", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x600000B")]
	protected private virtual ConfigurationPropertyCollection get_Properties() { }

	[Address(RVA = "0x156A970", Offset = "0x1569B70", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x600000D")]
	protected private virtual bool IsModified() { }

	[Address(RVA = "0x156A9D0", Offset = "0x1569BD0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x600000E")]
	protected private virtual void Reset(ConfigurationElement parentSection) { }

	[Address(RVA = "0x156A9A0", Offset = "0x1569BA0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x600000F")]
	protected private virtual void ResetModified() { }

	[Address(RVA = "0x156AA00", Offset = "0x1569C00", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x6000010")]
	protected private virtual string SerializeSection(ConfigurationElement parentSection, string name, ConfigurationSaveMode saveMode) { }

}

