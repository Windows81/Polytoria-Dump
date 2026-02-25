namespace System.Net;

[Token(Token = "0x200021A")]
internal class FtpMethodInfo
{
	[Token(Token = "0x4000865")]
	private static readonly FtpMethodInfo[] s_knownMethodInfo; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000861")]
	internal string Method; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000862")]
	internal FtpOperation Operation; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000863")]
	internal FtpMethodFlags Flags; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000864")]
	internal string HttpCommand; //Field offset: 0x20

	[Token(Token = "0x17000293")]
	internal bool IsCommandOnly
	{
		[Address(RVA = "0x17D4D60", Offset = "0x17D3F60", Length = "0x8")]
		[CalledBy(Type = typeof(FtpControlStream), Member = "BuildCommandsList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebRequest)}, ReturnType = typeof(PipelineEntry[]))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000D8A")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000295")]
	internal bool IsDownload
	{
		[Address(RVA = "0x162C340", Offset = "0x162B540", Length = "0x7")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D8C")]
		internal get { } //Length: 7
	}

	[Token(Token = "0x17000294")]
	internal bool IsUpload
	{
		[Address(RVA = "0x17D4D70", Offset = "0x17D3F70", Length = "0x8")]
		[CalledBy(Type = typeof(FtpControlStream), Member = "IsFtpDataStreamWriteable", ReturnType = typeof(TriState))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000D8B")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000296")]
	internal bool ShouldParseForResponseUri
	{
		[Address(RVA = "0x17D4D80", Offset = "0x17D3F80", Length = "0x8")]
		[CalledBy(Type = typeof(FtpControlStream), Member = "PipelineCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PipelineEntry), typeof(ResponseDescription), typeof(bool), typeof(Stream&)}, ReturnType = typeof(PipelineInstruction))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000D8D")]
		internal get { } //Length: 8
	}

	[Address(RVA = "0x17D4430", Offset = "0x17D3630", Length = "0x8B8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 13)]
	[Token(Token = "0x6000D8F")]
	private static FtpMethodInfo() { }

	[Address(RVA = "0x17D4CF0", Offset = "0x17D3EF0", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D88")]
	internal FtpMethodInfo(string method, FtpOperation operation, FtpMethodFlags flags, string httpCommand) { }

	[Address(RVA = "0x17D4D60", Offset = "0x17D3F60", Length = "0x8")]
	[CalledBy(Type = typeof(FtpControlStream), Member = "BuildCommandsList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebRequest)}, ReturnType = typeof(PipelineEntry[]))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D8A")]
	internal bool get_IsCommandOnly() { }

	[Address(RVA = "0x162C340", Offset = "0x162B540", Length = "0x7")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D8C")]
	internal bool get_IsDownload() { }

	[Address(RVA = "0x17D4D70", Offset = "0x17D3F70", Length = "0x8")]
	[CalledBy(Type = typeof(FtpControlStream), Member = "IsFtpDataStreamWriteable", ReturnType = typeof(TriState))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D8B")]
	internal bool get_IsUpload() { }

	[Address(RVA = "0x17D4D80", Offset = "0x17D3F80", Length = "0x8")]
	[CalledBy(Type = typeof(FtpControlStream), Member = "PipelineCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PipelineEntry), typeof(ResponseDescription), typeof(bool), typeof(Stream&)}, ReturnType = typeof(PipelineInstruction))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D8D")]
	internal bool get_ShouldParseForResponseUri() { }

	[Address(RVA = "0x17D42B0", Offset = "0x17D34B0", Length = "0x162")]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "set_Method", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "ToUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D8E")]
	internal static FtpMethodInfo GetMethodInfo(string method) { }

	[Address(RVA = "0x17D4420", Offset = "0x17D3620", Length = "0x7")]
	[CalledBy(Type = typeof(FtpControlStream), Member = "BuildCommandsList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebRequest)}, ReturnType = typeof(PipelineEntry[]))]
	[CallerCount(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D89")]
	internal bool HasFlag(FtpMethodFlags flags) { }

}

