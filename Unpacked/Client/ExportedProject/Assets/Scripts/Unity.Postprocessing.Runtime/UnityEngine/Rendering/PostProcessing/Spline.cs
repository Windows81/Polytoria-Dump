namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x200008A")]
public sealed class Spline
{
	[Token(Token = "0x40002F1")]
	public const int k_Precision = 128; //Field offset: 0x0
	[Token(Token = "0x40002F2")]
	public const float k_Step = 0.0078125; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002F3")]
	public AnimationCurve curve; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40002F4")]
	private bool m_Loop; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[Token(Token = "0x40002F5")]
	private float m_ZeroValue; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40002F6")]
	private float m_Range; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002F7")]
	private AnimationCurve m_InternalLoopingCurve; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002F8")]
	private int frameCount; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002F9")]
	public Single[] cachedData; //Field offset: 0x38

	[Address(RVA = "0x1857BE0", Offset = "0x1856DE0", Length = "0x108")]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600024D")]
	public Spline(AnimationCurve curve, float zeroValue, bool loop, Vector2 bounds) { }

	[Address(RVA = "0x1857840", Offset = "0x1856A40", Length = "0x2BC")]
	[CalledBy(Type = typeof(SplineParameter), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SplineParameter), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterOverride)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SplineParameter), Member = "Interp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Spline), typeof(Spline), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AnimationCurve), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Keyframe)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(AnimationCurve), Member = "set_keys", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Keyframe[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationCurve), Member = "get_keys", ReturnType = typeof(Keyframe[]))]
	[Calls(Type = typeof(AnimationCurve), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Keyframe))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Time), Member = "get_renderedFrameCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(AnimationCurve), Member = "get_length", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600024E")]
	public void Cache(int frame) { }

	[Address(RVA = "0x1857B70", Offset = "0x1856D70", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600024F")]
	public float Evaluate(float t, int length) { }

	[Address(RVA = "0x1857B00", Offset = "0x1856D00", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationCurve), Member = "get_length", ReturnType = typeof(int))]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000250")]
	public float Evaluate(float t) { }

	[Address(RVA = "0x1857BB0", Offset = "0x1856DB0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000251")]
	public virtual int GetHashCode() { }

}

