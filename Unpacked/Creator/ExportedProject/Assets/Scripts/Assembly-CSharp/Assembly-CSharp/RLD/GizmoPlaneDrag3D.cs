namespace RLD;

[Token(Token = "0x200004C")]
public abstract class GizmoPlaneDrag3D : GizmoDragSession
{
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400013D")]
	private bool _isSnapEnabled; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x400013E")]
	private float _sensitivity; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400013F")]
	protected InputDevicePlaneDragSession3D _planeDragSession; //Field offset: 0x70

	[Token(Token = "0x170000A3")]
	public virtual bool IsActive
	{
		[Address(RVA = "0x3BAC30", Offset = "0x3B9E30", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600024B")]
		 get { } //Length: 19
	}

	[Token(Token = "0x170000A1")]
	public bool IsSnapEnabled
	{
		[Address(RVA = "0x3BAA60", Offset = "0x3B9C60", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000247")]
		 get { } //Length: 5
		[Address(RVA = "0x3BAC60", Offset = "0x3B9E60", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000248")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000A2")]
	public float Sensitivity
	{
		[Address(RVA = "0x3BAC50", Offset = "0x3B9E50", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000249")]
		 get { } //Length: 6
		[Address(RVA = "0x3BAC70", Offset = "0x3B9E70", Length = "0x14")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x600024A")]
		 set { } //Length: 20
	}

	[Address(RVA = "0x3B7910", Offset = "0x3B6B10", Length = "0xE")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(GizmoDragSession), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000251")]
	protected GizmoPlaneDrag3D() { }

	[Token(Token = "0x6000250")]
	protected abstract Plane CalculateDragPlane() { }

	[Address(RVA = "0x3BAA60", Offset = "0x3B9C60", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600024F")]
	protected bool CanSnap() { }

	[Address(RVA = "0x3BAA70", Offset = "0x3B9C70", Length = "0x155")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InputDevicePlaneDragSession3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputDevice), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(InputDevicePlaneDragSession3D), Member = "set_Plane", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Plane)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevicePlaneDragSession3D), Member = "Begin", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600024C")]
	protected virtual bool DoBeginSession() { }

	[Address(RVA = "0x3BABD0", Offset = "0x3B9DD0", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputDevicePlaneDragSession3D), Member = "End", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600024E")]
	protected virtual void DoEndSession() { }

	[Address(RVA = "0x3BAC10", Offset = "0x3B9E10", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputDevicePlaneDragSession3D), Member = "Update", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600024D")]
	protected virtual bool DoUpdateSession() { }

	[Address(RVA = "0x3BAC30", Offset = "0x3B9E30", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600024B")]
	public virtual bool get_IsActive() { }

	[Address(RVA = "0x3BAA60", Offset = "0x3B9C60", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000247")]
	public bool get_IsSnapEnabled() { }

	[Address(RVA = "0x3BAC50", Offset = "0x3B9E50", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000249")]
	public float get_Sensitivity() { }

	[Address(RVA = "0x3BAC60", Offset = "0x3B9E60", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000248")]
	public void set_IsSnapEnabled(bool value) { }

	[Address(RVA = "0x3BAC70", Offset = "0x3B9E70", Length = "0x14")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x600024A")]
	public void set_Sensitivity(float value) { }

}

