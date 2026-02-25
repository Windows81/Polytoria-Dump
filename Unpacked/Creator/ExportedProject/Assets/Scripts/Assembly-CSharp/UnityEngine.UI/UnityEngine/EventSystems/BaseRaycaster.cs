namespace UnityEngine.EventSystems;

[Token(Token = "0x20000C8")]
public abstract class BaseRaycaster : UIBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000369")]
	private BaseRaycaster m_RootRaycaster; //Field offset: 0x20

	[Token(Token = "0x170001FE")]
	public abstract Camera eventCamera
	{
		[Token(Token = "0x6000781")]
		 get { } //Length: 0
	}

	[Obsolete("Please use sortOrderPriority and renderOrderPriority", False)]
	[Token(Token = "0x170001FF")]
	public override int priority
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000782")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000201")]
	public override int renderOrderPriority
	{
		[Address(RVA = "0x5453A0", Offset = "0x5445A0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000784")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000202")]
	public BaseRaycaster rootRaycaster
	{
		[Address(RVA = "0x1CE0740", Offset = "0x1CDF940", Length = "0xB2")]
		[CalledBy(Type = typeof(EventSystem), Member = "RaycastComparer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RaycastResult), typeof(RaycastResult)}, ReturnType = typeof(int))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponentsInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000785")]
		 get { } //Length: 178
	}

	[Token(Token = "0x17000200")]
	public override int sortOrderPriority
	{
		[Address(RVA = "0x5453A0", Offset = "0x5445A0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000783")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600078B")]
	protected BaseRaycaster() { }

	[Token(Token = "0x6000781")]
	public abstract Camera get_eventCamera() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000782")]
	public override int get_priority() { }

	[Address(RVA = "0x5453A0", Offset = "0x5445A0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000784")]
	public override int get_renderOrderPriority() { }

	[Address(RVA = "0x1CE0740", Offset = "0x1CDF940", Length = "0xB2")]
	[CalledBy(Type = typeof(EventSystem), Member = "RaycastComparer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RaycastResult), typeof(RaycastResult)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponentsInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000785")]
	public BaseRaycaster get_rootRaycaster() { }

	[Address(RVA = "0x5453A0", Offset = "0x5445A0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000783")]
	public override int get_sortOrderPriority() { }

	[Address(RVA = "0x3BCF00", Offset = "0x3BC100", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000789")]
	protected virtual void OnCanvasHierarchyChanged() { }

	[Address(RVA = "0x1CE02C0", Offset = "0x1CDF4C0", Length = "0xF9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000788")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x1CE03C0", Offset = "0x1CDF5C0", Length = "0x14E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000787")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x3BCF00", Offset = "0x3BC100", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600078A")]
	protected virtual void OnTransformParentChanged() { }

	[Token(Token = "0x6000780")]
	public abstract void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

	[Address(RVA = "0x1CE0510", Offset = "0x1CDF710", Length = "0x226")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000786")]
	public virtual string ToString() { }

}

