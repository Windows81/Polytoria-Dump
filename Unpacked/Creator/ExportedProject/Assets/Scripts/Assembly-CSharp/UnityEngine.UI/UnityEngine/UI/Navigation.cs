namespace UnityEngine.UI;

[Token(Token = "0x200005C")]
public struct Navigation : IEquatable<Navigation>
{
	[Flags]
	[Token(Token = "0x200005D")]
	internal enum Mode
	{
		None = 0,
		Horizontal = 1,
		Vertical = 2,
		Automatic = 3,
		Explicit = 4,
	}

	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x40001A7")]
	private Mode m_Mode; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	[Token(Token = "0x40001A8")]
	[Tooltip("Enables navigation to wrap around from last to first or first to last element. Does not work for automatic grid navigation")]
	private bool m_WrapAround; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x40001A9")]
	private Selectable m_SelectOnUp; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x40001AA")]
	private Selectable m_SelectOnDown; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40001AB")]
	private Selectable m_SelectOnLeft; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40001AC")]
	private Selectable m_SelectOnRight; //Field offset: 0x20

	[Token(Token = "0x170000E3")]
	public static Navigation defaultNavigation
	{
		[Address(RVA = "0x1CC91A0", Offset = "0x1CC83A0", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600037B")]
		 get { } //Length: 26
	}

	[Token(Token = "0x170000DD")]
	public Mode mode
	{
		[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
		[CallerCount(Count = 129)]
		[DeduplicatedMethod]
		[Token(Token = "0x600036F")]
		 get { } //Length: 3
		[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000370")]
		 set { } //Length: 3
	}

	[Token(Token = "0x170000E0")]
	public Selectable selectOnDown
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000375")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000376")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170000E1")]
	public Selectable selectOnLeft
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000377")]
		 get { } //Length: 5
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000378")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170000E2")]
	public Selectable selectOnRight
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000379")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600037A")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170000DF")]
	public Selectable selectOnUp
	{
		[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000373")]
		 get { } //Length: 5
		[Address(RVA = "0x344920", Offset = "0x343B20", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000374")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170000DE")]
	public bool wrapAround
	{
		[Address(RVA = "0xCE3800", Offset = "0xCE2A00", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000371")]
		 get { } //Length: 5
		[Address(RVA = "0x18FCBD0", Offset = "0x18FBDD0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000372")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x1CC9090", Offset = "0x1CC8290", Length = "0x10C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600037C")]
	public override bool Equals(Navigation other) { }

	[Address(RVA = "0x1CC91A0", Offset = "0x1CC83A0", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600037B")]
	public static Navigation get_defaultNavigation() { }

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[DeduplicatedMethod]
	[Token(Token = "0x600036F")]
	public Mode get_mode() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000375")]
	public Selectable get_selectOnDown() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000377")]
	public Selectable get_selectOnLeft() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000379")]
	public Selectable get_selectOnRight() { }

	[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000373")]
	public Selectable get_selectOnUp() { }

	[Address(RVA = "0xCE3800", Offset = "0xCE2A00", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000371")]
	public bool get_wrapAround() { }

	[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000370")]
	public void set_mode(Mode value) { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000376")]
	public void set_selectOnDown(Selectable value) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000378")]
	public void set_selectOnLeft(Selectable value) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600037A")]
	public void set_selectOnRight(Selectable value) { }

	[Address(RVA = "0x344920", Offset = "0x343B20", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000374")]
	public void set_selectOnUp(Selectable value) { }

	[Address(RVA = "0x18FCBD0", Offset = "0x18FBDD0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000372")]
	public void set_wrapAround(bool value) { }

}

