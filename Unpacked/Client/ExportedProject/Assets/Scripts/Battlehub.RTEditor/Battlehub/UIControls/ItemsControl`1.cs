namespace Battlehub.UIControls;

[Token(Token = "0x2000028")]
public class ItemsControl : ItemsControl
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000069")]
	private EventHandler<TDataBindingArgs> ItemDataBinding; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400006A")]
	private EventHandler<TDataBindingArgs> ItemBeginEdit; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400006B")]
	private EventHandler<TDataBindingArgs> ItemEndEdit; //Field offset: 0x0

	[Token(Token = "0x14000011")]
	public event EventHandler<TDataBindingArgs> ItemBeginEdit
	{
		[Address(RVA = "0xCBEBF0", Offset = "0xCBDDF0", Length = "0xC2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000115")]
		 add { } //Length: 194
		[Address(RVA = "0xCBEE60", Offset = "0xCBE060", Length = "0xC2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000116")]
		 remove { } //Length: 194
	}

	[Token(Token = "0x14000010")]
	public event EventHandler<TDataBindingArgs> ItemDataBinding
	{
		[Address(RVA = "0xCBECC0", Offset = "0xCBDEC0", Length = "0xC2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000113")]
		 add { } //Length: 194
		[Address(RVA = "0xCBEF30", Offset = "0xCBE130", Length = "0xC2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000114")]
		 remove { } //Length: 194
	}

	[Token(Token = "0x14000012")]
	public event EventHandler<TDataBindingArgs> ItemEndEdit
	{
		[Address(RVA = "0xCBED90", Offset = "0xCBDF90", Length = "0xC2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000117")]
		 add { } //Length: 194
		[Address(RVA = "0xCBF000", Offset = "0xCBE200", Length = "0xC2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000118")]
		 remove { } //Length: 194
	}

	[Address(RVA = "0xCBEBE0", Offset = "0xCBDDE0", Length = "0x7")]
	[CalledBy(Type = typeof(ListBox), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TreeView), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ItemsControl), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600011D")]
	public ItemsControl`1() { }

	[Address(RVA = "0xCBEBF0", Offset = "0xCBDDF0", Length = "0xC2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000115")]
	public void add_ItemBeginEdit(EventHandler<TDataBindingArgs> value) { }

	[Address(RVA = "0xCBECC0", Offset = "0xCBDEC0", Length = "0xC2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000113")]
	public void add_ItemDataBinding(EventHandler<TDataBindingArgs> value) { }

	[Address(RVA = "0xCBED90", Offset = "0xCBDF90", Length = "0xC2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000117")]
	public void add_ItemEndEdit(EventHandler<TDataBindingArgs> value) { }

	[Address(RVA = "0xCBE6C0", Offset = "0xCBD8C0", Length = "0x16B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600011B")]
	public virtual void DataBindItem(object item, ItemContainer itemContainer) { }

	[Address(RVA = "0xCBE830", Offset = "0xCBDA30", Length = "0x1BB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ItemsControl), Member = "CanHandleEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000119")]
	protected virtual void OnItemBeginEdit(object sender, EventArgs e) { }

	[Address(RVA = "0xCBE9F0", Offset = "0xCBDBF0", Length = "0x1BB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ItemsControl), Member = "CanHandleEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600011A")]
	protected virtual void OnItemEndEdit(object sender, EventArgs e) { }

	[Address(RVA = "0xCBEBB0", Offset = "0xCBDDB0", Length = "0x27")]
	[CalledBy(Type = typeof(TreeView), Member = "DataBindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ItemContainer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600011C")]
	protected void RaiseItemDataBinding(TDataBindingArgs args) { }

	[Address(RVA = "0xCBEE60", Offset = "0xCBE060", Length = "0xC2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000116")]
	public void remove_ItemBeginEdit(EventHandler<TDataBindingArgs> value) { }

	[Address(RVA = "0xCBEF30", Offset = "0xCBE130", Length = "0xC2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000114")]
	public void remove_ItemDataBinding(EventHandler<TDataBindingArgs> value) { }

	[Address(RVA = "0xCBF000", Offset = "0xCBE200", Length = "0xC2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000118")]
	public void remove_ItemEndEdit(EventHandler<TDataBindingArgs> value) { }

}

