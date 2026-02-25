namespace UnityEngine.Analytics;

[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x20002A4")]
internal class BatchRenderGroupUsageAnalytic : AnalyticsEventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40006EE")]
	public int maxBRGInstance; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40006EF")]
	public int maxMeshCount; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40006F0")]
	public int maxMaterialCount; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40006F1")]
	public int maxDrawCommandBatch; //Field offset: 0x3C

	[Address(RVA = "0x197B320", Offset = "0x197A520", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D6B")]
	public BatchRenderGroupUsageAnalytic() { }

	[Address(RVA = "0x197B260", Offset = "0x197A460", Length = "0xBB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000D6C")]
	public static BatchRenderGroupUsageAnalytic CreateBatchRenderGroupUsageAnalytic() { }

}

