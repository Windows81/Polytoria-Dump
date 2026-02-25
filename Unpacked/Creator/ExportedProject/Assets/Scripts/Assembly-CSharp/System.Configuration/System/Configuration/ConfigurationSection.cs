namespace System.Configuration;

[Token(Token = "0x2000003")]
public abstract class ConfigurationSection : ConfigurationElement
{

	[Address(RVA = "0x156A880", Offset = "0x1569A80", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x6000005")]
	protected private override void DeserializeSection(XmlReader reader) { }

	[Address(RVA = "0x156A8B0", Offset = "0x1569AB0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x6000006")]
	protected private virtual bool IsModified() { }

	[Address(RVA = "0x156A8E0", Offset = "0x1569AE0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x6000007")]
	protected private virtual void ResetModified() { }

	[Address(RVA = "0x156A910", Offset = "0x1569B10", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x6000008")]
	protected private override string SerializeSection(ConfigurationElement parentElement, string name, ConfigurationSaveMode saveMode) { }

}

