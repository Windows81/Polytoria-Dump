namespace UnityEngine;

[NativeClass("Unity::ConfigurableJoint")]
[NativeHeader("Modules/Physics/ConfigurableJoint.h")]
[RequireComponent(typeof(Rigidbody))]
[Token(Token = "0x2000016")]
public class ConfigurableJoint : Joint
{

	[Token(Token = "0x17000036")]
	public JointDrive angularXDrive
	{
		[Address(RVA = "0x19E6210", Offset = "0x19E5410", Length = "0x8E")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000095")]
		 get { } //Length: 142
		[Address(RVA = "0x19E7C40", Offset = "0x19E6E40", Length = "0x85")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000096")]
		 set { } //Length: 133
	}

	[Token(Token = "0x17000027")]
	public SoftJointLimitSpring angularXLimitSpring
	{
		[Address(RVA = "0x19E62F0", Offset = "0x19E54F0", Length = "0x87")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000077")]
		 get { } //Length: 135
		[Address(RVA = "0x19E7D20", Offset = "0x19E6F20", Length = "0x80")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000078")]
		 set { } //Length: 128
	}

	[Token(Token = "0x17000023")]
	public ConfigurableJointMotion angularXMotion
	{
		[Address(RVA = "0x19E63C0", Offset = "0x19E55C0", Length = "0x76")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600006F")]
		 get { } //Length: 118
		[Address(RVA = "0x19E7DF0", Offset = "0x19E6FF0", Length = "0x83")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000070")]
		 set { } //Length: 131
	}

	[Token(Token = "0x1700002C")]
	public SoftJointLimit angularYLimit
	{
		[Address(RVA = "0x19E6490", Offset = "0x19E5690", Length = "0x90")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000081")]
		 get { } //Length: 144
		[Address(RVA = "0x19E7ED0", Offset = "0x19E70D0", Length = "0x85")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000082")]
		 set { } //Length: 133
	}

	[Token(Token = "0x17000024")]
	public ConfigurableJointMotion angularYMotion
	{
		[Address(RVA = "0x19E6570", Offset = "0x19E5770", Length = "0x76")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000071")]
		 get { } //Length: 118
		[Address(RVA = "0x19E7FA0", Offset = "0x19E71A0", Length = "0x83")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000072")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000037")]
	public JointDrive angularYZDrive
	{
		[Address(RVA = "0x19E6640", Offset = "0x19E5840", Length = "0x8E")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000097")]
		 get { } //Length: 142
		[Address(RVA = "0x19E8080", Offset = "0x19E7280", Length = "0x85")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000098")]
		 set { } //Length: 133
	}

	[Token(Token = "0x17000028")]
	public SoftJointLimitSpring angularYZLimitSpring
	{
		[Address(RVA = "0x19E6720", Offset = "0x19E5920", Length = "0x87")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000079")]
		 get { } //Length: 135
		[Address(RVA = "0x19E8160", Offset = "0x19E7360", Length = "0x80")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600007A")]
		 set { } //Length: 128
	}

	[Token(Token = "0x1700002D")]
	public SoftJointLimit angularZLimit
	{
		[Address(RVA = "0x19E6800", Offset = "0x19E5A00", Length = "0x90")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000083")]
		 get { } //Length: 144
		[Address(RVA = "0x19E8240", Offset = "0x19E7440", Length = "0x85")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000084")]
		 set { } //Length: 133
	}

	[Token(Token = "0x17000025")]
	public ConfigurableJointMotion angularZMotion
	{
		[Address(RVA = "0x19E68E0", Offset = "0x19E5AE0", Length = "0x76")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000073")]
		 get { } //Length: 118
		[Address(RVA = "0x19E8310", Offset = "0x19E7510", Length = "0x83")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000074")]
		 set { } //Length: 131
	}

	[Token(Token = "0x1700003C")]
	public bool configuredInWorldSpace
	{
		[Address(RVA = "0x19E69A0", Offset = "0x19E5BA0", Length = "0x76")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60000A1")]
		 get { } //Length: 118
		[Address(RVA = "0x19E83F0", Offset = "0x19E75F0", Length = "0x86")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60000A2")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700002B")]
	public SoftJointLimit highAngularXLimit
	{
		[Address(RVA = "0x19E6A70", Offset = "0x19E5C70", Length = "0x90")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600007F")]
		 get { } //Length: 144
		[Address(RVA = "0x19E84D0", Offset = "0x19E76D0", Length = "0x85")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000080")]
		 set { } //Length: 133
	}

	[Token(Token = "0x17000029")]
	public SoftJointLimit linearLimit
	{
		[Address(RVA = "0x19E6C40", Offset = "0x19E5E40", Length = "0x90")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600007B")]
		 get { } //Length: 144
		[Address(RVA = "0x19E8690", Offset = "0x19E7890", Length = "0x85")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600007C")]
		 set { } //Length: 133
	}

	[Token(Token = "0x17000026")]
	public SoftJointLimitSpring linearLimitSpring
	{
		[Address(RVA = "0x19E6B60", Offset = "0x19E5D60", Length = "0x87")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000075")]
		 get { } //Length: 135
		[Address(RVA = "0x19E85B0", Offset = "0x19E77B0", Length = "0x80")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000076")]
		 set { } //Length: 128
	}

	[Token(Token = "0x1700002A")]
	public SoftJointLimit lowAngularXLimit
	{
		[Address(RVA = "0x19E6D30", Offset = "0x19E5F30", Length = "0x90")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600007D")]
		 get { } //Length: 144
		[Address(RVA = "0x19E8770", Offset = "0x19E7970", Length = "0x85")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600007E")]
		 set { } //Length: 133
	}

	[Token(Token = "0x1700003B")]
	public float projectionAngle
	{
		[Address(RVA = "0x19E6E10", Offset = "0x19E6010", Length = "0x76")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600009F")]
		 get { } //Length: 118
		[Address(RVA = "0x19E8850", Offset = "0x19E7A50", Length = "0x86")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60000A0")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700003A")]
	public float projectionDistance
	{
		[Address(RVA = "0x19E6ED0", Offset = "0x19E60D0", Length = "0x76")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600009D")]
		 get { } //Length: 118
		[Address(RVA = "0x19E8930", Offset = "0x19E7B30", Length = "0x86")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600009E")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000039")]
	public JointProjectionMode projectionMode
	{
		[Address(RVA = "0x19E6F90", Offset = "0x19E6190", Length = "0x76")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600009B")]
		 get { } //Length: 118
		[Address(RVA = "0x19E8A00", Offset = "0x19E7C00", Length = "0x83")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600009C")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000035")]
	public RotationDriveMode rotationDriveMode
	{
		[Address(RVA = "0x19E7050", Offset = "0x19E6250", Length = "0x76")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000093")]
		 get { } //Length: 118
		[Address(RVA = "0x19E8AD0", Offset = "0x19E7CD0", Length = "0x83")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000094")]
		 set { } //Length: 131
	}

	[Token(Token = "0x1700001F")]
	public Vector3 secondaryAxis
	{
		[Address(RVA = "0x19E7120", Offset = "0x19E6320", Length = "0x90")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000067")]
		 get { } //Length: 144
		[Address(RVA = "0x19E8BB0", Offset = "0x19E7DB0", Length = "0x85")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000068")]
		 set { } //Length: 133
	}

	[Token(Token = "0x17000038")]
	public JointDrive slerpDrive
	{
		[Address(RVA = "0x19E7210", Offset = "0x19E6410", Length = "0x8E")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000099")]
		 get { } //Length: 142
		[Address(RVA = "0x19E8C90", Offset = "0x19E7E90", Length = "0x85")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600009A")]
		 set { } //Length: 133
	}

	[Token(Token = "0x1700003D")]
	public bool swapBodies
	{
		[Address(RVA = "0x19E72E0", Offset = "0x19E64E0", Length = "0x76")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60000A3")]
		 get { } //Length: 118
		[Address(RVA = "0x19E8D70", Offset = "0x19E7F70", Length = "0x86")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60000A4")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000034")]
	public Vector3 targetAngularVelocity
	{
		[Address(RVA = "0x19E73B0", Offset = "0x19E65B0", Length = "0x90")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000091")]
		 get { } //Length: 144
		[Address(RVA = "0x19E8E50", Offset = "0x19E8050", Length = "0x85")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000092")]
		 set { } //Length: 133
	}

	[Token(Token = "0x1700002E")]
	public Vector3 targetPosition
	{
		[Address(RVA = "0x19E74A0", Offset = "0x19E66A0", Length = "0x90")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000085")]
		 get { } //Length: 144
		[Address(RVA = "0x19E8F30", Offset = "0x19E8130", Length = "0x85")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000086")]
		 set { } //Length: 133
	}

	[Token(Token = "0x17000033")]
	public Quaternion targetRotation
	{
		[Address(RVA = "0x19E7590", Offset = "0x19E6790", Length = "0x8E")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600008F")]
		 get { } //Length: 142
		[Address(RVA = "0x19E9010", Offset = "0x19E8210", Length = "0x85")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000090")]
		 set { } //Length: 133
	}

	[Token(Token = "0x1700002F")]
	public Vector3 targetVelocity
	{
		[Address(RVA = "0x19E7670", Offset = "0x19E6870", Length = "0x90")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000087")]
		 get { } //Length: 144
		[Address(RVA = "0x19E90F0", Offset = "0x19E82F0", Length = "0x85")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000088")]
		 set { } //Length: 133
	}

	[Token(Token = "0x17000030")]
	public JointDrive xDrive
	{
		[Address(RVA = "0x19E7760", Offset = "0x19E6960", Length = "0x8E")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000089")]
		 get { } //Length: 142
		[Address(RVA = "0x19E91D0", Offset = "0x19E83D0", Length = "0x85")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600008A")]
		 set { } //Length: 133
	}

	[Token(Token = "0x17000020")]
	public ConfigurableJointMotion xMotion
	{
		[Address(RVA = "0x19E7830", Offset = "0x19E6A30", Length = "0x76")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000069")]
		 get { } //Length: 118
		[Address(RVA = "0x19E92A0", Offset = "0x19E84A0", Length = "0x83")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600006A")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000031")]
	public JointDrive yDrive
	{
		[Address(RVA = "0x19E7900", Offset = "0x19E6B00", Length = "0x8E")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600008B")]
		 get { } //Length: 142
		[Address(RVA = "0x19E9380", Offset = "0x19E8580", Length = "0x85")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600008C")]
		 set { } //Length: 133
	}

	[Token(Token = "0x17000021")]
	public ConfigurableJointMotion yMotion
	{
		[Address(RVA = "0x19E79D0", Offset = "0x19E6BD0", Length = "0x76")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600006B")]
		 get { } //Length: 118
		[Address(RVA = "0x19E9450", Offset = "0x19E8650", Length = "0x83")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600006C")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000032")]
	public JointDrive zDrive
	{
		[Address(RVA = "0x19E7AA0", Offset = "0x19E6CA0", Length = "0x8E")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600008D")]
		 get { } //Length: 142
		[Address(RVA = "0x19E9530", Offset = "0x19E8730", Length = "0x85")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600008E")]
		 set { } //Length: 133
	}

	[Token(Token = "0x17000022")]
	public ConfigurableJointMotion zMotion
	{
		[Address(RVA = "0x19E7B70", Offset = "0x19E6D70", Length = "0x76")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600006D")]
		 get { } //Length: 118
		[Address(RVA = "0x19E9600", Offset = "0x19E8800", Length = "0x83")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600006E")]
		 set { } //Length: 131
	}

	[Address(RVA = "0x19E6210", Offset = "0x19E5410", Length = "0x8E")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000095")]
	public JointDrive get_angularXDrive() { }

	[Address(RVA = "0x19E61C0", Offset = "0x19E53C0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000D3")]
	private static void get_angularXDrive_Injected(IntPtr _unity_self, out JointDrive ret) { }

	[Address(RVA = "0x19E62F0", Offset = "0x19E54F0", Length = "0x87")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000077")]
	public SoftJointLimitSpring get_angularXLimitSpring() { }

	[Address(RVA = "0x19E62A0", Offset = "0x19E54A0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000B5")]
	private static void get_angularXLimitSpring_Injected(IntPtr _unity_self, out SoftJointLimitSpring ret) { }

	[Address(RVA = "0x19E63C0", Offset = "0x19E55C0", Length = "0x76")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600006F")]
	public ConfigurableJointMotion get_angularXMotion() { }

	[Address(RVA = "0x19E6380", Offset = "0x19E5580", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000AD")]
	private static ConfigurableJointMotion get_angularXMotion_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19E6490", Offset = "0x19E5690", Length = "0x90")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000081")]
	public SoftJointLimit get_angularYLimit() { }

	[Address(RVA = "0x19E6440", Offset = "0x19E5640", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000BF")]
	private static void get_angularYLimit_Injected(IntPtr _unity_self, out SoftJointLimit ret) { }

	[Address(RVA = "0x19E6570", Offset = "0x19E5770", Length = "0x76")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000071")]
	public ConfigurableJointMotion get_angularYMotion() { }

	[Address(RVA = "0x19E6530", Offset = "0x19E5730", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000AF")]
	private static ConfigurableJointMotion get_angularYMotion_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19E6640", Offset = "0x19E5840", Length = "0x8E")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000097")]
	public JointDrive get_angularYZDrive() { }

	[Address(RVA = "0x19E65F0", Offset = "0x19E57F0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000D5")]
	private static void get_angularYZDrive_Injected(IntPtr _unity_self, out JointDrive ret) { }

	[Address(RVA = "0x19E6720", Offset = "0x19E5920", Length = "0x87")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000079")]
	public SoftJointLimitSpring get_angularYZLimitSpring() { }

	[Address(RVA = "0x19E66D0", Offset = "0x19E58D0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000B7")]
	private static void get_angularYZLimitSpring_Injected(IntPtr _unity_self, out SoftJointLimitSpring ret) { }

	[Address(RVA = "0x19E6800", Offset = "0x19E5A00", Length = "0x90")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000083")]
	public SoftJointLimit get_angularZLimit() { }

	[Address(RVA = "0x19E67B0", Offset = "0x19E59B0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000C1")]
	private static void get_angularZLimit_Injected(IntPtr _unity_self, out SoftJointLimit ret) { }

	[Address(RVA = "0x19E68E0", Offset = "0x19E5AE0", Length = "0x76")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000073")]
	public ConfigurableJointMotion get_angularZMotion() { }

	[Address(RVA = "0x19E68A0", Offset = "0x19E5AA0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000B1")]
	private static ConfigurableJointMotion get_angularZMotion_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19E69A0", Offset = "0x19E5BA0", Length = "0x76")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000A1")]
	public bool get_configuredInWorldSpace() { }

	[Address(RVA = "0x19E6960", Offset = "0x19E5B60", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000DF")]
	private static bool get_configuredInWorldSpace_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19E6A70", Offset = "0x19E5C70", Length = "0x90")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600007F")]
	public SoftJointLimit get_highAngularXLimit() { }

	[Address(RVA = "0x19E6A20", Offset = "0x19E5C20", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000BD")]
	private static void get_highAngularXLimit_Injected(IntPtr _unity_self, out SoftJointLimit ret) { }

	[Address(RVA = "0x19E6C40", Offset = "0x19E5E40", Length = "0x90")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600007B")]
	public SoftJointLimit get_linearLimit() { }

	[Address(RVA = "0x19E6BF0", Offset = "0x19E5DF0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000B9")]
	private static void get_linearLimit_Injected(IntPtr _unity_self, out SoftJointLimit ret) { }

	[Address(RVA = "0x19E6B60", Offset = "0x19E5D60", Length = "0x87")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000075")]
	public SoftJointLimitSpring get_linearLimitSpring() { }

	[Address(RVA = "0x19E6B10", Offset = "0x19E5D10", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000B3")]
	private static void get_linearLimitSpring_Injected(IntPtr _unity_self, out SoftJointLimitSpring ret) { }

	[Address(RVA = "0x19E6D30", Offset = "0x19E5F30", Length = "0x90")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600007D")]
	public SoftJointLimit get_lowAngularXLimit() { }

	[Address(RVA = "0x19E6CE0", Offset = "0x19E5EE0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000BB")]
	private static void get_lowAngularXLimit_Injected(IntPtr _unity_self, out SoftJointLimit ret) { }

	[Address(RVA = "0x19E6E10", Offset = "0x19E6010", Length = "0x76")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600009F")]
	public float get_projectionAngle() { }

	[Address(RVA = "0x19E6DD0", Offset = "0x19E5FD0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000DD")]
	private static float get_projectionAngle_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19E6ED0", Offset = "0x19E60D0", Length = "0x76")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600009D")]
	public float get_projectionDistance() { }

	[Address(RVA = "0x19E6E90", Offset = "0x19E6090", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000DB")]
	private static float get_projectionDistance_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19E6F90", Offset = "0x19E6190", Length = "0x76")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600009B")]
	public JointProjectionMode get_projectionMode() { }

	[Address(RVA = "0x19E6F50", Offset = "0x19E6150", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000D9")]
	private static JointProjectionMode get_projectionMode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19E7050", Offset = "0x19E6250", Length = "0x76")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000093")]
	public RotationDriveMode get_rotationDriveMode() { }

	[Address(RVA = "0x19E7010", Offset = "0x19E6210", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000D1")]
	private static RotationDriveMode get_rotationDriveMode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19E7120", Offset = "0x19E6320", Length = "0x90")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000067")]
	public Vector3 get_secondaryAxis() { }

	[Address(RVA = "0x19E70D0", Offset = "0x19E62D0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000A5")]
	private static void get_secondaryAxis_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x19E7210", Offset = "0x19E6410", Length = "0x8E")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000099")]
	public JointDrive get_slerpDrive() { }

	[Address(RVA = "0x19E71C0", Offset = "0x19E63C0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000D7")]
	private static void get_slerpDrive_Injected(IntPtr _unity_self, out JointDrive ret) { }

	[Address(RVA = "0x19E72E0", Offset = "0x19E64E0", Length = "0x76")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000A3")]
	public bool get_swapBodies() { }

	[Address(RVA = "0x19E72A0", Offset = "0x19E64A0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000E1")]
	private static bool get_swapBodies_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19E73B0", Offset = "0x19E65B0", Length = "0x90")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000091")]
	public Vector3 get_targetAngularVelocity() { }

	[Address(RVA = "0x19E7360", Offset = "0x19E6560", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000CF")]
	private static void get_targetAngularVelocity_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x19E74A0", Offset = "0x19E66A0", Length = "0x90")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000085")]
	public Vector3 get_targetPosition() { }

	[Address(RVA = "0x19E7450", Offset = "0x19E6650", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000C3")]
	private static void get_targetPosition_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x19E7590", Offset = "0x19E6790", Length = "0x8E")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600008F")]
	public Quaternion get_targetRotation() { }

	[Address(RVA = "0x19E7540", Offset = "0x19E6740", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000CD")]
	private static void get_targetRotation_Injected(IntPtr _unity_self, out Quaternion ret) { }

	[Address(RVA = "0x19E7670", Offset = "0x19E6870", Length = "0x90")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000087")]
	public Vector3 get_targetVelocity() { }

	[Address(RVA = "0x19E7620", Offset = "0x19E6820", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000C5")]
	private static void get_targetVelocity_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x19E7760", Offset = "0x19E6960", Length = "0x8E")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000089")]
	public JointDrive get_xDrive() { }

	[Address(RVA = "0x19E7710", Offset = "0x19E6910", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000C7")]
	private static void get_xDrive_Injected(IntPtr _unity_self, out JointDrive ret) { }

	[Address(RVA = "0x19E7830", Offset = "0x19E6A30", Length = "0x76")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000069")]
	public ConfigurableJointMotion get_xMotion() { }

	[Address(RVA = "0x19E77F0", Offset = "0x19E69F0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000A7")]
	private static ConfigurableJointMotion get_xMotion_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19E7900", Offset = "0x19E6B00", Length = "0x8E")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600008B")]
	public JointDrive get_yDrive() { }

	[Address(RVA = "0x19E78B0", Offset = "0x19E6AB0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000C9")]
	private static void get_yDrive_Injected(IntPtr _unity_self, out JointDrive ret) { }

	[Address(RVA = "0x19E79D0", Offset = "0x19E6BD0", Length = "0x76")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600006B")]
	public ConfigurableJointMotion get_yMotion() { }

	[Address(RVA = "0x19E7990", Offset = "0x19E6B90", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000A9")]
	private static ConfigurableJointMotion get_yMotion_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19E7AA0", Offset = "0x19E6CA0", Length = "0x8E")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600008D")]
	public JointDrive get_zDrive() { }

	[Address(RVA = "0x19E7A50", Offset = "0x19E6C50", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000CB")]
	private static void get_zDrive_Injected(IntPtr _unity_self, out JointDrive ret) { }

	[Address(RVA = "0x19E7B70", Offset = "0x19E6D70", Length = "0x76")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600006D")]
	public ConfigurableJointMotion get_zMotion() { }

	[Address(RVA = "0x19E7B30", Offset = "0x19E6D30", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000AB")]
	private static ConfigurableJointMotion get_zMotion_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19E7C40", Offset = "0x19E6E40", Length = "0x85")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000096")]
	public void set_angularXDrive(JointDrive value) { }

	[Address(RVA = "0x19E7BF0", Offset = "0x19E6DF0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000D4")]
	private static void set_angularXDrive_Injected(IntPtr _unity_self, in JointDrive value) { }

	[Address(RVA = "0x19E7D20", Offset = "0x19E6F20", Length = "0x80")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000078")]
	public void set_angularXLimitSpring(SoftJointLimitSpring value) { }

	[Address(RVA = "0x19E7CD0", Offset = "0x19E6ED0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000B6")]
	private static void set_angularXLimitSpring_Injected(IntPtr _unity_self, in SoftJointLimitSpring value) { }

	[Address(RVA = "0x19E7DF0", Offset = "0x19E6FF0", Length = "0x83")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000070")]
	public void set_angularXMotion(ConfigurableJointMotion value) { }

	[Address(RVA = "0x19E7DB0", Offset = "0x19E6FB0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000AE")]
	private static void set_angularXMotion_Injected(IntPtr _unity_self, ConfigurableJointMotion value) { }

	[Address(RVA = "0x19E7ED0", Offset = "0x19E70D0", Length = "0x85")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000082")]
	public void set_angularYLimit(SoftJointLimit value) { }

	[Address(RVA = "0x19E7E80", Offset = "0x19E7080", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000C0")]
	private static void set_angularYLimit_Injected(IntPtr _unity_self, in SoftJointLimit value) { }

	[Address(RVA = "0x19E7FA0", Offset = "0x19E71A0", Length = "0x83")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000072")]
	public void set_angularYMotion(ConfigurableJointMotion value) { }

	[Address(RVA = "0x19E7F60", Offset = "0x19E7160", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000B0")]
	private static void set_angularYMotion_Injected(IntPtr _unity_self, ConfigurableJointMotion value) { }

	[Address(RVA = "0x19E8080", Offset = "0x19E7280", Length = "0x85")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000098")]
	public void set_angularYZDrive(JointDrive value) { }

	[Address(RVA = "0x19E8030", Offset = "0x19E7230", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000D6")]
	private static void set_angularYZDrive_Injected(IntPtr _unity_self, in JointDrive value) { }

	[Address(RVA = "0x19E8160", Offset = "0x19E7360", Length = "0x80")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600007A")]
	public void set_angularYZLimitSpring(SoftJointLimitSpring value) { }

	[Address(RVA = "0x19E8110", Offset = "0x19E7310", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000B8")]
	private static void set_angularYZLimitSpring_Injected(IntPtr _unity_self, in SoftJointLimitSpring value) { }

	[Address(RVA = "0x19E8240", Offset = "0x19E7440", Length = "0x85")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000084")]
	public void set_angularZLimit(SoftJointLimit value) { }

	[Address(RVA = "0x19E81F0", Offset = "0x19E73F0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000C2")]
	private static void set_angularZLimit_Injected(IntPtr _unity_self, in SoftJointLimit value) { }

	[Address(RVA = "0x19E8310", Offset = "0x19E7510", Length = "0x83")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000074")]
	public void set_angularZMotion(ConfigurableJointMotion value) { }

	[Address(RVA = "0x19E82D0", Offset = "0x19E74D0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000B2")]
	private static void set_angularZMotion_Injected(IntPtr _unity_self, ConfigurableJointMotion value) { }

	[Address(RVA = "0x19E83F0", Offset = "0x19E75F0", Length = "0x86")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000A2")]
	public void set_configuredInWorldSpace(bool value) { }

	[Address(RVA = "0x19E83A0", Offset = "0x19E75A0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000E0")]
	private static void set_configuredInWorldSpace_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x19E84D0", Offset = "0x19E76D0", Length = "0x85")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000080")]
	public void set_highAngularXLimit(SoftJointLimit value) { }

	[Address(RVA = "0x19E8480", Offset = "0x19E7680", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000BE")]
	private static void set_highAngularXLimit_Injected(IntPtr _unity_self, in SoftJointLimit value) { }

	[Address(RVA = "0x19E8690", Offset = "0x19E7890", Length = "0x85")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600007C")]
	public void set_linearLimit(SoftJointLimit value) { }

	[Address(RVA = "0x19E8640", Offset = "0x19E7840", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000BA")]
	private static void set_linearLimit_Injected(IntPtr _unity_self, in SoftJointLimit value) { }

	[Address(RVA = "0x19E85B0", Offset = "0x19E77B0", Length = "0x80")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000076")]
	public void set_linearLimitSpring(SoftJointLimitSpring value) { }

	[Address(RVA = "0x19E8560", Offset = "0x19E7760", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000B4")]
	private static void set_linearLimitSpring_Injected(IntPtr _unity_self, in SoftJointLimitSpring value) { }

	[Address(RVA = "0x19E8770", Offset = "0x19E7970", Length = "0x85")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600007E")]
	public void set_lowAngularXLimit(SoftJointLimit value) { }

	[Address(RVA = "0x19E8720", Offset = "0x19E7920", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000BC")]
	private static void set_lowAngularXLimit_Injected(IntPtr _unity_self, in SoftJointLimit value) { }

	[Address(RVA = "0x19E8850", Offset = "0x19E7A50", Length = "0x86")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000A0")]
	public void set_projectionAngle(float value) { }

	[Address(RVA = "0x19E8800", Offset = "0x19E7A00", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000DE")]
	private static void set_projectionAngle_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x19E8930", Offset = "0x19E7B30", Length = "0x86")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600009E")]
	public void set_projectionDistance(float value) { }

	[Address(RVA = "0x19E88E0", Offset = "0x19E7AE0", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000DC")]
	private static void set_projectionDistance_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x19E8A00", Offset = "0x19E7C00", Length = "0x83")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600009C")]
	public void set_projectionMode(JointProjectionMode value) { }

	[Address(RVA = "0x19E89C0", Offset = "0x19E7BC0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000DA")]
	private static void set_projectionMode_Injected(IntPtr _unity_self, JointProjectionMode value) { }

	[Address(RVA = "0x19E8AD0", Offset = "0x19E7CD0", Length = "0x83")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000094")]
	public void set_rotationDriveMode(RotationDriveMode value) { }

	[Address(RVA = "0x19E8A90", Offset = "0x19E7C90", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000D2")]
	private static void set_rotationDriveMode_Injected(IntPtr _unity_self, RotationDriveMode value) { }

	[Address(RVA = "0x19E8BB0", Offset = "0x19E7DB0", Length = "0x85")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000068")]
	public void set_secondaryAxis(Vector3 value) { }

	[Address(RVA = "0x19E8B60", Offset = "0x19E7D60", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000A6")]
	private static void set_secondaryAxis_Injected(IntPtr _unity_self, in Vector3 value) { }

	[Address(RVA = "0x19E8C90", Offset = "0x19E7E90", Length = "0x85")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600009A")]
	public void set_slerpDrive(JointDrive value) { }

	[Address(RVA = "0x19E8C40", Offset = "0x19E7E40", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000D8")]
	private static void set_slerpDrive_Injected(IntPtr _unity_self, in JointDrive value) { }

	[Address(RVA = "0x19E8D70", Offset = "0x19E7F70", Length = "0x86")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000A4")]
	public void set_swapBodies(bool value) { }

	[Address(RVA = "0x19E8D20", Offset = "0x19E7F20", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000E2")]
	private static void set_swapBodies_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x19E8E50", Offset = "0x19E8050", Length = "0x85")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000092")]
	public void set_targetAngularVelocity(Vector3 value) { }

	[Address(RVA = "0x19E8E00", Offset = "0x19E8000", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000D0")]
	private static void set_targetAngularVelocity_Injected(IntPtr _unity_self, in Vector3 value) { }

	[Address(RVA = "0x19E8F30", Offset = "0x19E8130", Length = "0x85")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000086")]
	public void set_targetPosition(Vector3 value) { }

	[Address(RVA = "0x19E8EE0", Offset = "0x19E80E0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000C4")]
	private static void set_targetPosition_Injected(IntPtr _unity_self, in Vector3 value) { }

	[Address(RVA = "0x19E9010", Offset = "0x19E8210", Length = "0x85")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000090")]
	public void set_targetRotation(Quaternion value) { }

	[Address(RVA = "0x19E8FC0", Offset = "0x19E81C0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000CE")]
	private static void set_targetRotation_Injected(IntPtr _unity_self, in Quaternion value) { }

	[Address(RVA = "0x19E90F0", Offset = "0x19E82F0", Length = "0x85")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000088")]
	public void set_targetVelocity(Vector3 value) { }

	[Address(RVA = "0x19E90A0", Offset = "0x19E82A0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000C6")]
	private static void set_targetVelocity_Injected(IntPtr _unity_self, in Vector3 value) { }

	[Address(RVA = "0x19E91D0", Offset = "0x19E83D0", Length = "0x85")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600008A")]
	public void set_xDrive(JointDrive value) { }

	[Address(RVA = "0x19E9180", Offset = "0x19E8380", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000C8")]
	private static void set_xDrive_Injected(IntPtr _unity_self, in JointDrive value) { }

	[Address(RVA = "0x19E92A0", Offset = "0x19E84A0", Length = "0x83")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600006A")]
	public void set_xMotion(ConfigurableJointMotion value) { }

	[Address(RVA = "0x19E9260", Offset = "0x19E8460", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000A8")]
	private static void set_xMotion_Injected(IntPtr _unity_self, ConfigurableJointMotion value) { }

	[Address(RVA = "0x19E9380", Offset = "0x19E8580", Length = "0x85")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600008C")]
	public void set_yDrive(JointDrive value) { }

	[Address(RVA = "0x19E9330", Offset = "0x19E8530", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000CA")]
	private static void set_yDrive_Injected(IntPtr _unity_self, in JointDrive value) { }

	[Address(RVA = "0x19E9450", Offset = "0x19E8650", Length = "0x83")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600006C")]
	public void set_yMotion(ConfigurableJointMotion value) { }

	[Address(RVA = "0x19E9410", Offset = "0x19E8610", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000AA")]
	private static void set_yMotion_Injected(IntPtr _unity_self, ConfigurableJointMotion value) { }

	[Address(RVA = "0x19E9530", Offset = "0x19E8730", Length = "0x85")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600008E")]
	public void set_zDrive(JointDrive value) { }

	[Address(RVA = "0x19E94E0", Offset = "0x19E86E0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000CC")]
	private static void set_zDrive_Injected(IntPtr _unity_self, in JointDrive value) { }

	[Address(RVA = "0x19E9600", Offset = "0x19E8800", Length = "0x83")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveConfigurableJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600006E")]
	public void set_zMotion(ConfigurableJointMotion value) { }

	[Address(RVA = "0x19E95C0", Offset = "0x19E87C0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000AC")]
	private static void set_zMotion_Injected(IntPtr _unity_self, ConfigurableJointMotion value) { }

}

