namespace Battlehub.UIControls;

[Token(Token = "0x2000014")]
public class RectTransformChangeListener : UIBehaviour
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000026")]
	private RectTransformChanged RectTransformChanged; //Field offset: 0x20

	[Token(Token = "0x14000001")]
	public event RectTransformChanged RectTransformChanged
	{
		[Address(RVA = "0x5D1290", Offset = "0x5D0490", Length = "0x9E")]
		[CalledBy(Type = typeof(ItemsControl), Member = "Awake", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "Awake", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "Awake", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600007A")]
		 add { } //Length: 158
		[Address(RVA = "0x5D1330", Offset = "0x5D0530", Length = "0x9E")]
		[CalledBy(Type = typeof(ItemsControl), Member = "OnDestroy", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnDestroy", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "OnDestroy", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600007B")]
		 remove { } //Length: 158
	}

	[Address(RVA = "0x3B01C0", Offset = "0x3AF3C0", Length = "0x7")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600007E")]
	public RectTransformChangeListener() { }

	[Address(RVA = "0x5D1290", Offset = "0x5D0490", Length = "0x9E")]
	[CalledBy(Type = typeof(ItemsControl), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600007A")]
	public void add_RectTransformChanged(RectTransformChanged value) { }

	[Address(RVA = "0x5D1270", Offset = "0x5D0470", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600007C")]
	protected virtual void OnRectTransformDimensionsChange() { }

	[Address(RVA = "0x5D1270", Offset = "0x5D0470", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600007D")]
	public void RaiseRectTransformChanged() { }

	[Address(RVA = "0x5D1330", Offset = "0x5D0530", Length = "0x9E")]
	[CalledBy(Type = typeof(ItemsControl), Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "OnDestroy", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600007B")]
	public void remove_RectTransformChanged(RectTransformChanged value) { }

}

