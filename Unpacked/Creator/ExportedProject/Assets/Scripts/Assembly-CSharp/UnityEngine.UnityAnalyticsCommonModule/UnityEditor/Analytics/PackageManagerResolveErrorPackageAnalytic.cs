namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x200001B")]
public class PackageManagerResolveErrorPackageAnalytic : PackageManagerBaseAnalytic
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000045")]
	public string reason; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000046")]
	public string action; //Field offset: 0x68

	[Address(RVA = "0x1CF5C40", Offset = "0x1CF4E40", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000030")]
	public PackageManagerResolveErrorPackageAnalytic() { }

	[Address(RVA = "0x1CF5B90", Offset = "0x1CF4D90", Length = "0xAB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	[RequiredByNativeCode]
	[Token(Token = "0x6000031")]
	internal static PackageManagerResolveErrorPackageAnalytic CreatePackageManagerResolveErrorPackageAnalytic() { }

}

