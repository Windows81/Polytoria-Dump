namespace RLD;

[Token(Token = "0x2000184")]
public class Plane2D
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000685")]
	private Vector2 _normal; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000686")]
	private float _distance; //Field offset: 0x18

	[Token(Token = "0x17000588")]
	public float Distance
	{
		[Address(RVA = "0x2BC7F0", Offset = "0x2BB9F0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001122")]
		 get { } //Length: 6
		[Address(RVA = "0x2C1220", Offset = "0x2C0420", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001123")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000587")]
	public Vector2 Normal
	{
		[Address(RVA = "0x563200", Offset = "0x562400", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001120")]
		 get { } //Length: 19
		[Address(RVA = "0x3BCDC0", Offset = "0x3BBFC0", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Vector2), Member = "get_normalized", ReturnType = typeof(Vector2))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001121")]
		 set { } //Length: 59
	}

	[Address(RVA = "0x563140", Offset = "0x562340", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector2), Member = "get_normalized", ReturnType = typeof(Vector2))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001124")]
	public Plane2D(Vector2 normal, float distance) { }

	[Address(RVA = "0x5631A0", Offset = "0x5623A0", Length = "0x5C")]
	[CalledBy(Type = typeof(PrimitiveFactory), Member = "ProjectArcPointsOnPoly2DBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector2), Member = "get_normalized", ReturnType = typeof(Vector2))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001125")]
	public Plane2D(Vector2 normal, Vector2 pointOnPlane) { }

	[Address(RVA = "0x2BC7F0", Offset = "0x2BB9F0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001122")]
	public float get_Distance() { }

	[Address(RVA = "0x563200", Offset = "0x562400", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001120")]
	public Vector2 get_Normal() { }

	[Address(RVA = "0x563080", Offset = "0x562280", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001126")]
	public float GetDistanceToPoint(Vector2 point) { }

	[Address(RVA = "0x5630B0", Offset = "0x5622B0", Length = "0x88")]
	[CalledBy(Type = typeof(PrimitiveFactory), Member = "ProjectArcPointsOnPoly2DBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001127")]
	public bool Raycast(Vector2 rayOrigin, Vector2 rayDir, out float t) { }

	[Address(RVA = "0x2C1220", Offset = "0x2C0420", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001123")]
	public void set_Distance(float value) { }

	[Address(RVA = "0x3BCDC0", Offset = "0x3BBFC0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector2), Member = "get_normalized", ReturnType = typeof(Vector2))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001121")]
	public void set_Normal(Vector2 value) { }

}

