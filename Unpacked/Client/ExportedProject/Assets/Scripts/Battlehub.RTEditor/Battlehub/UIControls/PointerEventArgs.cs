namespace Battlehub.UIControls;

[Token(Token = "0x200003F")]
public class PointerEventArgs : EventArgs
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000FC")]
	private PointerEventData <Data>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x1700007F")]
	public private PointerEventData Data
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000253")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000254")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x5D0BA0", Offset = "0x5CFDA0", Length = "0x65")]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnItemClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingItemContainer), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000255")]
	public PointerEventArgs(PointerEventData data) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000253")]
	public PointerEventData get_Data() { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000254")]
	private void set_Data(PointerEventData value) { }

}

