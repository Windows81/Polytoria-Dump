namespace UnityEngine.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x20002A6")]
internal class ShaderRuntimeInfoAnalytic : AnalyticsEventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40006F4")]
	public long VariantsRequested; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40006F5")]
	public long VariantsRequestedMissing; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40006F6")]
	public long VariantsRequestedUnsupported; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40006F7")]
	public long VariantsRequestedCompiled; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40006F8")]
	public long VariantsRequestedViaWarmup; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40006F9")]
	public long VariantsUnused; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40006FA")]
	public int VariantsCompilationTimeTotal; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40006FB")]
	public int VariantsCompilationTimeMax; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40006FC")]
	public int VariantsCompilationTimeMedian; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40006FD")]
	public int VariantsWarmupTimeTotal; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40006FE")]
	public int VariantsWarmupTimeMax; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x40006FF")]
	public int VariantsWarmupTimeMedian; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000700")]
	public bool UseProgressiveWarmup; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000701")]
	public int ShaderChunkSizeMin; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000702")]
	public int ShaderChunkSizeMax; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4000703")]
	public int ShaderChunkSizeAvg; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000704")]
	public int ShaderChunkCountMin; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x4000705")]
	public int ShaderChunkCountMax; //Field offset: 0x8C
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000706")]
	public int ShaderChunkCountAvg; //Field offset: 0x90

	[Address(RVA = "0x198E900", Offset = "0x198DB00", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D6F")]
	private ShaderRuntimeInfoAnalytic() { }

	[Address(RVA = "0x198E800", Offset = "0x198DA00", Length = "0xFD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000D70")]
	public static ShaderRuntimeInfoAnalytic CreateShaderRuntimeInfoAnalytic() { }

}

