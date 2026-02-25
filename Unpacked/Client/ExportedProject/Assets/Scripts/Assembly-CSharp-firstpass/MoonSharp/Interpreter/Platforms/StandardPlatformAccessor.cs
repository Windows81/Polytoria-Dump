namespace MoonSharp.Interpreter.Platforms;

[Token(Token = "0x20000BC")]
public class StandardPlatformAccessor : PlatformAccessorBase
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000828")]
	public StandardPlatformAccessor() { }

	[Address(RVA = "0x32B160", Offset = "0x32A360", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Console), Member = "WriteLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600081F")]
	public virtual void DefaultPrint(string content) { }

	[Address(RVA = "0x32B1B0", Offset = "0x32A3B0", Length = "0x3")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000826")]
	public virtual CoreModules FilterSupportedCoreModules(CoreModules module) { }

	[Address(RVA = "0x32B1C0", Offset = "0x32A3C0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "GetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x600081D")]
	public virtual string GetEnvironmentVariable(string envvarname) { }

	[Address(RVA = "0x32B1D0", Offset = "0x32A3D0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000827")]
	public virtual string GetPlatformNamePrefix() { }

	[Address(RVA = "0x32B200", Offset = "0x32A400", Length = "0xDD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Console), Member = "OpenStandardError", ReturnType = typeof(Stream))]
	[Calls(Type = typeof(Console), Member = "OpenStandardOutput", ReturnType = typeof(Stream))]
	[Calls(Type = typeof(Console), Member = "OpenStandardInput", ReturnType = typeof(Stream))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600081E")]
	public virtual Stream IO_GetStandardStream(StandardFileType type) { }

	[Address(RVA = "0x32B320", Offset = "0x32A520", Length = "0x24F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode), typeof(FileAccess), typeof(FileShare)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600081C")]
	public virtual Stream IO_OpenFile(Script script, string filename, Encoding encoding, string mode) { }

	[Address(RVA = "0x32B2E0", Offset = "0x32A4E0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Path), Member = "GetTempFileName", ReturnType = typeof(string))]
	[Token(Token = "0x6000820")]
	public virtual string IO_OS_GetTempFilename() { }

	[Address(RVA = "0x32B570", Offset = "0x32A770", Length = "0xB8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ProcessStartInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Process), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(Process))]
	[Calls(Type = typeof(Process), Member = "WaitForExit", ReturnType = typeof(void))]
	[Calls(Type = typeof(Process), Member = "get_ExitCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000825")]
	public virtual int OS_Execute(string cmdline) { }

	[Address(RVA = "0x32B630", Offset = "0x32A830", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000821")]
	public virtual void OS_ExitFast(int exitCode) { }

	[Address(RVA = "0x32B640", Offset = "0x32A840", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(File), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000823")]
	public virtual void OS_FileDelete(string file) { }

	[Address(RVA = "0x31D2B0", Offset = "0x31C4B0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(File), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000822")]
	public virtual bool OS_FileExists(string file) { }

	[Address(RVA = "0x32B650", Offset = "0x32A850", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(File), Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000824")]
	public virtual void OS_FileMove(string src, string dst) { }

	[Address(RVA = "0x32B670", Offset = "0x32A870", Length = "0x100")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600081A")]
	public static FileAccess ParseFileAccess(string mode) { }

	[Address(RVA = "0x32B780", Offset = "0x32A980", Length = "0x10D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600081B")]
	public static FileMode ParseFileMode(string mode) { }

}

