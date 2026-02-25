namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x2000016")]
public class PackageManagerTestAnalytic : PackageManagerBaseAnalytic
{

	[Address(RVA = "0x1CF5FD0", Offset = "0x1CF51D0", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000026")]
	public PackageManagerTestAnalytic() { }

	[Address(RVA = "0x1CF5F20", Offset = "0x1CF5120", Length = "0xAB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	[RequiredByNativeCode]
	[Token(Token = "0x6000027")]
	internal static PackageManagerTestAnalytic CreatePackageManagerTestAnalytic() { }

}

