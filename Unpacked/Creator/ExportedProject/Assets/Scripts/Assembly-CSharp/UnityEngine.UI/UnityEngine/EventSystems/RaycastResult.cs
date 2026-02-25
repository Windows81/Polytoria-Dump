namespace UnityEngine.EventSystems;

[Token(Token = "0x20000CC")]
public struct RaycastResult
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000372")]
	private GameObject m_GameObject; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000373")]
	public BaseRaycaster module; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000374")]
	public float distance; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000375")]
	public float index; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000376")]
	public int depth; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000377")]
	public int sortingGroupID; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000378")]
	public int sortingGroupOrder; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000379")]
	public int sortingLayer; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400037A")]
	public int sortingOrder; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400037B")]
	public Vector3 origin; //Field offset: 0x2C
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400037C")]
	public Vector3 worldPosition; //Field offset: 0x38
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400037D")]
	public Vector3 worldNormal; //Field offset: 0x44
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400037E")]
	public Vector2 screenPosition; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400037F")]
	public int displayIndex; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000380")]
	public UIDocument document; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000381")]
	public VisualElement element; //Field offset: 0x68

	[Token(Token = "0x17000208")]
	public GameObject gameObject
	{
		[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
		[CallerCount(Count = 140)]
		[DeduplicatedMethod]
		[Token(Token = "0x600079B")]
		 get { } //Length: 4
		[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600079C")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000209")]
	public bool isValid
	{
		[Address(RVA = "0x1CED5A0", Offset = "0x1CEC7A0", Length = "0x8D")]
		[CalledBy(Type = typeof(RaycastResult), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Token(Token = "0x600079D")]
		 get { } //Length: 141
	}

	[Address(RVA = "0x1CECF00", Offset = "0x1CEC100", Length = "0x149")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600079E")]
	public void Clear() { }

	[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
	[CallerCount(Count = 140)]
	[DeduplicatedMethod]
	[Token(Token = "0x600079B")]
	public GameObject get_gameObject() { }

	[Address(RVA = "0x1CED5A0", Offset = "0x1CEC7A0", Length = "0x8D")]
	[CalledBy(Type = typeof(RaycastResult), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600079D")]
	public bool get_isValid() { }

	[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600079C")]
	public void set_gameObject(GameObject value) { }

	[Address(RVA = "0x1CED050", Offset = "0x1CEC250", Length = "0x54B")]
	[CalledBy(Type = typeof(PointerEventData), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RaycastResult), Member = "get_isValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D8580")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180866B80")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x600079F")]
	public virtual string ToString() { }

}

