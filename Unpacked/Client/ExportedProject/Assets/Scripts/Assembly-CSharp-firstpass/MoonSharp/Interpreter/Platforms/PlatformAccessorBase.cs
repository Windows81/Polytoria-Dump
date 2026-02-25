namespace MoonSharp.Interpreter.Platforms;

[Token(Token = "0x20000B8")]
public abstract class PlatformAccessorBase : IPlatformAccessor
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000805")]
	protected PlatformAccessorBase() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Obsolete("Replace with DefaultInput(string)")]
	[Token(Token = "0x60007F8")]
	public override string DefaultInput() { }

	[Address(RVA = "0x327780", Offset = "0x326980", Length = "0x14")]
	[CallerCount(Count = 19)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007F9")]
	public override string DefaultInput(string prompt) { }

	[Token(Token = "0x60007F7")]
	public abstract void DefaultPrint(string content) { }

	[Token(Token = "0x6000802")]
	public abstract CoreModules FilterSupportedCoreModules(CoreModules module) { }

	[Token(Token = "0x6000803")]
	public abstract string GetEnvironmentVariable(string envvarname) { }

	[Address(RVA = "0x3277A0", Offset = "0x3269A0", Length = "0x307")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007F4")]
	public override string GetPlatformName() { }

	[Token(Token = "0x60007F3")]
	public abstract string GetPlatformNamePrefix() { }

	[Address(RVA = "0x327AB0", Offset = "0x326CB0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60007F6")]
	private string GetUnityPlatformName() { }

	[Address(RVA = "0x327AE0", Offset = "0x326CE0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60007F5")]
	private string GetUnityRuntimeName() { }

	[Token(Token = "0x60007FB")]
	public abstract Stream IO_GetStandardStream(StandardFileType type) { }

	[Token(Token = "0x60007FA")]
	public abstract Stream IO_OpenFile(Script script, string filename, Encoding encoding, string mode) { }

	[Token(Token = "0x60007FC")]
	public abstract string IO_OS_GetTempFilename() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000804")]
	public override bool IsRunningOnAOT() { }

	[Token(Token = "0x6000801")]
	public abstract int OS_Execute(string cmdline) { }

	[Token(Token = "0x60007FD")]
	public abstract void OS_ExitFast(int exitCode) { }

	[Token(Token = "0x60007FF")]
	public abstract void OS_FileDelete(string file) { }

	[Token(Token = "0x60007FE")]
	public abstract bool OS_FileExists(string file) { }

	[Token(Token = "0x6000800")]
	public abstract void OS_FileMove(string src, string dst) { }

}

