namespace UnityEngine.Analytics;

[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x20002A5")]
internal class UaaLApplicationLaunchAnalytic : AnalyticsEventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40006F2")]
	public int launch_type; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40006F3")]
	public int launch_process_type; //Field offset: 0x34

	[Address(RVA = "0x1992260", Offset = "0x1991460", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D6D")]
	public UaaLApplicationLaunchAnalytic() { }

	[Address(RVA = "0x19921A0", Offset = "0x19913A0", Length = "0xBB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000D6E")]
	public static UaaLApplicationLaunchAnalytic CreateUaaLApplicationLaunchAnalytic() { }

}

