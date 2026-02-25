namespace HSVPicker;

[ExecuteInEditMode]
[RequireComponent(typeof(RawImage))]
[Token(Token = "0x2000011")]
public class ColorSliderImage : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000041")]
	public ColorPicker picker; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000042")]
	public ColorValues type; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000043")]
	public Direction direction; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000044")]
	private RawImage image; //Field offset: 0x30

	[Token(Token = "0x1700000B")]
	private RectTransform rectTransform
	{
		[Address(RVA = "0x10982E0", Offset = "0x10974E0", Length = "0x53")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Token(Token = "0x6000047")]
		private get { } //Length: 83
	}

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600004F")]
	public ColorSliderImage() { }

	[Address(RVA = "0x10975B0", Offset = "0x10967B0", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ColorSliderImage), Member = "RegenerateTexture", ReturnType = typeof(void))]
	[Token(Token = "0x6000048")]
	private void Awake() { }

	[Address(RVA = "0x1097640", Offset = "0x1096840", Length = "0x14")]
	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600004C")]
	private void ColorChanged(Color newColor) { }

	[Address(RVA = "0x10982E0", Offset = "0x10974E0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Token(Token = "0x6000047")]
	private RectTransform get_rectTransform() { }

	[Address(RVA = "0x1097640", Offset = "0x1096840", Length = "0x14")]
	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600004D")]
	private void HSVChanged(float hue, float saturation, float value) { }

	[Address(RVA = "0x1097690", Offset = "0x1096890", Length = "0xA4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600004B")]
	private void OnDestroy() { }

	[Address(RVA = "0x1097740", Offset = "0x1096940", Length = "0x14D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityEngine.Events.UnityAction`3<System.Single, System.Single, System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600004A")]
	private void OnDisable() { }

	[Address(RVA = "0x1097890", Offset = "0x1096A90", Length = "0x17D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityAction`3<System.Single, System.Single, System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent`3), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`3<T0, T1, T2>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000049")]
	private void OnEnable() { }

	[Address(RVA = "0x1097A10", Offset = "0x1096C10", Length = "0x890")]
	[CalledBy(Type = typeof(ColorSliderImage), Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(RawImage), Member = "set_uvRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RawImage), Member = "set_texture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "Apply", ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "SetPixels32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HSVUtil), Member = "ConvertHsvToRgb", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double), typeof(double), typeof(float)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600004E")]
	private void RegenerateTexture() { }

}

