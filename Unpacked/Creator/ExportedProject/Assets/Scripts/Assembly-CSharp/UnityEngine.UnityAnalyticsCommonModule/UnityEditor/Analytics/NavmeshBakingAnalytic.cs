namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x2000011")]
public class NavmeshBakingAnalytic : AnalyticsEventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000032")]
	private bool new_nav_api; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x4000033")]
	private bool bake_at_runtime; //Field offset: 0x31
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000034")]
	private int height_meshes_count; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000035")]
	private int offmesh_links_count; //Field offset: 0x38

	[Address(RVA = "0x1CF5600", Offset = "0x1CF4800", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600001D")]
	public NavmeshBakingAnalytic() { }

	[Address(RVA = "0x1CF5570", Offset = "0x1CF4770", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	[RequiredByNativeCode]
	[Token(Token = "0x600001E")]
	internal static NavmeshBakingAnalytic CreateNavmeshBakingAnalytic() { }

}

