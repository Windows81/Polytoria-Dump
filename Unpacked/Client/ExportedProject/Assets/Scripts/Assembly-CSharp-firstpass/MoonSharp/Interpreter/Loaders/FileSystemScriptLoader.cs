namespace MoonSharp.Interpreter.Loaders;

[Token(Token = "0x20000BE")]
public class FileSystemScriptLoader : ScriptLoaderBase
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600082F")]
	public FileSystemScriptLoader() { }

	[Address(RVA = "0x31D240", Offset = "0x31C440", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode), typeof(FileAccess), typeof(FileShare)}, ReturnType = typeof(void))]
	[Token(Token = "0x600082E")]
	public virtual object LoadFile(string file, Table globalContext) { }

	[Address(RVA = "0x31D2B0", Offset = "0x31C4B0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(File), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x600082D")]
	public virtual bool ScriptFileExists(string name) { }

}

