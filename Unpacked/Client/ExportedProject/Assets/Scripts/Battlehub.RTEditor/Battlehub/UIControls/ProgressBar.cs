namespace Battlehub.UIControls;

[Token(Token = "0x2000012")]
public class ProgressBar : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000021")]
	private Image[] Images; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000022")]
	private Outline[] Outlines; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000023")]
	private Single[] m_alpha; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000024")]
	private float Speed; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000025")]
	public bool IsInProgress; //Field offset: 0x3C

	[Address(RVA = "0x5D1250", Offset = "0x5D0450", Length = "0x12")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000075")]
	public ProgressBar() { }

	[Address(RVA = "0x5D0C10", Offset = "0x5CFE10", Length = "0x2E5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(Shadow), Member = "set_effectColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000073")]
	private void FixedUpdate() { }

	[Address(RVA = "0x5D0F00", Offset = "0x5D0100", Length = "0x25B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Shadow), Member = "set_effectColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000072")]
	private void Start() { }

	[Address(RVA = "0x5D1160", Offset = "0x5D0360", Length = "0xE9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000074")]
	private Color UpdateAlpha(Color color, int index) { }

}

