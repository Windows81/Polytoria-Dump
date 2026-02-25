namespace RLD;

[Token(Token = "0x200004D")]
public abstract class GizmoScreenDrag : GizmoDragSession
{
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000140")]
	private bool _isSnapEnabled; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000141")]
	private float _sensitivity; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000142")]
	protected InputDeviceScreenDragSession _screenDragSession; //Field offset: 0x70

	[Token(Token = "0x170000A6")]
	public virtual bool IsActive
	{
		[Address(RVA = "0x3BB630", Offset = "0x3BA830", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000256")]
		 get { } //Length: 19
	}

	[Token(Token = "0x170000A4")]
	public bool IsSnapEnabled
	{
		[Address(RVA = "0x3BAA60", Offset = "0x3B9C60", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000252")]
		 get { } //Length: 5
		[Address(RVA = "0x3BAC60", Offset = "0x3B9E60", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000253")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000A5")]
	public float Sensitivity
	{
		[Address(RVA = "0x3BAC50", Offset = "0x3B9E50", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000254")]
		 get { } //Length: 6
		[Address(RVA = "0x3BAC70", Offset = "0x3B9E70", Length = "0x14")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000255")]
		 set { } //Length: 20
	}

	[Address(RVA = "0x3B7910", Offset = "0x3B6B10", Length = "0xE")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(GizmoDragSession), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600025B")]
	protected GizmoScreenDrag() { }

	[Address(RVA = "0x3BAA60", Offset = "0x3B9C60", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600025A")]
	protected bool CanSnap() { }

	[Address(RVA = "0x3BB500", Offset = "0x3BA700", Length = "0xC2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(InputDeviceScreenDragSession), Member = "Begin", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000257")]
	protected virtual bool DoBeginSession() { }

	[Address(RVA = "0x3BB5D0", Offset = "0x3BA7D0", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputDeviceScreenDragSession), Member = "End", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000259")]
	protected virtual void DoEndSession() { }

	[Address(RVA = "0x3BB610", Offset = "0x3BA810", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputDeviceScreenDragSession), Member = "Update", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000258")]
	protected virtual bool DoUpdateSession() { }

	[Address(RVA = "0x3BB630", Offset = "0x3BA830", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000256")]
	public virtual bool get_IsActive() { }

	[Address(RVA = "0x3BAA60", Offset = "0x3B9C60", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000252")]
	public bool get_IsSnapEnabled() { }

	[Address(RVA = "0x3BAC50", Offset = "0x3B9E50", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000254")]
	public float get_Sensitivity() { }

	[Address(RVA = "0x3BAC60", Offset = "0x3B9E60", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000253")]
	public void set_IsSnapEnabled(bool value) { }

	[Address(RVA = "0x3BAC70", Offset = "0x3B9E70", Length = "0x14")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000255")]
	public void set_Sensitivity(float value) { }

}

