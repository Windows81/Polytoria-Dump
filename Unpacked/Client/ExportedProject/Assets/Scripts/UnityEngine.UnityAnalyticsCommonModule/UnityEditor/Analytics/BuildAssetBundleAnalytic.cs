namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x200000C")]
public class BuildAssetBundleAnalytic : AnalyticsEventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400001F")]
	public bool success; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000020")]
	public string error; //Field offset: 0x38

	[Address(RVA = "0x1CF5100", Offset = "0x1CF4300", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000013")]
	public BuildAssetBundleAnalytic() { }

	[Address(RVA = "0x1CF5070", Offset = "0x1CF4270", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	[RequiredByNativeCode]
	[Token(Token = "0x6000014")]
	internal static BuildAssetBundleAnalytic CreateBuildAssetBundleAnalytic() { }

}

