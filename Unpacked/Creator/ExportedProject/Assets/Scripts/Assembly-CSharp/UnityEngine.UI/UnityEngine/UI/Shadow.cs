namespace UnityEngine.UI;

[AddComponentMenu("UI/Effects/Shadow", 80)]
[Token(Token = "0x2000088")]
public class Shadow : BaseMeshEffect
{
	[Token(Token = "0x4000274")]
	private const float kMaxEffectDistance = 600; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000271")]
	private Color m_EffectColor; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000272")]
	private Vector2 m_EffectDistance; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000273")]
	private bool m_UseGraphicAlpha; //Field offset: 0x40

	[Token(Token = "0x17000156")]
	public Color effectColor
	{
		[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000544")]
		 get { } //Length: 11
		[Address(RVA = "0x1CEDE10", Offset = "0x1CED010", Length = "0x9C")]
		[CalledBy(Type = "Battlehub.UIControls.ProgressBar", Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = "Battlehub.UIControls.ProgressBar", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Battlehub.UIControls.UIStyle", Member = "ApplyOutlineColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(BaseMeshEffect), Member = "get_graphic", ReturnType = typeof(Graphic))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000545")]
		 set { } //Length: 156
	}

	[Token(Token = "0x17000157")]
	public Vector2 effectDistance
	{
		[Address(RVA = "0x58DF10", Offset = "0x58D110", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000546")]
		 get { } //Length: 19
		[Address(RVA = "0x1CEDEB0", Offset = "0x1CED0B0", Length = "0xFD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(BaseMeshEffect), Member = "get_graphic", ReturnType = typeof(Graphic))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000547")]
		 set { } //Length: 253
	}

	[Token(Token = "0x17000158")]
	public bool useGraphicAlpha
	{
		[Address(RVA = "0x4C4260", Offset = "0x4C3460", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000548")]
		 get { } //Length: 5
		[Address(RVA = "0x1CEDFB0", Offset = "0x1CED1B0", Length = "0x99")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(BaseMeshEffect), Member = "get_graphic", ReturnType = typeof(Graphic))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000549")]
		 set { } //Length: 153
	}

	[Address(RVA = "0x1CEDDE0", Offset = "0x1CECFE0", Length = "0x25")]
	[CalledBy(Type = typeof(Outline), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000543")]
	protected Shadow() { }

	[Address(RVA = "0x1CEDC90", Offset = "0x1CECE90", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Shadow), Member = "ApplyShadowZeroAlloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIVertex>), typeof(Color32), typeof(int), typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x600054B")]
	protected void ApplyShadow(List<UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	[Address(RVA = "0x1CED910", Offset = "0x1CECB10", Length = "0x379")]
	[CalledBy(Type = typeof(Outline), Member = "ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Shadow), Member = "ApplyShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIVertex>), typeof(Color32), typeof(int), typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Shadow), Member = "ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIVertex>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(UIVertex))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIVertex>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIVertex)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIVertex>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UIVertex)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600054A")]
	protected void ApplyShadowZeroAlloc(List<UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000544")]
	public Color get_effectColor() { }

	[Address(RVA = "0x58DF10", Offset = "0x58D110", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000546")]
	public Vector2 get_effectDistance() { }

	[Address(RVA = "0x4C4260", Offset = "0x4C3460", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000548")]
	public bool get_useGraphicAlpha() { }

	[Address(RVA = "0x1CEDCA0", Offset = "0x1CECEA0", Length = "0x13B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(VertexHelper), Member = "GetUIVertexStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIVertex>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(Shadow), Member = "ApplyShadowZeroAlloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIVertex>), typeof(Color32), typeof(int), typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexHelper), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexHelper), Member = "AddUIVertexTriangleStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIVertex>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600054C")]
	public virtual void ModifyMesh(VertexHelper vh) { }

	[Address(RVA = "0x1CEDE10", Offset = "0x1CED010", Length = "0x9C")]
	[CalledBy(Type = "Battlehub.UIControls.ProgressBar", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.ProgressBar", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.UIStyle", Member = "ApplyOutlineColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseMeshEffect), Member = "get_graphic", ReturnType = typeof(Graphic))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000545")]
	public void set_effectColor(Color value) { }

	[Address(RVA = "0x1CEDEB0", Offset = "0x1CED0B0", Length = "0xFD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseMeshEffect), Member = "get_graphic", ReturnType = typeof(Graphic))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000547")]
	public void set_effectDistance(Vector2 value) { }

	[Address(RVA = "0x1CEDFB0", Offset = "0x1CED1B0", Length = "0x99")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseMeshEffect), Member = "get_graphic", ReturnType = typeof(Graphic))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000549")]
	public void set_useGraphicAlpha(bool value) { }

}

