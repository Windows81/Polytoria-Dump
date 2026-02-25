namespace Battlehub.UIControls;

[Token(Token = "0x2000024")]
public class ItemDataBindingArgs : EventArgs
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000059")]
	private object <Item>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400005A")]
	private GameObject <ItemPresenter>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400005B")]
	private GameObject <EditorPresenter>k__BackingField; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400005C")]
	private bool m_canEdit; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x400005D")]
	private bool m_canDrag; //Field offset: 0x29
	[FieldOffset(Offset = "0x2A")]
	[Token(Token = "0x400005E")]
	private bool m_canDrop; //Field offset: 0x2A
	[FieldOffset(Offset = "0x2B")]
	[Token(Token = "0x400005F")]
	private bool m_canReparent; //Field offset: 0x2B
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000060")]
	private bool m_canSelect; //Field offset: 0x2C

	[Token(Token = "0x17000048")]
	public bool CanBeParent
	{
		[Address(RVA = "0x3893E0", Offset = "0x3885E0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000F9")]
		 get { } //Length: 5
		[Address(RVA = "0x389400", Offset = "0x388600", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000FA")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000049")]
	public bool CanChangeParent
	{
		[Address(RVA = "0x5C6FE0", Offset = "0x5C61E0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000FB")]
		 get { } //Length: 5
		[Address(RVA = "0x5C6FF0", Offset = "0x5C61F0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000FC")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000047")]
	public bool CanDrag
	{
		[Address(RVA = "0x339410", Offset = "0x338610", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000F7")]
		 get { } //Length: 5
		[Address(RVA = "0x339450", Offset = "0x338650", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000F8")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000046")]
	public bool CanEdit
	{
		[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000F5")]
		 get { } //Length: 5
		[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000F6")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700004A")]
	public bool CanSelect
	{
		[Address(RVA = "0x3BAA00", Offset = "0x3B9C00", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000FD")]
		 get { } //Length: 5
		[Address(RVA = "0x3BAA20", Offset = "0x3B9C20", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000FE")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000045")]
	public GameObject EditorPresenter
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000F3")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000F4")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000043")]
	public object Item
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000EF")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000F0")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000044")]
	public GameObject ItemPresenter
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000F1")]
		 get { } //Length: 5
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000F2")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x5C6F80", Offset = "0x5C6180", Length = "0x54")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FF")]
	public ItemDataBindingArgs() { }

	[Address(RVA = "0x3893E0", Offset = "0x3885E0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F9")]
	public bool get_CanBeParent() { }

	[Address(RVA = "0x5C6FE0", Offset = "0x5C61E0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FB")]
	public bool get_CanChangeParent() { }

	[Address(RVA = "0x339410", Offset = "0x338610", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F7")]
	public bool get_CanDrag() { }

	[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F5")]
	public bool get_CanEdit() { }

	[Address(RVA = "0x3BAA00", Offset = "0x3B9C00", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FD")]
	public bool get_CanSelect() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F3")]
	public GameObject get_EditorPresenter() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000EF")]
	public object get_Item() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F1")]
	public GameObject get_ItemPresenter() { }

	[Address(RVA = "0x389400", Offset = "0x388600", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FA")]
	public void set_CanBeParent(bool value) { }

	[Address(RVA = "0x5C6FF0", Offset = "0x5C61F0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FC")]
	public void set_CanChangeParent(bool value) { }

	[Address(RVA = "0x339450", Offset = "0x338650", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F8")]
	public void set_CanDrag(bool value) { }

	[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F6")]
	public void set_CanEdit(bool value) { }

	[Address(RVA = "0x3BAA20", Offset = "0x3B9C20", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FE")]
	public void set_CanSelect(bool value) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F4")]
	public void set_EditorPresenter(GameObject value) { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F0")]
	public void set_Item(object value) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F2")]
	public void set_ItemPresenter(GameObject value) { }

}

