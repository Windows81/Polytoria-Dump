namespace UnityEngine;

[Token(Token = "0x2000095")]
[UsedByNativeCode]
public struct Plane : IFormattable
{
	[Token(Token = "0x40001C0")]
	internal const int size = 16; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001C1")]
	private Vector3 m_Normal; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40001C2")]
	private float m_Distance; //Field offset: 0xC

	[Token(Token = "0x1700006E")]
	public float distance
	{
		[Address(RVA = "0x2BC170", Offset = "0x2BB370", Length = "0x8")]
		[CallerCount(Count = 25)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002BB")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700006D")]
	public Vector3 normal
	{
		[Address(RVA = "0x191F110", Offset = "0x191E310", Length = "0x12")]
		[CallerCount(Count = 34)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002BA")]
		 get { } //Length: 18
	}

	[Address(RVA = "0x3AF8F0", Offset = "0x3AEAF0", Length = "0x120")]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "AddInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Polytoria.Datamodel.Instance", typeof(bool)}, ReturnType = "Polytoria.Datamodel.Instance")]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "AddPart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.PartShape", typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "AddSeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_ToEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_MakePositive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x60002BC")]
	public Plane(Vector3 inNormal, Vector3 inPoint) { }

	[Address(RVA = "0x1939660", Offset = "0x1938860", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x60002BD")]
	public Plane(Vector3 inNormal, float d) { }

	[Address(RVA = "0x551C40", Offset = "0x550E40", Length = "0x145")]
	[CalledBy(Type = "RLD.PrismMath", Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Quaternion), "RLD.PrismEpsilon"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.PyramidMath", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(Quaternion)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.PyramidMath", Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(Quaternion), "RLD.PyramidEpsilon"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x60002BE")]
	public Plane(Vector3 a, Vector3 b, Vector3 c) { }

	[Address(RVA = "0x2BC170", Offset = "0x2BB370", Length = "0x8")]
	[CallerCount(Count = 25)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002BB")]
	public float get_distance() { }

	[Address(RVA = "0x191F110", Offset = "0x191E310", Length = "0x12")]
	[CallerCount(Count = 34)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002BA")]
	public Vector3 get_normal() { }

	[Address(RVA = "0x1939500", Offset = "0x1938700", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60002BF")]
	public float GetDistanceToPoint(Vector3 point) { }

	[Address(RVA = "0x3AF7D0", Offset = "0x3AE9D0", Length = "0x120")]
	[CalledBy(Type = "RLD.PyramidMath", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(Quaternion)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.RTSceneGrid", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.RTScene", Member = "RaycastSceneGridIfVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray)}, ReturnType = "RLD.XZGridRayHit")]
	[CalledBy(Type = "RLD.InputDevicePlaneDragSession3D", Member = "UpdateDragPoint", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "AddInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Polytoria.Datamodel.Instance", typeof(bool)}, ReturnType = "Polytoria.Datamodel.Instance")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002C0")]
	public bool Raycast(Ray ray, out float enter) { }

	[Address(RVA = "0x1939650", Offset = "0x1938850", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180E2A860")]
	[Token(Token = "0x60002C1")]
	public virtual string ToString() { }

	[Address(RVA = "0x1939550", Offset = "0x1938750", Length = "0xF8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D86A0")]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002C2")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

