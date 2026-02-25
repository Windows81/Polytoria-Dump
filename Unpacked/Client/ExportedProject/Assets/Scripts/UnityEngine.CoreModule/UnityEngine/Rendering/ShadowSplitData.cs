namespace UnityEngine.Rendering;

[Token(Token = "0x20002FE")]
[UsedByNativeCode]
public struct ShadowSplitData : IEquatable<ShadowSplitData>
{
	[CompilerGenerated]
	[Token(Token = "0x20002FF")]
	[UnsafeValueType]
	internal struct <m_CullingPlanes>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400094E")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[Token(Token = "0x4000947")]
	public static readonly int maximumCullingPlaneCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000948")]
	private int m_CullingPlaneCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[FixedBuffer(typeof(byte), 160)]
	[Token(Token = "0x4000949")]
	internal <m_CullingPlanes>e__FixedBuffer m_CullingPlanes; //Field offset: 0x4
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x400094A")]
	private Vector4 m_CullingSphere; //Field offset: 0xA4
	[FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x400094B")]
	private float m_ShadowCascadeBlendCullingFactor; //Field offset: 0xB4
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400094C")]
	private float m_CullingNearPlane; //Field offset: 0xB8
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x400094D")]
	private Matrix4x4 m_CullingMatrix; //Field offset: 0xBC

	[Token(Token = "0x1700024A")]
	public int cullingPlaneCount
	{
		[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
		[CallerCount(Count = 230)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E89")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x198F0D0", Offset = "0x198E2D0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000E8E")]
	private static ShadowSplitData() { }

	[Address(RVA = "0x198EC10", Offset = "0x198DE10", Length = "0x2C9")]
	[CalledBy(Type = typeof(ShadowSplitData), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ShadowSplitData), Member = "GetCullingPlane", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Plane))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000E8B")]
	public override bool Equals(ShadowSplitData other) { }

	[Address(RVA = "0x198EAB0", Offset = "0x198DCB0", Length = "0x151")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(ShadowSplitData), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShadowSplitData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000E8C")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
	[CallerCount(Count = 230)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E89")]
	public int get_cullingPlaneCount() { }

	[Address(RVA = "0x198EEE0", Offset = "0x198E0E0", Length = "0x152")]
	[CalledBy(Type = typeof(ShadowSplitData), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShadowSplitData)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E8A")]
	public Plane GetCullingPlane(int index) { }

	[Address(RVA = "0x198F040", Offset = "0x198E240", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x6000E8D")]
	public virtual int GetHashCode() { }

}

