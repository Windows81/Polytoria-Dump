namespace UnityEngine.UI;

[AddComponentMenu("UI/Raw Image", 12)]
[RequireComponent(typeof(CanvasRenderer))]
[Token(Token = "0x200005E")]
public class RawImage : MaskableGraphic
{
	[FieldOffset(Offset = "0xE0")]
	[FormerlySerializedAs("m_Tex")]
	[SerializeField]
	[Token(Token = "0x40001B3")]
	private Texture m_Texture; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	[Token(Token = "0x40001B4")]
	private Rect m_UVRect; //Field offset: 0xE8

	[Token(Token = "0x170000E4")]
	public virtual Texture mainTexture
	{
		[Address(RVA = "0x1CC9DB0", Offset = "0x1CC8FB0", Length = "0x172")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Material), Member = "get_mainTexture", ReturnType = typeof(Texture))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x600037E")]
		 get { } //Length: 370
	}

	[Token(Token = "0x170000E5")]
	public Texture texture
	{
		[Address(RVA = "0x2DD1D0", Offset = "0x2DC3D0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600037F")]
		 get { } //Length: 8
		[Address(RVA = "0x1CC9F30", Offset = "0x1CC9130", Length = "0xB1")]
		[CalledBy(Type = "PurchasesService+<ShowPurchaseModal>d__13", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "Polytoria.Controllers.ToolboxController+<LoadThumbnail>d__23", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "Polytoria.Controllers.CreatorThumbnailGenerator", Member = "TestRender", ReturnType = typeof(void))]
		[CalledBy(Type = "HSVPicker.ColorSliderImage", Member = "RegenerateTexture", ReturnType = typeof(void))]
		[CalledBy(Type = "HSVPicker.SVBoxSlider", Member = "RegenerateSVTexture", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000380")]
		 set { } //Length: 177
	}

	[Token(Token = "0x170000E6")]
	public Rect uvRect
	{
		[Address(RVA = "0x1551D50", Offset = "0x1550F50", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000381")]
		 get { } //Length: 14
		[Address(RVA = "0x1CC9FF0", Offset = "0x1CC91F0", Length = "0x69")]
		[CalledBy(Type = "HSVPicker.ColorSliderImage", Member = "RegenerateTexture", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000382")]
		 set { } //Length: 105
	}

	[Address(RVA = "0x1CC9D80", Offset = "0x1CC8F80", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MaskableGraphic), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x600037D")]
	protected RawImage() { }

	[Address(RVA = "0x1CC9DB0", Offset = "0x1CC8FB0", Length = "0x172")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "get_mainTexture", ReturnType = typeof(Texture))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600037E")]
	public virtual Texture get_mainTexture() { }

	[Address(RVA = "0x2DD1D0", Offset = "0x2DC3D0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600037F")]
	public Texture get_texture() { }

	[Address(RVA = "0x1551D50", Offset = "0x1550F50", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000381")]
	public Rect get_uvRect() { }

	[Address(RVA = "0x1A8E380", Offset = "0x1A8D580", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graphic), Member = "SetRaycastDirty", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000385")]
	protected virtual void OnDidApplyAnimationProperties() { }

	[Address(RVA = "0x1CC97F0", Offset = "0x1CC89F0", Length = "0x420")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VertexHelper), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "GetPixelAdjustedRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Texture), Member = "get_texelSize", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Color32), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexHelper), Member = "AddTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000384")]
	protected virtual void OnPopulateMesh(VertexHelper vh) { }

	[Address(RVA = "0x1CC9F30", Offset = "0x1CC9130", Length = "0xB1")]
	[CalledBy(Type = "PurchasesService+<ShowPurchaseModal>d__13", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.ToolboxController+<LoadThumbnail>d__23", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorThumbnailGenerator", Member = "TestRender", ReturnType = typeof(void))]
	[CalledBy(Type = "HSVPicker.ColorSliderImage", Member = "RegenerateTexture", ReturnType = typeof(void))]
	[CalledBy(Type = "HSVPicker.SVBoxSlider", Member = "RegenerateSVTexture", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000380")]
	public void set_texture(Texture value) { }

	[Address(RVA = "0x1CC9FF0", Offset = "0x1CC91F0", Length = "0x69")]
	[CalledBy(Type = "HSVPicker.ColorSliderImage", Member = "RegenerateTexture", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000382")]
	public void set_uvRect(Rect value) { }

	[Address(RVA = "0x1CC9C20", Offset = "0x1CC8E20", Length = "0x15F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC070")]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchorMin", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000383")]
	public virtual void SetNativeSize() { }

}

