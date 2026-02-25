namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x2000018")]
public class PackageManagerResolvePackageAnalytic : PackageManagerBaseAnalytic
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400003F")]
	public String[] packages; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000040")]
	public String[] package_registries; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000041")]
	public String[] package_signatures; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000042")]
	public String[] package_sources; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000043")]
	public String[] package_types; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000044")]
	public String[] package_compliance_statuses; //Field offset: 0x88

	[Address(RVA = "0x1CF5D70", Offset = "0x1CF4F70", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600002A")]
	public PackageManagerResolvePackageAnalytic() { }

	[Address(RVA = "0x1CF5CC0", Offset = "0x1CF4EC0", Length = "0xAB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	[RequiredByNativeCode]
	[Token(Token = "0x600002B")]
	internal static PackageManagerResolvePackageAnalytic CreatePackageManagerResolvePackageAnalytic() { }

}

