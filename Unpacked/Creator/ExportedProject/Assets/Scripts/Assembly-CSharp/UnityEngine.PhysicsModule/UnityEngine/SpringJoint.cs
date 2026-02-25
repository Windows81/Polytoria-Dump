namespace UnityEngine;

[NativeClass("Unity::SpringJoint")]
[NativeHeader("Modules/Physics/SpringJoint.h")]
[RequireComponent(typeof(Rigidbody))]
[Token(Token = "0x200002D")]
public class SpringJoint : Joint
{

	[Token(Token = "0x17000084")]
	public float damper
	{
		[Address(RVA = "0x19F4110", Offset = "0x19F3310", Length = "0x76")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveSpringJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000219")]
		 get { } //Length: 118
		[Address(RVA = "0x19F44E0", Offset = "0x19F36E0", Length = "0x86")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveSpringJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600021A")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000086")]
	public float maxDistance
	{
		[Address(RVA = "0x19F41D0", Offset = "0x19F33D0", Length = "0x76")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveSpringJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600021D")]
		 get { } //Length: 118
		[Address(RVA = "0x19F45C0", Offset = "0x19F37C0", Length = "0x86")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveSpringJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600021E")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000085")]
	public float minDistance
	{
		[Address(RVA = "0x19F4290", Offset = "0x19F3490", Length = "0x76")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveSpringJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600021B")]
		 get { } //Length: 118
		[Address(RVA = "0x19F46A0", Offset = "0x19F38A0", Length = "0x86")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveSpringJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600021C")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000083")]
	public float spring
	{
		[Address(RVA = "0x19F4350", Offset = "0x19F3550", Length = "0x76")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveSpringJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000217")]
		 get { } //Length: 118
		[Address(RVA = "0x19F4780", Offset = "0x19F3980", Length = "0x86")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveSpringJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000218")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000087")]
	public float tolerance
	{
		[Address(RVA = "0x19F4410", Offset = "0x19F3610", Length = "0x76")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveSpringJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600021F")]
		 get { } //Length: 118
		[Address(RVA = "0x19F4860", Offset = "0x19F3A60", Length = "0x35F")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveSpringJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ObjectPool`1), Member = "get_CountInactive", ReturnType = typeof(int))]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "Unity.Properties.Internal.ReflectedPropertyBagProvider+<GetPropertyMembers>d__22", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x6000220")]
		 set { } //Length: 863
	}

	[Address(RVA = "0x19F4110", Offset = "0x19F3310", Length = "0x76")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveSpringJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000219")]
	public float get_damper() { }

	[Address(RVA = "0x19F40D0", Offset = "0x19F32D0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000223")]
	private static float get_damper_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19F41D0", Offset = "0x19F33D0", Length = "0x76")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveSpringJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600021D")]
	public float get_maxDistance() { }

	[Address(RVA = "0x19F4190", Offset = "0x19F3390", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000227")]
	private static float get_maxDistance_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19F4290", Offset = "0x19F3490", Length = "0x76")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveSpringJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600021B")]
	public float get_minDistance() { }

	[Address(RVA = "0x19F4250", Offset = "0x19F3450", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000225")]
	private static float get_minDistance_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19F4350", Offset = "0x19F3550", Length = "0x76")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveSpringJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000217")]
	public float get_spring() { }

	[Address(RVA = "0x19F4310", Offset = "0x19F3510", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000221")]
	private static float get_spring_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19F4410", Offset = "0x19F3610", Length = "0x76")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveSpringJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600021F")]
	public float get_tolerance() { }

	[Address(RVA = "0x19F43D0", Offset = "0x19F35D0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000229")]
	private static float get_tolerance_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19F44E0", Offset = "0x19F36E0", Length = "0x86")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveSpringJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600021A")]
	public void set_damper(float value) { }

	[Address(RVA = "0x19F4490", Offset = "0x19F3690", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000224")]
	private static void set_damper_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x19F45C0", Offset = "0x19F37C0", Length = "0x86")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveSpringJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600021E")]
	public void set_maxDistance(float value) { }

	[Address(RVA = "0x19F4570", Offset = "0x19F3770", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000228")]
	private static void set_maxDistance_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x19F46A0", Offset = "0x19F38A0", Length = "0x86")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveSpringJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600021C")]
	public void set_minDistance(float value) { }

	[Address(RVA = "0x19F4650", Offset = "0x19F3850", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000226")]
	private static void set_minDistance_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x19F4780", Offset = "0x19F3980", Length = "0x86")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveSpringJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000218")]
	public void set_spring(float value) { }

	[Address(RVA = "0x19F4730", Offset = "0x19F3930", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000222")]
	private static void set_spring_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x19F4860", Offset = "0x19F3A60", Length = "0x35F")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveSpringJoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = "Unity.Properties.Internal.ReflectedPropertyBagProvider+<GetPropertyMembers>d__22", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectPool`1), Member = "get_CountInactive", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000220")]
	public void set_tolerance(float value) { }

	[Address(RVA = "0x19F4810", Offset = "0x19F3A10", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600022A")]
	private static void set_tolerance_Injected(IntPtr _unity_self, float value) { }

}

