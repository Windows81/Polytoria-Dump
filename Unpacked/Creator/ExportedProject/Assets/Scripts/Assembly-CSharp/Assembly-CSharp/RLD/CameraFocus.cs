namespace RLD;

[Token(Token = "0x2000125")]
public static class CameraFocus
{
	[Token(Token = "0x2000126")]
	internal class Data
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000543")]
		private Vector3 _cameraWorldPosition; //Field offset: 0x10
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000544")]
		private Vector3 _focusPoint; //Field offset: 0x1C
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000545")]
		private float _focusPointOffset; //Field offset: 0x28

		[Token(Token = "0x170004B6")]
		public Vector3 CameraWorldPosition
		{
			[Address(RVA = "0x53F270", Offset = "0x53E470", Length = "0x13")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000E06")]
			 get { } //Length: 19
		}

		[Token(Token = "0x170004B7")]
		public Vector3 FocusPoint
		{
			[Address(RVA = "0x3B87E0", Offset = "0x3B79E0", Length = "0x13")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000E07")]
			 get { } //Length: 19
		}

		[Token(Token = "0x170004B8")]
		public float FocusPointOffset
		{
			[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000E08")]
			 get { } //Length: 6
		}

		[Address(RVA = "0x53F1C0", Offset = "0x53E3C0", Length = "0xA3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000E09")]
		public Data(Vector3 cameraWorldPosition, Vector3 focusPoint) { }

		[Address(RVA = "0x53F270", Offset = "0x53E470", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E06")]
		public Vector3 get_CameraWorldPosition() { }

		[Address(RVA = "0x3B87E0", Offset = "0x3B79E0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E07")]
		public Vector3 get_FocusPoint() { }

		[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E08")]
		public float get_FocusPointOffset() { }

	}


	[Address(RVA = "0x53B2E0", Offset = "0x53A4E0", Length = "0x1F5")]
	[CalledBy(Type = typeof(RTFocusCamera), Member = "Focus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AABB)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Camera), Member = "get_fieldOfView", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028EDD0")]
	[Calls(Type = typeof(Camera), Member = "get_nearClipPlane", ReturnType = typeof(float))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E05")]
	public static Data CalculateFocusData(Camera camera, AABB focusAABB, CameraFocusSettings focusSettings) { }

}

