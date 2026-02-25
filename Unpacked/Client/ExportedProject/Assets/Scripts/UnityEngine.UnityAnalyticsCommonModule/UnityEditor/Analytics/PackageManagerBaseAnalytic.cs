namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x2000014")]
public class PackageManagerBaseAnalytic : AnalyticsEventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000039")]
	public long start_ts; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400003A")]
	public long duration; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400003B")]
	public bool blocking; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400003C")]
	public string package_id; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400003D")]
	public int status_code; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400003E")]
	public string error_message; //Field offset: 0x58

	[Address(RVA = "0x1CF57A0", Offset = "0x1CF49A0", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000023")]
	public PackageManagerBaseAnalytic(string eventName) { }

}

