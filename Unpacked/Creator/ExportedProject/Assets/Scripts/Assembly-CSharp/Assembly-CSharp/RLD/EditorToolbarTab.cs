namespace RLD;

[Token(Token = "0x2000157")]
public class EditorToolbarTab
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x400062D")]
	private string _tooltip; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x400062E")]
	private string _text; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400062F")]
	private EditorToolbar _targetToolbar; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000630")]
	private List<Settings> _targetSettings; //Field offset: 0x28

	[Token(Token = "0x1700054C")]
	public int NumTargetSettings
	{
		[Address(RVA = "0x53F470", Offset = "0x53E670", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000F98")]
		 get { } //Length: 60
	}

	[Token(Token = "0x1700054B")]
	public EditorToolbar TargetToolbar
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F96")]
		 get { } //Length: 5
		[Address(RVA = "0x53F4B0", Offset = "0x53E6B0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000F97")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700054A")]
	public string Text
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F94")]
		 get { } //Length: 5
		[Address(RVA = "0x53F4D0", Offset = "0x53E6D0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F95")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000549")]
	public string Tooltip
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F92")]
		 get { } //Length: 5
		[Address(RVA = "0x53F4F0", Offset = "0x53E6F0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000F93")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x53F370", Offset = "0x53E570", Length = "0xFE")]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000F91")]
	public EditorToolbarTab(string text, string tooltip) { }

	[Address(RVA = "0x53F290", Offset = "0x53E490", Length = "0xD6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000F99")]
	public void AddTargetSettings(Settings targetSettings) { }

	[Address(RVA = "0x53F470", Offset = "0x53E670", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F98")]
	public int get_NumTargetSettings() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F96")]
	public EditorToolbar get_TargetToolbar() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F94")]
	public string get_Text() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F92")]
	public string get_Tooltip() { }

	[Address(RVA = "0x53F4B0", Offset = "0x53E6B0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000F97")]
	public void set_TargetToolbar(EditorToolbar value) { }

	[Address(RVA = "0x53F4D0", Offset = "0x53E6D0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F95")]
	public void set_Text(string value) { }

	[Address(RVA = "0x53F4F0", Offset = "0x53E6F0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000F93")]
	public void set_Tooltip(string value) { }

}

