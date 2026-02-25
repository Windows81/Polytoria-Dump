namespace MoonSharp.Interpreter.Loaders;

[Token(Token = "0x20000BF")]
internal class InvalidScriptLoader : IScriptLoader
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400037C")]
	private string m_Error; //Field offset: 0x10

	[Address(RVA = "0x3228E0", Offset = "0x321AE0", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000830")]
	internal InvalidScriptLoader(string frameworkname) { }

	[Address(RVA = "0x322840", Offset = "0x321A40", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000831")]
	public override object LoadFile(string file, Table globalContext) { }

	[Address(RVA = "0x2DAD20", Offset = "0x2D9F20", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000832")]
	public override string ResolveFileName(string filename, Table globalContext) { }

	[Address(RVA = "0x322890", Offset = "0x321A90", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000833")]
	public override string ResolveModuleName(string modname, Table globalContext) { }

}

