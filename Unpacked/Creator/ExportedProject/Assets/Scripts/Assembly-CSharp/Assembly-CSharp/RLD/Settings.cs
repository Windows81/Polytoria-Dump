namespace RLD;

[Token(Token = "0x2000158")]
public abstract class Settings
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000631")]
	private bool _canBeDisplayed; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[SerializeField]
	[Token(Token = "0x4000632")]
	protected bool _isExpanded; //Field offset: 0x11
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000633")]
	private string _foldoutLabel; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000634")]
	private bool <UsesFoldout>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x1700054D")]
	public bool CanBeDisplayed
	{
		[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F9A")]
		 get { } //Length: 5
		[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F9B")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700054F")]
	public string FoldoutLabel
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F9E")]
		 get { } //Length: 5
		[Address(RVA = "0x53F4D0", Offset = "0x53E6D0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F9F")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000550")]
	public bool IsExpanded
	{
		[Address(RVA = "0x3CE370", Offset = "0x3CD570", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FA0")]
		 get { } //Length: 5
		[Address(RVA = "0x3CE380", Offset = "0x3CD580", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FA1")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700054E")]
	public bool UsesFoldout
	{
		[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F9C")]
		 get { } //Length: 5
		[Address(RVA = "0x309220", Offset = "0x308420", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F9D")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x54CCF0", Offset = "0x54BEF0", Length = "0x55")]
	[CallerCount(Count = 63)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000FA2")]
	protected Settings() { }

	[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F9A")]
	public bool get_CanBeDisplayed() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F9E")]
	public string get_FoldoutLabel() { }

	[Address(RVA = "0x3CE370", Offset = "0x3CD570", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FA0")]
	public bool get_IsExpanded() { }

	[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F9C")]
	public bool get_UsesFoldout() { }

	[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F9B")]
	public void set_CanBeDisplayed(bool value) { }

	[Address(RVA = "0x53F4D0", Offset = "0x53E6D0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F9F")]
	public void set_FoldoutLabel(string value) { }

	[Address(RVA = "0x3CE380", Offset = "0x3CD580", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FA1")]
	public void set_IsExpanded(bool value) { }

	[Address(RVA = "0x309220", Offset = "0x308420", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F9D")]
	public void set_UsesFoldout(bool value) { }

}

