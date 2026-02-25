namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000058")]
public sealed class SplineParameter : ParameterOverride<Spline>
{

	[Address(RVA = "0x1855570", Offset = "0x1854770", Length = "0x39")]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.Rendering.PostProcessing.ParameterOverride`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60000E3")]
	public SplineParameter() { }

	[Address(RVA = "0x18553B0", Offset = "0x18545B0", Length = "0x12D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Time), Member = "get_renderedFrameCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Spline), Member = "Cache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Rendering.PostProcessing.ParameterOverride`1<System.Object>), Member = "Interp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000E2")]
	public virtual void Interp(Spline from, Spline to, float t) { }

	[Address(RVA = "0x18554E0", Offset = "0x18546E0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Spline), Member = "Cache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000E0")]
	protected private virtual void OnEnable() { }

	[Address(RVA = "0x1855500", Offset = "0x1854700", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.Rendering.PostProcessing.ParameterOverride`1<System.Object>), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterOverride)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Time), Member = "get_renderedFrameCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Spline), Member = "Cache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000E1")]
	internal virtual void SetValue(ParameterOverride parameter) { }

}

