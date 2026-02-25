namespace MoonSharp.Interpreter.CoreLib.IO;

[Token(Token = "0x2000190")]
internal class FileUserData : StreamFileUserDataBase
{

	[Address(RVA = "0x3957F0", Offset = "0x3949F0", Length = "0x243")]
	[CalledBy(Type = typeof(IoModule), Member = "open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(IoModule), Member = "tmpfile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(IoModule), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(string), typeof(Encoding), typeof(string)}, ReturnType = typeof(FileUserDataBase))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000EC0")]
	public FileUserData(Script script, string filename, Encoding encoding, string mode) { }

}

