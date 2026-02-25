namespace RLD;

[Token(Token = "0x200021B")]
public class InputDevicePlaneDragSession3D
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000821")]
	private Plane _plane; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000822")]
	private Camera _raycastCamera; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000823")]
	private Vector3 _dragPoint; //Field offset: 0x28
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000824")]
	private Vector3 _dragDelta; //Field offset: 0x34
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000825")]
	private Vector3 _accumDrag; //Field offset: 0x40
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000826")]
	private IInputDevice _inputDevice; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000827")]
	private bool _isActive; //Field offset: 0x58

	[Token(Token = "0x1700067E")]
	public Vector3 AccumDrag
	{
		[Address(RVA = "0x3B9190", Offset = "0x3B8390", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001475")]
		 get { } //Length: 19
	}

	[Token(Token = "0x1700067D")]
	public Vector3 DragDelta
	{
		[Address(RVA = "0x3B91F0", Offset = "0x3B83F0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001474")]
		 get { } //Length: 19
	}

	[Token(Token = "0x1700067C")]
	public Vector3 DragPoint
	{
		[Address(RVA = "0x3C1A50", Offset = "0x3C0C50", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001473")]
		 get { } //Length: 19
	}

	[Token(Token = "0x1700067F")]
	public bool IsActive
	{
		[Address(RVA = "0x3F5830", Offset = "0x3F4A30", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001476")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700067A")]
	public Plane Plane
	{
		[Address(RVA = "0x3E81B0", Offset = "0x3E73B0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600146F")]
		 get { } //Length: 11
		[Address(RVA = "0x5953D0", Offset = "0x5945D0", Length = "0xE")]
		[CalledBy(Type = typeof(GizmoPlaneDrag3D), Member = "DoBeginSession", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x6001470")]
		 set { } //Length: 14
	}

	[Token(Token = "0x1700067B")]
	public Camera RaycastCamera
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001471")]
		 get { } //Length: 5
		[Address(RVA = "0x5953E0", Offset = "0x5945E0", Length = "0x14")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001472")]
		 set { } //Length: 20
	}

	[Address(RVA = "0x595380", Offset = "0x594580", Length = "0x4E")]
	[CalledBy(Type = typeof(GizmoPlaneDrag3D), Member = "DoBeginSession", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001477")]
	public InputDevicePlaneDragSession3D(IInputDevice inputDevice, Camera raycastCamera) { }

	[Address(RVA = "0x595060", Offset = "0x594260", Length = "0x7A")]
	[CalledBy(Type = typeof(GizmoPlaneDrag3D), Member = "DoBeginSession", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputDevicePlaneDragSession3D), Member = "UpdateDragPoint", ReturnType = typeof(bool))]
	[Token(Token = "0x6001478")]
	public bool Begin() { }

	[Address(RVA = "0x5950E0", Offset = "0x5942E0", Length = "0xCF")]
	[CalledBy(Type = typeof(GizmoPlaneDrag3D), Member = "DoEndSession", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6001479")]
	public void End() { }

	[Address(RVA = "0x3B9190", Offset = "0x3B8390", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001475")]
	public Vector3 get_AccumDrag() { }

	[Address(RVA = "0x3B91F0", Offset = "0x3B83F0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001474")]
	public Vector3 get_DragDelta() { }

	[Address(RVA = "0x3C1A50", Offset = "0x3C0C50", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001473")]
	public Vector3 get_DragPoint() { }

	[Address(RVA = "0x3F5830", Offset = "0x3F4A30", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001476")]
	public bool get_IsActive() { }

	[Address(RVA = "0x3E81B0", Offset = "0x3E73B0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600146F")]
	public Plane get_Plane() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001471")]
	public Camera get_RaycastCamera() { }

	[Address(RVA = "0x5953D0", Offset = "0x5945D0", Length = "0xE")]
	[CalledBy(Type = typeof(GizmoPlaneDrag3D), Member = "DoBeginSession", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6001470")]
	public void set_Plane(Plane value) { }

	[Address(RVA = "0x5953E0", Offset = "0x5945E0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001472")]
	public void set_RaycastCamera(Camera value) { }

	[Address(RVA = "0x595290", Offset = "0x594490", Length = "0xE5")]
	[CalledBy(Type = typeof(GizmoPlaneDrag3D), Member = "DoUpdateSession", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputDevicePlaneDragSession3D), Member = "UpdateDragPoint", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600147A")]
	public bool Update() { }

	[Address(RVA = "0x5951B0", Offset = "0x5943B0", Length = "0xD6")]
	[CalledBy(Type = typeof(InputDevicePlaneDragSession3D), Member = "Begin", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputDevicePlaneDragSession3D), Member = "Update", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001AA10")]
	[Calls(Type = typeof(Plane), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Ray), Member = "GetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600147B")]
	private bool UpdateDragPoint() { }

}

