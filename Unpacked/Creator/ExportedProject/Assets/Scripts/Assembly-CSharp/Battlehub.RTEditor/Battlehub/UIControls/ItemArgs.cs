namespace Battlehub.UIControls;

[Token(Token = "0x2000025")]
public class ItemArgs : EventArgs
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000061")]
	private Object[] <Items>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000062")]
	private PointerEventData <PointerEventData>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x1700004B")]
	public private Object[] Items
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000100")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000101")]
		private set { } //Length: 13
	}

	[Token(Token = "0x1700004C")]
	public private PointerEventData PointerEventData
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000102")]
		 get { } //Length: 5
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000103")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x5C4DB0", Offset = "0x5C3FB0", Length = "0x82")]
	[CalledBy(Type = typeof(ItemsControl), Member = "OnItemDoubleClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ItemContainer), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ItemsControl), Member = "OnItemBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ItemContainer), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ItemsControl), Member = "RaiseEndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnItemDoubleClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingItemContainer), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnItemClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingItemContainer), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnItemBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingItemContainer), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnItemDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingItemContainer), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "RaiseEndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000104")]
	public ItemArgs(Object[] item, PointerEventData pointerEventData) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000100")]
	public Object[] get_Items() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000102")]
	public PointerEventData get_PointerEventData() { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000101")]
	private void set_Items(Object[] value) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000103")]
	private void set_PointerEventData(PointerEventData value) { }

}

