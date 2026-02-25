namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x200001D")]
internal class AssetImportStatusAnalytic : AnalyticsEventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000047")]
	public string package_name; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000048")]
	public int package_items_count; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000049")]
	public int package_import_status; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400004A")]
	public string error_message; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400004B")]
	public int project_assets_count; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400004C")]
	public int unselected_assets_count; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400004D")]
	public int selected_new_assets_count; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x400004E")]
	public int selected_changed_assets_count; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400004F")]
	public int unchanged_assets_count; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000050")]
	public String[] selected_asset_extensions; //Field offset: 0x60

	[Address(RVA = "0x1CF5000", Offset = "0x1CF4200", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000034")]
	public AssetImportStatusAnalytic() { }

	[Address(RVA = "0x1CF4F60", Offset = "0x1CF4160", Length = "0x92")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	[RequiredByNativeCode]
	[Token(Token = "0x6000035")]
	public static AssetImportStatusAnalytic CreateAssetImportStatusAnalytic() { }

}

