namespace MoonSharp.Interpreter.CoreLib.IO;

[Token(Token = "0x2000193")]
internal class StandardIOFileUserDataBase : StreamFileUserDataBase
{

	[Address(RVA = "0x394AF0", Offset = "0x393CF0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EDA")]
	public StandardIOFileUserDataBase() { }

	[Address(RVA = "0x3A1E80", Offset = "0x3A1080", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000ED7")]
	protected virtual string Close() { }

	[Address(RVA = "0x3A1EB0", Offset = "0x3A10B0", Length = "0xC0")]
	[CalledBy(Type = typeof(IoModule), Member = "MoonSharpInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table), typeof(Table)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IoModule), Member = "SetStandardFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(StandardFileType), typeof(Stream)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IoModule), Member = "SetDefaultFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(StandardFileType), typeof(Stream)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000ED8")]
	public static StandardIOFileUserDataBase CreateInputStream(Stream stream) { }

	[Address(RVA = "0x3A1F80", Offset = "0x3A1180", Length = "0xC0")]
	[CalledBy(Type = typeof(IoModule), Member = "MoonSharpInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table), typeof(Table)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IoModule), Member = "SetStandardFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(StandardFileType), typeof(Stream)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IoModule), Member = "SetDefaultFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(StandardFileType), typeof(Stream)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000ED9")]
	public static StandardIOFileUserDataBase CreateOutputStream(Stream stream) { }

}

