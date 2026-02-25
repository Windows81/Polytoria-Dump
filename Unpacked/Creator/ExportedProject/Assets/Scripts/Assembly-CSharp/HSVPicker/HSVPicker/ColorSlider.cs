namespace HSVPicker;

[RequireComponent(typeof(Slider))]
[Token(Token = "0x2000010")]
public class ColorSlider : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400003D")]
	public ColorPicker hsvpicker; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400003E")]
	public ColorValues type; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400003F")]
	private Slider slider; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000040")]
	private bool listen; //Field offset: 0x38

	[Address(RVA = "0x10987F0", Offset = "0x10979F0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000046")]
	public ColorSlider() { }

	[Address(RVA = "0x1098340", Offset = "0x1097540", Length = "0x1B4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityAction`3<System.Single, System.Single, System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent`3), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`3<T0, T1, T2>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000041")]
	private void Awake() { }

	[Address(RVA = "0x1098500", Offset = "0x1097700", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Slider), Member = "set_normalizedValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000043")]
	private void ColorChanged(Color newColor) { }

	[Address(RVA = "0x10985A0", Offset = "0x10977A0", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Slider), Member = "set_normalizedValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000044")]
	private void HSVChanged(float hue, float saturation, float value) { }

	[Address(RVA = "0x1098610", Offset = "0x1097810", Length = "0x18A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityEngine.Events.UnityAction`3<System.Single, System.Single, System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6000042")]
	private void OnDestroy() { }

	[Address(RVA = "0x10987A0", Offset = "0x10979A0", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Slider), Member = "get_normalizedValue", ReturnType = typeof(float))]
	[Calls(Type = typeof(ColorPicker), Member = "AssignColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorValues), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000045")]
	private void SliderChanged(float newValue) { }

}

