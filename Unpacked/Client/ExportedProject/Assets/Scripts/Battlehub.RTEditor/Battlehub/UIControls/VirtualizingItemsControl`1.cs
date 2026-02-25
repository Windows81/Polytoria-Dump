namespace Battlehub.UIControls;

[Token(Token = "0x200003D")]
public class VirtualizingItemsControl : VirtualizingItemsControl
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000F7")]
	private EventHandler<TDataBindingArgs> ItemDataBinding; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000F8")]
	private EventHandler<TDataBindingArgs> ItemBeginEdit; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000F9")]
	private EventHandler<TDataBindingArgs> ItemEndEdit; //Field offset: 0x0

	[Token(Token = "0x1400002E")]
	public event EventHandler<TDataBindingArgs> ItemBeginEdit
	{
		[Address(RVA = "0x92F2B0", Offset = "0x92E4B0", Length = "0xC2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000245")]
		 add { } //Length: 194
		[Address(RVA = "0x92F520", Offset = "0x92E720", Length = "0xC2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000246")]
		 remove { } //Length: 194
	}

	[Token(Token = "0x1400002D")]
	public event EventHandler<TDataBindingArgs> ItemDataBinding
	{
		[Address(RVA = "0x92F380", Offset = "0x92E580", Length = "0xC2")]
		[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000243")]
		 add { } //Length: 194
		[Address(RVA = "0x92F5F0", Offset = "0x92E7F0", Length = "0xC2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000244")]
		 remove { } //Length: 194
	}

	[Token(Token = "0x1400002F")]
	public event EventHandler<TDataBindingArgs> ItemEndEdit
	{
		[Address(RVA = "0x92F450", Offset = "0x92E650", Length = "0xC2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000247")]
		 add { } //Length: 194
		[Address(RVA = "0x92F6C0", Offset = "0x92E8C0", Length = "0xC2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000248")]
		 remove { } //Length: 194
	}

	[Address(RVA = "0x92F2A0", Offset = "0x92E4A0", Length = "0x7")]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600024D")]
	public VirtualizingItemsControl`1() { }

	[Address(RVA = "0x92F2B0", Offset = "0x92E4B0", Length = "0xC2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000245")]
	public void add_ItemBeginEdit(EventHandler<TDataBindingArgs> value) { }

	[Address(RVA = "0x92F380", Offset = "0x92E580", Length = "0xC2")]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000243")]
	public void add_ItemDataBinding(EventHandler<TDataBindingArgs> value) { }

	[Address(RVA = "0x92F450", Offset = "0x92E650", Length = "0xC2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000247")]
	public void add_ItemEndEdit(EventHandler<TDataBindingArgs> value) { }

	[Address(RVA = "0x92ED10", Offset = "0x92DF10", Length = "0x199")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600024B")]
	public virtual void DataBindItem(object item, VirtualizingItemContainer itemContainer) { }

	[Address(RVA = "0x92EEB0", Offset = "0x92E0B0", Length = "0x1D1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "CanHandleEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000249")]
	protected virtual void OnItemBeginEdit(object sender, EventArgs e) { }

	[Address(RVA = "0x92F090", Offset = "0x92E290", Length = "0x1DE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "CanHandleEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "set_IsSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600024A")]
	protected virtual void OnItemEndEdit(object sender, EventArgs e) { }

	[Address(RVA = "0x92F270", Offset = "0x92E470", Length = "0x27")]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "DataBindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(VirtualizingItemContainer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600024C")]
	protected void RaiseItemDataBinding(TDataBindingArgs args) { }

	[Address(RVA = "0x92F520", Offset = "0x92E720", Length = "0xC2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000246")]
	public void remove_ItemBeginEdit(EventHandler<TDataBindingArgs> value) { }

	[Address(RVA = "0x92F5F0", Offset = "0x92E7F0", Length = "0xC2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000244")]
	public void remove_ItemDataBinding(EventHandler<TDataBindingArgs> value) { }

	[Address(RVA = "0x92F6C0", Offset = "0x92E8C0", Length = "0xC2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000248")]
	public void remove_ItemEndEdit(EventHandler<TDataBindingArgs> value) { }

}

