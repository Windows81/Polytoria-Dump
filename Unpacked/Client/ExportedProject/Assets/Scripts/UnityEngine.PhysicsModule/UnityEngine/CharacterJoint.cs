namespace UnityEngine;

[NativeClass("Unity::CharacterJoint")]
[NativeHeader("Modules/Physics/CharacterJoint.h")]
[RequireComponent(typeof(Rigidbody))]
[Token(Token = "0x2000011")]
public class CharacterJoint : Joint
{

	[Token(Token = "0x17000016")]
	public bool enableProjection
	{
		[Address(RVA = "0x19E3E70", Offset = "0x19E3070", Length = "0x76")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveCharacterJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000033")]
		 get { } //Length: 118
		[Address(RVA = "0x19E4730", Offset = "0x19E3930", Length = "0x86")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveCharacterJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000034")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000013")]
	public SoftJointLimit highTwistLimit
	{
		[Address(RVA = "0x19E3F40", Offset = "0x19E3140", Length = "0x90")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveCharacterJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600002D")]
		 get { } //Length: 144
		[Address(RVA = "0x19E4810", Offset = "0x19E3A10", Length = "0x85")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveCharacterJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600002E")]
		 set { } //Length: 133
	}

	[Token(Token = "0x17000012")]
	public SoftJointLimit lowTwistLimit
	{
		[Address(RVA = "0x19E4030", Offset = "0x19E3230", Length = "0x90")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveCharacterJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600002B")]
		 get { } //Length: 144
		[Address(RVA = "0x19E48F0", Offset = "0x19E3AF0", Length = "0x85")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveCharacterJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600002C")]
		 set { } //Length: 133
	}

	[Token(Token = "0x17000018")]
	public float projectionAngle
	{
		[Address(RVA = "0x19E4110", Offset = "0x19E3310", Length = "0x76")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveCharacterJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000037")]
		 get { } //Length: 118
		[Address(RVA = "0x19E49D0", Offset = "0x19E3BD0", Length = "0x86")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveCharacterJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000038")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000017")]
	public float projectionDistance
	{
		[Address(RVA = "0x19E41D0", Offset = "0x19E33D0", Length = "0x76")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveCharacterJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000035")]
		 get { } //Length: 118
		[Address(RVA = "0x19E4AB0", Offset = "0x19E3CB0", Length = "0x86")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveCharacterJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000036")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000014")]
	public SoftJointLimit swing1Limit
	{
		[Address(RVA = "0x19E42A0", Offset = "0x19E34A0", Length = "0x90")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveCharacterJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600002F")]
		 get { } //Length: 144
		[Address(RVA = "0x19E4B90", Offset = "0x19E3D90", Length = "0x85")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveCharacterJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000030")]
		 set { } //Length: 133
	}

	[Token(Token = "0x17000015")]
	public SoftJointLimit swing2Limit
	{
		[Address(RVA = "0x19E4390", Offset = "0x19E3590", Length = "0x90")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveCharacterJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000031")]
		 get { } //Length: 144
		[Address(RVA = "0x19E4C70", Offset = "0x19E3E70", Length = "0x85")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveCharacterJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000032")]
		 set { } //Length: 133
	}

	[Token(Token = "0x1700000F")]
	public Vector3 swingAxis
	{
		[Address(RVA = "0x19E4480", Offset = "0x19E3680", Length = "0x90")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveCharacterJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000025")]
		 get { } //Length: 144
		[Address(RVA = "0x19E4D50", Offset = "0x19E3F50", Length = "0x85")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveCharacterJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000026")]
		 set { } //Length: 133
	}

	[Token(Token = "0x17000011")]
	public SoftJointLimitSpring swingLimitSpring
	{
		[Address(RVA = "0x19E4570", Offset = "0x19E3770", Length = "0x87")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveCharacterJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000029")]
		 get { } //Length: 135
		[Address(RVA = "0x19E4E30", Offset = "0x19E4030", Length = "0x80")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveCharacterJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600002A")]
		 set { } //Length: 128
	}

	[Token(Token = "0x17000010")]
	public SoftJointLimitSpring twistLimitSpring
	{
		[Address(RVA = "0x19E4650", Offset = "0x19E3850", Length = "0x87")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveCharacterJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000027")]
		 get { } //Length: 135
		[Address(RVA = "0x19E4F10", Offset = "0x19E4110", Length = "0x80")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveCharacterJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000028")]
		 set { } //Length: 128
	}

	[Address(RVA = "0x19E3E70", Offset = "0x19E3070", Length = "0x76")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveCharacterJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000033")]
	public bool get_enableProjection() { }

	[Address(RVA = "0x19E3E30", Offset = "0x19E3030", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000047")]
	private static bool get_enableProjection_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19E3F40", Offset = "0x19E3140", Length = "0x90")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveCharacterJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002D")]
	public SoftJointLimit get_highTwistLimit() { }

	[Address(RVA = "0x19E3EF0", Offset = "0x19E30F0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000041")]
	private static void get_highTwistLimit_Injected(IntPtr _unity_self, out SoftJointLimit ret) { }

	[Address(RVA = "0x19E4030", Offset = "0x19E3230", Length = "0x90")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveCharacterJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002B")]
	public SoftJointLimit get_lowTwistLimit() { }

	[Address(RVA = "0x19E3FE0", Offset = "0x19E31E0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003F")]
	private static void get_lowTwistLimit_Injected(IntPtr _unity_self, out SoftJointLimit ret) { }

	[Address(RVA = "0x19E4110", Offset = "0x19E3310", Length = "0x76")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveCharacterJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000037")]
	public float get_projectionAngle() { }

	[Address(RVA = "0x19E40D0", Offset = "0x19E32D0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004B")]
	private static float get_projectionAngle_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19E41D0", Offset = "0x19E33D0", Length = "0x76")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveCharacterJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000035")]
	public float get_projectionDistance() { }

	[Address(RVA = "0x19E4190", Offset = "0x19E3390", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000049")]
	private static float get_projectionDistance_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19E42A0", Offset = "0x19E34A0", Length = "0x90")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveCharacterJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002F")]
	public SoftJointLimit get_swing1Limit() { }

	[Address(RVA = "0x19E4250", Offset = "0x19E3450", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000043")]
	private static void get_swing1Limit_Injected(IntPtr _unity_self, out SoftJointLimit ret) { }

	[Address(RVA = "0x19E4390", Offset = "0x19E3590", Length = "0x90")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveCharacterJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000031")]
	public SoftJointLimit get_swing2Limit() { }

	[Address(RVA = "0x19E4340", Offset = "0x19E3540", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000045")]
	private static void get_swing2Limit_Injected(IntPtr _unity_self, out SoftJointLimit ret) { }

	[Address(RVA = "0x19E4480", Offset = "0x19E3680", Length = "0x90")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveCharacterJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000025")]
	public Vector3 get_swingAxis() { }

	[Address(RVA = "0x19E4430", Offset = "0x19E3630", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000039")]
	private static void get_swingAxis_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x19E4570", Offset = "0x19E3770", Length = "0x87")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveCharacterJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000029")]
	public SoftJointLimitSpring get_swingLimitSpring() { }

	[Address(RVA = "0x19E4520", Offset = "0x19E3720", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003D")]
	private static void get_swingLimitSpring_Injected(IntPtr _unity_self, out SoftJointLimitSpring ret) { }

	[Address(RVA = "0x19E4650", Offset = "0x19E3850", Length = "0x87")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveCharacterJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000027")]
	public SoftJointLimitSpring get_twistLimitSpring() { }

	[Address(RVA = "0x19E4600", Offset = "0x19E3800", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003B")]
	private static void get_twistLimitSpring_Injected(IntPtr _unity_self, out SoftJointLimitSpring ret) { }

	[Address(RVA = "0x19E4730", Offset = "0x19E3930", Length = "0x86")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveCharacterJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000034")]
	public void set_enableProjection(bool value) { }

	[Address(RVA = "0x19E46E0", Offset = "0x19E38E0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000048")]
	private static void set_enableProjection_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x19E4810", Offset = "0x19E3A10", Length = "0x85")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveCharacterJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002E")]
	public void set_highTwistLimit(SoftJointLimit value) { }

	[Address(RVA = "0x19E47C0", Offset = "0x19E39C0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000042")]
	private static void set_highTwistLimit_Injected(IntPtr _unity_self, in SoftJointLimit value) { }

	[Address(RVA = "0x19E48F0", Offset = "0x19E3AF0", Length = "0x85")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveCharacterJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002C")]
	public void set_lowTwistLimit(SoftJointLimit value) { }

	[Address(RVA = "0x19E48A0", Offset = "0x19E3AA0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000040")]
	private static void set_lowTwistLimit_Injected(IntPtr _unity_self, in SoftJointLimit value) { }

	[Address(RVA = "0x19E49D0", Offset = "0x19E3BD0", Length = "0x86")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveCharacterJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000038")]
	public void set_projectionAngle(float value) { }

	[Address(RVA = "0x19E4980", Offset = "0x19E3B80", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004C")]
	private static void set_projectionAngle_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x19E4AB0", Offset = "0x19E3CB0", Length = "0x86")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveCharacterJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000036")]
	public void set_projectionDistance(float value) { }

	[Address(RVA = "0x19E4A60", Offset = "0x19E3C60", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004A")]
	private static void set_projectionDistance_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x19E4B90", Offset = "0x19E3D90", Length = "0x85")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveCharacterJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000030")]
	public void set_swing1Limit(SoftJointLimit value) { }

	[Address(RVA = "0x19E4B40", Offset = "0x19E3D40", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000044")]
	private static void set_swing1Limit_Injected(IntPtr _unity_self, in SoftJointLimit value) { }

	[Address(RVA = "0x19E4C70", Offset = "0x19E3E70", Length = "0x85")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveCharacterJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000032")]
	public void set_swing2Limit(SoftJointLimit value) { }

	[Address(RVA = "0x19E4C20", Offset = "0x19E3E20", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000046")]
	private static void set_swing2Limit_Injected(IntPtr _unity_self, in SoftJointLimit value) { }

	[Address(RVA = "0x19E4D50", Offset = "0x19E3F50", Length = "0x85")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveCharacterJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000026")]
	public void set_swingAxis(Vector3 value) { }

	[Address(RVA = "0x19E4D00", Offset = "0x19E3F00", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003A")]
	private static void set_swingAxis_Injected(IntPtr _unity_self, in Vector3 value) { }

	[Address(RVA = "0x19E4E30", Offset = "0x19E4030", Length = "0x80")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveCharacterJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002A")]
	public void set_swingLimitSpring(SoftJointLimitSpring value) { }

	[Address(RVA = "0x19E4DE0", Offset = "0x19E3FE0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003E")]
	private static void set_swingLimitSpring_Injected(IntPtr _unity_self, in SoftJointLimitSpring value) { }

	[Address(RVA = "0x19E4F10", Offset = "0x19E4110", Length = "0x80")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveCharacterJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000028")]
	public void set_twistLimitSpring(SoftJointLimitSpring value) { }

	[Address(RVA = "0x19E4EC0", Offset = "0x19E40C0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003C")]
	private static void set_twistLimitSpring_Injected(IntPtr _unity_self, in SoftJointLimitSpring value) { }

}

