namespace Polytoria.UI;

[Token(Token = "0x20002EF")]
public class UIStaminaBar : MonoBehaviour
{
	[Token(Token = "0x4000B6E")]
	private const float fadeTime = 0.3; //Field offset: 0x0
	[Token(Token = "0x4000B71")]
	private const float fadeStartTime = 0.3; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B6F")]
	private float _fadeStartTimer; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000B70")]
	private int fadeTimerState; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B72")]
	private Image fill; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B73")]
	private Image cont; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000B74")]
	private float fillAmount; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000B75")]
	public Color FillColor; //Field offset: 0x3C
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000B76")]
	public Color FillExhaustedColor; //Field offset: 0x4C
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000B77")]
	private float alpha; //Field offset: 0x5C

	[Address(RVA = "0x41BC60", Offset = "0x41AE60", Length = "0x13F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = "Polytoria.Datamodel.ImageSky+<LoadSkyboxImage>d__35", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001B4B")]
	public UIStaminaBar() { }

	[Address(RVA = "0x41B7A0", Offset = "0x41A9A0", Length = "0xD5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001B47")]
	private void Awake() { }

	[Address(RVA = "0x41B880", Offset = "0x41AA80", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001B49")]
	public void SetEnabled(bool enabled) { }

	[Address(RVA = "0x41B8C0", Offset = "0x41AAC0", Length = "0x16A")]
	[CalledBy(Type = typeof(UIController), Member = "SetStaminaFilled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Image), Member = "set_fillAmount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6001B4A")]
	public void SetFill(float newFillAmount, bool exhausted) { }

	[Address(RVA = "0x41BA30", Offset = "0x41AC30", Length = "0x226")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001B48")]
	private void Update() { }

}

