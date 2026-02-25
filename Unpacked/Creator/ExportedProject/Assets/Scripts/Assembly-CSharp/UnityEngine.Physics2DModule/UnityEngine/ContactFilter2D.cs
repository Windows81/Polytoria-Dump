namespace UnityEngine;

[NativeClass("ContactFilter", "struct ContactFilter;")]
[NativeHeader("Modules/Physics2D/Public/Collider2D.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[Token(Token = "0x2000005")]
public struct ContactFilter2D
{
	[Token(Token = "0x4000007")]
	private static ContactFilter2D _noFilter; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[NativeName("m_UseTriggers")]
	[Token(Token = "0x4000008")]
	public bool useTriggers; //Field offset: 0x0
	[FieldOffset(Offset = "0x1")]
	[NativeName("m_UseLayerMask")]
	[Token(Token = "0x4000009")]
	public bool useLayerMask; //Field offset: 0x1
	[FieldOffset(Offset = "0x2")]
	[NativeName("m_UseDepth")]
	[Token(Token = "0x400000A")]
	public bool useDepth; //Field offset: 0x2
	[FieldOffset(Offset = "0x3")]
	[NativeName("m_UseOutsideDepth")]
	[Token(Token = "0x400000B")]
	public bool useOutsideDepth; //Field offset: 0x3
	[FieldOffset(Offset = "0x4")]
	[NativeName("m_UseNormalAngle")]
	[Token(Token = "0x400000C")]
	public bool useNormalAngle; //Field offset: 0x4
	[FieldOffset(Offset = "0x5")]
	[NativeName("m_UseOutsideNormalAngle")]
	[Token(Token = "0x400000D")]
	public bool useOutsideNormalAngle; //Field offset: 0x5
	[FieldOffset(Offset = "0x8")]
	[NativeName("m_LayerMask")]
	[Token(Token = "0x400000E")]
	public LayerMask layerMask; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[NativeName("m_MinDepth")]
	[Token(Token = "0x400000F")]
	public float minDepth; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[NativeName("m_MaxDepth")]
	[Token(Token = "0x4000010")]
	public float maxDepth; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[NativeName("m_MinNormalAngle")]
	[Token(Token = "0x4000011")]
	public float minNormalAngle; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[NativeName("m_MaxNormalAngle")]
	[Token(Token = "0x4000012")]
	public float maxNormalAngle; //Field offset: 0x18

	[Address(RVA = "0x19DFBE0", Offset = "0x19DEDE0", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600002E")]
	private static ContactFilter2D() { }

	[Address(RVA = "0x19DF9A0", Offset = "0x19DEBA0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002A")]
	private void CheckConsistency() { }

	[Address(RVA = "0x19DF9E0", Offset = "0x19DEBE0", Length = "0x15F")]
	[CalledBy(Type = typeof(PhysicsScene2D), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(float), typeof(int)}, ReturnType = typeof(RaycastHit2D))]
	[CalledBy(Type = typeof(Physics2D), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(float), typeof(int)}, ReturnType = typeof(RaycastHit2D))]
	[CalledBy(Type = typeof(Physics2D), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(float), typeof(int), typeof(float)}, ReturnType = typeof(RaycastHit2D))]
	[CalledBy(Type = typeof(Physics2D), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(float), typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(RaycastHit2D))]
	[CalledBy(Type = typeof(Physics2D), Member = "OverlapBoxAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(float), typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(Collider2D[]))]
	[CalledBy(Type = typeof(Physics2D), Member = "OverlapAreaAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(Collider2D[]))]
	[CalledBy(Type = typeof(Physics2D), Member = "OverlapAreaAllToBox_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(Collider2D[]))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600002D")]
	internal static ContactFilter2D CreateLegacyFilter(int layerMask, float minDepth, float maxDepth) { }

	[Address(RVA = "0x19DFB40", Offset = "0x19DED40", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002C")]
	public void SetDepth(float minDepth, float maxDepth) { }

	[Address(RVA = "0x19DFBD0", Offset = "0x19DEDD0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600002B")]
	public void SetLayerMask(LayerMask layerMask) { }

}

