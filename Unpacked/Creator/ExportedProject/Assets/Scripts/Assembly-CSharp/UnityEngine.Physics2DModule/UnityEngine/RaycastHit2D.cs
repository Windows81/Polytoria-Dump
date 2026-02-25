namespace UnityEngine;

[NativeClass("RaycastHit2D", "struct RaycastHit2D;")]
[NativeHeader("Runtime/Interfaces/IPhysics2D.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[Token(Token = "0x2000008")]
public struct RaycastHit2D
{
	[FieldOffset(Offset = "0x0")]
	[NativeName("centroid")]
	[Token(Token = "0x4000029")]
	private Vector2 m_Centroid; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeName("point")]
	[Token(Token = "0x400002A")]
	private Vector2 m_Point; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[NativeName("normal")]
	[Token(Token = "0x400002B")]
	private Vector2 m_Normal; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[NativeName("distance")]
	[Token(Token = "0x400002C")]
	private float m_Distance; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[NativeName("fraction")]
	[Token(Token = "0x400002D")]
	private float m_Fraction; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[NativeName("collider")]
	[Token(Token = "0x400002E")]
	private int m_Collider; //Field offset: 0x20

	[Token(Token = "0x17000006")]
	public Collider2D collider
	{
		[Address(RVA = "0x19E2440", Offset = "0x19E1640", Length = "0x9E")]
		[CalledBy(Type = "RLD.GameObjectRayHit", Member = "Store", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), "System.Collections.Generic.IEnumerable`1<RaycastHit2D>", "System.Collections.Generic.IEnumerable`1<RaycastHit>", "System.Collections.Generic.List`1<GameObjectRayHit>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.GameObjectRayHit", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(RaycastHit2D)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.EventSystems.Physics2DRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "FindObjectFromInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object))]
		[Token(Token = "0x6000032")]
		 get { } //Length: 158
	}

	[Token(Token = "0x17000005")]
	public float distance
	{
		[Address(RVA = "0x2C0D70", Offset = "0x2BFF70", Length = "0x8")]
		[CallerCount(Count = 61)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000031")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000004")]
	public Vector2 normal
	{
		[Address(RVA = "0x19E24E0", Offset = "0x19E16E0", Length = "0x13")]
		[CallerCount(Count = 21)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000030")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000003")]
	public Vector2 point
	{
		[Address(RVA = "0x193C340", Offset = "0x193B540", Length = "0x13")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600002F")]
		 get { } //Length: 19
	}

	[Address(RVA = "0x19E2440", Offset = "0x19E1640", Length = "0x9E")]
	[CalledBy(Type = "RLD.GameObjectRayHit", Member = "Store", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), "System.Collections.Generic.IEnumerable`1<RaycastHit2D>", "System.Collections.Generic.IEnumerable`1<RaycastHit>", "System.Collections.Generic.List`1<GameObjectRayHit>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GameObjectRayHit", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(RaycastHit2D)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.EventSystems.Physics2DRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "FindObjectFromInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object))]
	[Token(Token = "0x6000032")]
	public Collider2D get_collider() { }

	[Address(RVA = "0x2C0D70", Offset = "0x2BFF70", Length = "0x8")]
	[CallerCount(Count = 61)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000031")]
	public float get_distance() { }

	[Address(RVA = "0x19E24E0", Offset = "0x19E16E0", Length = "0x13")]
	[CallerCount(Count = 21)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000030")]
	public Vector2 get_normal() { }

	[Address(RVA = "0x193C340", Offset = "0x193B540", Length = "0x13")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600002F")]
	public Vector2 get_point() { }

}

