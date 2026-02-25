namespace MoonSharp.Interpreter.REPL;

[Token(Token = "0x20000B4")]
public class ReplInterpreterScriptLoader : FileSystemScriptLoader
{

	[Address(RVA = "0x328C80", Offset = "0x327E80", Length = "0x144")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Environment), Member = "GetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptLoaderBase), Member = "UnpackStringPaths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60007D6")]
	public ReplInterpreterScriptLoader() { }

	[Address(RVA = "0x328B70", Offset = "0x327D70", Length = "0x10B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Table), Member = "RawGet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "get_String", ReturnType = typeof(string))]
	[Calls(Type = typeof(ScriptLoaderBase), Member = "UnpackStringPaths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60007D7")]
	public virtual string ResolveModuleName(string modname, Table globalContext) { }

}

