namespace HSVPicker;

[ExecuteInEditMode]
[RequireComponent(typeof(BoxSlider), typeof(RawImage))]
[Token(Token = "0x2000013")]
public class SVBoxSlider : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000048")]
	public ColorPicker picker; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000049")]
	private BoxSlider slider; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400004A")]
	private RawImage image; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400004B")]
	private int textureWidth; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400004C")]
	private int textureHeight; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400004D")]
	private float lastH; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400004E")]
	private bool listen; //Field offset: 0x44

	[Token(Token = "0x1700000C")]
	public RectTransform rectTransform
	{
		[Address(RVA = "0x1099EA0", Offset = "0x10990A0", Length = "0x53")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Token(Token = "0x6000056")]
		 get { } //Length: 83
	}

	[Address(RVA = "0x1099E80", Offset = "0x1099080", Length = "0x20")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600005E")]
	public SVBoxSlider() { }

	[Address(RVA = "0x10994F0", Offset = "0x10986F0", Length = "0xB0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SVBoxSlider), Member = "RegenerateSVTexture", ReturnType = typeof(void))]
	[Token(Token = "0x6000057")]
	private void Awake() { }

	[Address(RVA = "0x1099EA0", Offset = "0x10990A0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Token(Token = "0x6000056")]
	public RectTransform get_rectTransform() { }

	[Address(RVA = "0x10995A0", Offset = "0x10987A0", Length = "0x146")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SVBoxSlider), Member = "RegenerateSVTexture", ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxSlider), Member = "get_normalizedValue", ReturnType = typeof(float))]
	[Calls(Type = typeof(BoxSlider), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxSlider), Member = "get_normalizedValueY", ReturnType = typeof(float))]
	[Calls(Type = typeof(BoxSlider), Member = "SetY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600005C")]
	private void HSVChanged(float h, float s, float v) { }

	[Address(RVA = "0x10996F0", Offset = "0x10988F0", Length = "0xA4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600005A")]
	private void OnDestroy() { }

	[Address(RVA = "0x10997A0", Offset = "0x10989A0", Length = "0x150")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityEngine.Events.UnityAction`3<System.Single, System.Single, System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000059")]
	private void OnDisable() { }

	[Address(RVA = "0x1099900", Offset = "0x1098B00", Length = "0x181")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityEvent`2), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`2<T0, T1>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityAction`3<System.Single, System.Single, System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent`3), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`3<T0, T1, T2>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000058")]
	private void OnEnable() { }

	[Address(RVA = "0x1099A90", Offset = "0x1098C90", Length = "0x2D4")]
	[CalledBy(Type = typeof(SVBoxSlider), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SVBoxSlider), Member = "HSVChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RawImage), Member = "set_texture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "Apply", ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "SetPixels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(Color[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HSVUtil), Member = "ConvertHsvToRgb", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double), typeof(double), typeof(float)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "set_wrapMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureWrapMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600005D")]
	private void RegenerateSVTexture() { }

	[Address(RVA = "0x1099D70", Offset = "0x1098F70", Length = "0x10C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HSVUtil), Member = "ConvertHsvToRgb", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double), typeof(double), typeof(float)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(ColorPicker), Member = "SendChangedEvent", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600005B")]
	private void SliderChanged(float saturation, float value) { }

}

