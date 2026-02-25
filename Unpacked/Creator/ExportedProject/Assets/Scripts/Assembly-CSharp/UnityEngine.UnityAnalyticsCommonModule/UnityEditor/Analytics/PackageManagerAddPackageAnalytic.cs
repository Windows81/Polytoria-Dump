namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x2000015")]
public class PackageManagerAddPackageAnalytic : PackageManagerBaseAnalytic
{

	[Address(RVA = "0x1CF5720", Offset = "0x1CF4920", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000024")]
	public PackageManagerAddPackageAnalytic() { }

	[Address(RVA = "0x1CF5670", Offset = "0x1CF4870", Length = "0xAB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	[RequiredByNativeCode]
	[Token(Token = "0x6000025")]
	internal static PackageManagerAddPackageAnalytic CreatePackageManagerAddPackageAnalytic() { }

}

