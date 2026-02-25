namespace UnityEngine.Analytics;

[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x20002A3")]
public class AnalyticsEventBase
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006EA")]
	private string eventName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006EB")]
	private int eventVersion; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006EC")]
	private string eventPrefix; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40006ED")]
	private SendEventOptions sendEventOptions; //Field offset: 0x28

	[Address(RVA = "0x1979CF0", Offset = "0x1978EF0", Length = "0x63")]
	[CallerCount(Count = 67)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D6A")]
	public AnalyticsEventBase(string eventName, int eventVersion, SendEventOptions sendEventOptions = 0, string eventPrefix = "") { }

}

