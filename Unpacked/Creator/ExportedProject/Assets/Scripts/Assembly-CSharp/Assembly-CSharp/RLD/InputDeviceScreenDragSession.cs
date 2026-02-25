namespace RLD;

[Token(Token = "0x200021C")]
public class InputDeviceScreenDragSession
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000828")]
	private Vector2 _dragPoint; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000829")]
	private Vector2 _dragDelta; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400082A")]
	private Vector2 _accumDrag; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400082B")]
	private IInputDevice _inputDevice; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400082C")]
	private bool _isActive; //Field offset: 0x30

	[Token(Token = "0x17000682")]
	public Vector2 AccumDrag
	{
		[Address(RVA = "0x53E610", Offset = "0x53D810", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600147E")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000681")]
	public Vector2 DragDelta
	{
		[Address(RVA = "0x5956B0", Offset = "0x5948B0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600147D")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000680")]
	public Vector2 DragPoint
	{
		[Address(RVA = "0x563200", Offset = "0x562400", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600147C")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000683")]
	public bool IsActive
	{
		[Address(RVA = "0x3351B0", Offset = "0x3343B0", Length = "0x5")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600147F")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x595670", Offset = "0x594870", Length = "0x31")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001480")]
	public InputDeviceScreenDragSession(IInputDevice inputDevice) { }

	[Address(RVA = "0x595400", Offset = "0x594600", Length = "0x27")]
	[CalledBy(Type = typeof(GizmoScreenDrag), Member = "DoBeginSession", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputDeviceScreenDragSession), Member = "UpdateDragPoint", ReturnType = typeof(bool))]
	[Token(Token = "0x6001481")]
	public bool Begin() { }

	[Address(RVA = "0x595430", Offset = "0x594630", Length = "0xDA")]
	[CalledBy(Type = typeof(GizmoScreenDrag), Member = "DoEndSession", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6001482")]
	public void End() { }

	[Address(RVA = "0x53E610", Offset = "0x53D810", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600147E")]
	public Vector2 get_AccumDrag() { }

	[Address(RVA = "0x5956B0", Offset = "0x5948B0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600147D")]
	public Vector2 get_DragDelta() { }

	[Address(RVA = "0x563200", Offset = "0x562400", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600147C")]
	public Vector2 get_DragPoint() { }

	[Address(RVA = "0x3351B0", Offset = "0x3343B0", Length = "0x5")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600147F")]
	public bool get_IsActive() { }

	[Address(RVA = "0x5955A0", Offset = "0x5947A0", Length = "0xCD")]
	[CalledBy(Type = typeof(GizmoScreenDrag), Member = "DoUpdateSession", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputDeviceScreenDragSession), Member = "UpdateDragPoint", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6001483")]
	public bool Update() { }

	[Address(RVA = "0x595510", Offset = "0x594710", Length = "0x8A")]
	[CalledBy(Type = typeof(InputDeviceScreenDragSession), Member = "Begin", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputDeviceScreenDragSession), Member = "Update", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001484")]
	private bool UpdateDragPoint() { }

}

